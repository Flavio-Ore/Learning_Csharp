using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
namespace Func_ActionIVCs
{
  partial class Program
  {
    //^No tenemos que crear métodos delegados constantemente, la clase Func y Action ya lo hacen
    //Mandar funciones como parámetros

    //^Func return
    //El último parámetro es lo que regrese la func e.g. Func<string, int> (return int)

    //^Action void

    static void Main(string[] args)
    {

      //The last arg will return that datatype
      Func<string, string> textFormat = IntStringText;
/*
      Console.WriteLine("Enter text to see what happens next...");
      
      FuncText(textFormat);
*/
      Console.WriteLine("----------------------------------------------------");

      LinkedList<int> xNumbers = new LinkedList<int>();

      Console.WriteLine("Ingrese cantidad de elementos para la lista (solo números): ");

      int userElements;

      try
      {
        userElements = int.Parse(Console.ReadLine());    
      }
      catch (Exception)
      {
        Console.WriteLine("Error, no ingresó un número, número aceptado: 0");
        userElements = 0;
      }

      for (int i = 0; i < userElements; i++)
        xNumbers.AddFirst(i);

      Console.WriteLine($"Se creó la lista enlazada de {xNumbers.Count} elementos.\nLos siguientes elementos son: ");

      ShowCollection(xNumbers);

      //encapsulating the method
      //List as arg and return and List.

      //Func<LinkedList<int>, LinkedListNode<int>> toList = SumXtoXNum;

      Sort(xNumbers);

      Console.WriteLine();
      
      ShowCollection(xNumbers);
      
      Console.WriteLine();

      Func<string> firstAction = Del;

      Do(firstAction);
            
      //arg1: encapsuladed method | arg2: the List<int>
      //SumEachIntList(toList, xNumbers);
    }

  }

}