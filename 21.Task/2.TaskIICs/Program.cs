using System;
using System.Threading;

//^Task consecutivas
//La siguiente task solo podrá comenzar su ejecución cuando determinada task previa termine

//!parámetro para poder usar ContinueWith(methodFinished), es un parámetro que avisa que aquella tarea ha finalizado
Action<Task> anAction = (methodFinished) =>
{
  for (int i = 0; i < 11; i++)
  {
    int threadId = Thread.CurrentThread.ManagedThreadId;

    Console.WriteLine($"Hola, thread {threadId} PRINCIPAL ejecutando la tarea {i}");

    Thread.Sleep(900);

    Console.WriteLine($"tarea {i} FINALIZADA, thread {threadId}");
  }
};

/*
Task.Run(=>) simplifica el siguiente código:
  Task newTask = new(Function);
  newTask.Start();
*/

Task firstTask = Task.Run(() =>
{
  for (int i = 0; i < 11; i++)
  {
    int threadId = Thread.CurrentThread.ManagedThreadId;
 
    Console.WriteLine($"Hola, thread chico {threadId} ejecutando la tarea {i}");
 
    Thread.Sleep(900);

    Console.WriteLine($"tarea {i} terminada, thread {threadId}");
  }
});

Task secondTask = firstTask.ContinueWith(anAction);

Console.ReadLine();