using System;
using System.Threading;

namespace ThreadsLockJoinIIICs
{
  //4 personas van a querer sacar dinero de un banco de una misma cuenta.
  //Las personas van sacando dinero asíncronamente.
  //Miemtras alguno esté sacando dinero, otro no podrá sacar dinero porque la cuenta no tendría los fondos suficientes.
  //Por lo que debemos hacerlas síncronas o bloquearlas mientras hayan otros sacando dinero, controle la cantidad de salgo en la cuenta.
  class Program
  {
    static void Main(string[] args)
    {
      CuentaBancaria familia1 = new(4500);

      Thread[] personas = new Thread[10];

      for (int i = 0; i < personas.Length; i++) 
      {
        Thread thread = new Thread(familia1.DrawingBalance);
        thread.Name = i.ToString();
        personas[i] = thread;
      }

      for (int i = 0; i < personas.Length; i++)
      {
        personas[i].Start();
        //personas[i].Join();
      }

      Thread.Sleep(3000);

      CuentaBancaria familia2 = new(4000);
      Thread[] hilosPersonas = new Thread[10];
      for (int i = 0; i < hilosPersonas.Length; i++)
      {
        Thread thread2 = new Thread(familia2.DrawingBalance);
        thread2.Name = i.ToString();
        hilosPersonas[i] = thread2;
      }
      for (int i = 0; i < hilosPersonas.Length; i++)
      {
        hilosPersonas[i].Start();
        hilosPersonas[i].Join();
      }
    }
    static void Print(object _) => Console.WriteLine(_);
    
  }
}