using System;
using System.Threading;

//^Threads (hilos)
//^Sincronización y bloqueos

Thread t_new = new(Saludos);
Thread t_two = new(Saludos);

t_new.Start();

//!Se une al hilo principal y se ejecutará primero, luego la instrucción que siga
t_new.Join();

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