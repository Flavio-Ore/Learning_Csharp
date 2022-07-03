using System;
using System.Threading;

namespace ParallelTask
{
	class Program
	{
		//^Parallel Class
		//Sirve para ahorrar recursos
		//Reemplaza bucles for foreach por sus métodos
		//!Parallel Class para la concurrencia
		private static int _accumulator = 0;
		static void Main(string[] args)
		{
			//Un método
			Action<int> DoTask = (data) =>
			{
				//operador ternario
				_accumulator = (_accumulator % 2) == 0 ? _accumulator += data : _accumulator -= data;

				Console.WriteLine($"Acumulador vale {_accumulator}. Thread: {Thread.CurrentThread.ManagedThreadId}");

				Thread.Sleep(100);
			};

			//DoTask() se debe ejecutar de forma paralela, concurrente
			//integer vale 0; hasta que valga 20; ejecuta el método
			Parallel.For(0, 20, DoTask);

			Parallel.For(0, 10, data =>
			{
				_accumulator = (_accumulator % 2) != 0 ? _accumulator += data : _accumulator -= data;

				Console.WriteLine($"{_accumulator}. HILO: {Thread.CurrentThread.ManagedThreadId}");

				Thread.Sleep(500);
			});
		}
	}
}