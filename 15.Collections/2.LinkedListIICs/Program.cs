using System;
using System.Collections.Generic;

//^LinkedList vs List

namespace LinkedListIICs
{
  class Program
  {
    //^List
    //List [dato,dato,dato,dato,dato, etc]
    //se van almacenando los elementos en posiciones que están juntas en la memoria del ordenador si eliminamos ese elemento en concreto, ese espacio queda vacio en la memoria
    //!Los datos debes de desplazarse constantemente para rellenar ese espacio por lo que el programa tendrá peor rendimiento

    //^LinkedList
    //Estas listas están formadas por nodos
    //Los nodos son lugares en la memoria donde se almacena la información, al igual que las listas
    //todos los nodos tienen polos, vértices, denominados enlaces (links)

    /*                   LinkedList  
      (link) Enlace --> ||  Dato ||  <-- Enlace (link)
                       \_____↓______/
                    Nodo (LinkedListNode<T>)
    */
    
    //!Si eliminados un dato, los enlaces (links) se actualizan automáticamente
    static void Main(string[] args)
    { 
      //Documentation: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-6.0
      //la documentación para ver los métodos disponibles, muy útil

      var palabrasClave = new LinkedList<string>();

      foreach (string str in new string[] {"Bar", "Baz", "Sim", "Som"})
        palabrasClave.AddFirst(str); //descending order

    //-------------------------------------------------------------------------

      //!Llamado a los elementos de la lista
      //foreach (string palabraClave in palabrasClave)
      //  Console.Write($"{palabraClave} | ");
      
      //!Llamado a los elementos de la lista
      for (LinkedListNode<string> node = palabrasClave.First; node != null; node = node.Next)
      {
        string palabra = node.Value;
        Console.WriteLine(palabra);
      }

    //---------------------------------------------------------------------

      Console.WriteLine();
      
      //para eliminar un elemento en concreto:
      palabrasClave.Remove("Bar");

    //--------------------------------------------------------------------      

      LinkedListNode<string> newNode = palabrasClave.AddLast("falseMain");

      palabrasClave.AddAfter(newNode, "main"); //adding after a created node
      
      palabrasClave.AddAfter(newNode, "trueMain"); //adding after a created node

      foreach (string word in palabrasClave)
      {
        Console.WriteLine(word); //increasing order
      }
      /*
      output:
      Som
      Sim
      Baz
      falseMain  <- created node
      trueMain   <- new node added after "falseMain"
      main       <- new node also added after "falseMain"
      */
    }
  }
}