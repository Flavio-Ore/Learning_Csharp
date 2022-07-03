using System;
using System.Threading;
using System.Collections.Generic;

//^Await Async

//Await para esperar la finalización de determinadas task


int threadId;

Action<string, int, int> ThreadLoop = (taskMessage, timeSleeping, repeatLoop) =>
{
  for (int i = 0; i < repeatLoop; i++)
  {
    threadId = Thread.CurrentThread.ManagedThreadId;

    Thread thread = new Thread(() => Console.WriteLine($"{taskMessage} THREAD: {threadId}"));

    Thread.Sleep(timeSleeping);

    thread.Start();
  }
};

void FirstTask() => ThreadLoop($"Tarea desde", 900, 10);

void SecretTask() => ThreadLoop($"tarea secreta", 300, 7);

async void DoTasks()
{
  List<Task> todo = new();

  todo.Add(Task.Run(FirstTask));

  todo.Add(Task.Run(() => ThreadLoop($"SEGUNDA tarea desde el", 500, 10)));

  Task.WaitAny(todo[0], todo[1]);

  todo.Add(Task.Run(() => ThreadLoop($"ultima Task. Tarea 4", 1800, 5)));

  Task.WaitAll(todo[0], todo[1], todo[2]);

  todo.Add(Task.Run(SecretTask));

  //!Espera las demás tareas, todas

  await Task.WhenAll(todo);

  Task bye = Task.Run(() => Console.WriteLine("TERMINARON TODAS LAS TASK"));
}

DoTasks();

Console.WriteLine("Pulse enter para salir...");

Console.ReadLine();