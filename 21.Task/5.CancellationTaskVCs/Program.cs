using System.Threading.Tasks;
using System;
using System.Threading;
using System.Collections.Generic;

namespace CancellationTaskVCs
{
	class Program 
	{
		private static int _accumulator1 = 0;
		private static int _accumulator2 = 0;

		static async Task Main(string[] args)
		{
			//^Cancellation Task
			//Cancelar una tarea en determinado momento

			//Debemos crear un token de cancelación, objeto para señalar o avisar que la tarea se cancele
			//^CancellationToken
			//Dentro del token el código que especifica porqué se debe cancelar
			//^CancellationTokenSource

			CancellationTokenSource myToken = new();

			CancellationToken stop = myToken.Token;

			Action<CancellationToken> ParallelTask = token => //para funciones de orden superior
			{
				Parallel.For(0, 100, i =>
				{
					_accumulator1++;

					int threadId = Thread.CurrentThread.ManagedThreadId;

					Thread.Sleep(1000 + i);

					Print($"Tarea: {i}. En thread {threadId}. Acumulador actual: {_accumulator1}");

					if (token.IsCancellationRequested) return;
				});
			};

			Action<CancellationToken> NormalTask = (token) =>
			{
				for (int i = 0; i < 100; i++)
				{
					_accumulator1++;

					int threadId = Thread.CurrentThread.ManagedThreadId;

					Thread.Sleep(1000 + i);

					Print($"Tarea: {i}. En thread {threadId}. Acumulador actual: {_accumulator1}");

					if (token.IsCancellationRequested) return;
				}
			};

			//cuando llegue a valer mas de 30, debe de detenerse el programma
			Task task = new(() => ParallelTask(stop));
			
			Task task2 = new(() => NormalTask(stop));

			/*Task task3 = Task.Run(() => Parallel.For(0, 60, i => 
			{
				_accumulator2++;

					int threadId = Thread.CurrentThread.ManagedThreadId;

				Thread.Sleep(1000 + i);

				Print($"Tarea: {i}. En thread {threadId}. Acumulador actual: {_accumulator2}");

				if (stop.IsCancellationRequested)
				{
					Print($"Task {Thread.CurrentThread.ManagedThreadId} cancelada");
					return;
				}
			})
			, stop); //stop is an variablo from CancellationToken
			*/
			task.Start();
			//task2.Start();
			
			for (int i = 0; i < 100; i++)
			{
				int threadId = Thread.CurrentThread.ManagedThreadId;
				
				_accumulator1 += 10; //se aumenta el valor del accumulator desde otra instrucción
				
				Thread.Sleep(400+i);

				Print($"i: {i} accumulator:{_accumulator1} desde el thread {threadId}. Desde el Main");

				if (_accumulator1 >= 50 || _accumulator2 >= 50)
				{
					myToken.Cancel();
					break;
				}
			}
			
			Thread.Sleep(1000);

			await task;
			//await task2;
			//await task3;

			Print($"Fin. Valor accumulator1: {_accumulator1}. Valor accumulator2: {_accumulator2}");
			
			Console.ReadLine();
		}
		static void Print(object obj) => Console.WriteLine(obj);
	}
}