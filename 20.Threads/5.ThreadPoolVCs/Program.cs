using System;
using System.Threading;

void TheTask(object infoTask)
{
  int numTask = (int)infoTask;

  Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Thread ha comenzado la tarea n° {numTask}");

  Thread.Sleep(1000);

  Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Thread TERMINÓ la tarea n° {numTask}");
}

for (int i = 0; i < 50; i++)
{
  //Thread por Thread | gasto masivo de recursos
  //Thread doing = new(theTask);
  //doing.Start();

  //reducido
  ThreadPool.SetMaxThreads(1,2);
  ThreadPool.QueueUserWorkItem(TheTask, i);
}

Console.ReadLine(); //para poder observar todas las task en consola