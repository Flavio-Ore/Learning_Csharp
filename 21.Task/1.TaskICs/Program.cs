using System;
using System.Threading;

//^Task (asynchronously)
//Determinados threads son asignadas a diferentes tareas en un procesador.
//Si hay 5 threads ejecutandose en un procesador de 8 núcleos, entonces no estamos aprovechando del todo ese procesador
//Caso contrario, el procesador tiene 4 núcleos con 8 threads  ejecutándose, el procesador se sobrecargará
//!No todas las máquinas serán las mismas, la escalabilidad sería diferente en cada una

//^¿Qué son task?
//Están a un nivel por encima de los Threads, se encargan de gestionar los threads (porque internamente trabaja con un pool de threads) para optimizar el uso del procesador dependiendo de la máquina en la que se ejecuta 

//Programación asíncrona (async)
//!Una Task es algo futuro o una promesa, las T ask mejor que los Threads
//El task es la promesa de que se va a realizar sea como sea esa tarea futura
//Un thread es la herramienta para conseguir realizar esa promesa
object toLock = new();

Action DoTask = () =>
{ //Como función
  for (int i = 0; i < 8; i++)
  {
    int newThread = Thread.CurrentThread.ManagedThreadId;
    Thread.Sleep(900);
    Console.WriteLine($"Vuelta por el Thread: {newThread}");
  }
};

//Exactamente igual que un pool de Threads

Task task = new(DoTask);

Task newTask = new(() =>
  { //Como función anónima
    for (int i = 0; i < 5; i++)
    {
      int thread = Thread.CurrentThread.ManagedThreadId;
      Thread.Sleep(900);
      Console.WriteLine($"HOLA el thread {thread} en Main()");
    }
  });

void StartTasks()
{
  task.Start();
  newTask.Start();
}

Console.Write("Realizar los Task? (si | no): ");

string? userAnswer = Console.ReadLine();

switch (userAnswer)
{
  case "si":
    StartTasks();
    Console.WriteLine("Mostrando en consola...");
    break;
  case "no":
    Console.WriteLine("No pasó nada...");
    break;
  default:
    Console.WriteLine("Entrada inválida");
    break;
}

//Al finalizar estas task, reanudar las siguientes líneas de código
await task;
await newTask;

Console.WriteLine("pulse enter para finalizar");

Console.ReadLine();