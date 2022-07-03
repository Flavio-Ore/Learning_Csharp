using System;
using System.Threading;

//^Threads (hilos)
//^Programación Concurrente

//?Aplicaciones monotareas 
//Se realizan una detrás de otras, no realiza otra hasta terminar la que comenzó. El ordenador utiliza todos los recursos y se centra en esa única tarea

//?Aplicaciones multitareas  
//Las realiza tal cual, pero se centra en un único hilo, por lo que el rendimiento de los demás threads no será el mismo (aunque casi que no se nota)

//?Ralentizar los threads
//Pausar el hilo de ejecución
//Sleep (milisegundos)

//!El boton de la izquierda sirve a la hora de depurar/debugear pausar,etc

//!Hacer las 2 tareas en forma simultánea

Thread t_new = new(Saludos);
Thread t_two = new(Saludos);

t_new.Start();

OneSecondPrint("Saludos desde el hilo 1 jajas");

Thread.Sleep(500);

OneSecondPrint("Saludos desde el hilo 1 jajas");

t_two.Start();

OneSecondPrint("Saludos desde el hilo 1 jajas");

//---------------------------------------------------------------------------------------------

void OneSecondPrint(object _)
{
  Thread.Sleep(1000);
  Console.WriteLine(_);
}

void Saludos()
{
  Console.WriteLine("Saludos desde el hilo 2 jajas");

  Thread.Sleep(500);

  Console.WriteLine("Saludos desde el hilo 2 jajas");

  Thread.Sleep(750);

  Console.WriteLine("Saludos desde el hilo 2 jajas");
}