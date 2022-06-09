using System;
using System.Collections.Generic;
namespace QueueIIICs
{
  class Program
  {
    //^ Queue Collection (colas)
    //^ F.I.F.O: first in, first out
    //cuando necesites un programa que de forma secuencial, vas agregando elementos y estos se van agregando uno detrás de otro en orden (se van apilando de izquierda a derecha)
    //se utilizan cuando crees un programa que maneje o tenga procesos de forma secuencias: utilizarás las colas
    //!Muchas veces el procesador dedica el 100% de su capacidad en realizar una tarea hasta que esté finalizada
    static void Main(string[] args)
    {
      var firstQueue = new Queue<double>();

    //adding elements in the queue
      foreach (double num in new double[4] {1,2,3,4})
        firstQueue.Enqueue(num);

    //looping the queue
      Console.WriteLine("Looping the queue");
      
      foreach (double queueElement in  firstQueue)
        Console.Write($"{queueElement} || ");

     //deleting elements in queue
      Console.WriteLine("\nDeleting elements");

      firstQueue.Dequeue(); //removing the first in

      foreach (double element in firstQueue)
        Console.Write($"{element} || ");
    
    //to array
      Console.WriteLine("\nTo array");
      
      var arrayQueue = firstQueue.ToArray();

      for (int i = 0; i < arrayQueue.Length; i++)
        Console.Write($"{arrayQueue[i]} || ");
      
      Console.WriteLine($"\n{arrayQueue}"); //double[]
    
    //Peek
      Console.WriteLine("Peek method");
      
      for (int i = 0; i < firstQueue.Count; i++)
        //print 2 2 2 cuz is the first element in the queue
        Console.Write(firstQueue.Peek()); 
    
    //Contains(T)
      Console.WriteLine($"\n{firstQueue.Contains(99)}"); //false
      Console.WriteLine(firstQueue.Contains(2));  //true
      Console.WriteLine(firstQueue.Contains(4));  //true
    }
  }
}