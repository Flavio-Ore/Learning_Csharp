using System.Runtime.ExceptionServices;
using System;
using System.Threading;

//^TaskCompletionSource<generic>
//Cuando manejas sockets, conexiones a BBDD
//!Vias de comunicaciones con datos externos

//Saber si una tarea se ha completado en su totalidad, una condición. Determinado thread comenzará su tarea para que el siguiente haga lo que se le determine

TaskCompletionSource<bool> taskDone = new();

Thread firstThread = new(() =>
{
  for (int i = 0; i < 4; i++)
  {
    Console.WriteLine("Hilo 1");
    Thread.Sleep(900);
  }

  taskDone.TrySetResult(true);

});

Thread secondThread = new(() =>
{
  for (int i = 0; i < 4; i++)
  {
    Console.WriteLine("Hilo 2");
    Thread.Sleep(900);
  }    
});

Thread thirdThread = new(() =>
{
  for (int i = 0; i < 4; i++)
  {
    Console.WriteLine("Hilo 3");
    Thread.Sleep(900);
  }    

});

Thread fourthThread = new(() =>
{
  for (int i = 0; i < 4; i++)
  {
    Console.WriteLine("Hilo 4");
    Thread.Sleep(900);
  }    

  taskDone.TrySetResult(true);

});

firstThread.Start();

fourthThread.Start();

fourthThread.Join();

secondThread.Start();

bool result = taskDone.Task.Result;

//se ejecutará cuando las task de determinado thread terminen
thirdThread.Start();

