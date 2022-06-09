using System;
using System.Collections.Generic;

namespace StacksIVCs
{
  class Program
  {
    //^ Stack Collection (pilas)
    //^ L.I.F.O: last in, first out
    //Los elemento en pila pueden entrar en un orden determinado
    static void Main(string[] args)
    {
      var stack = new Stack<int>();

      //adding items in the int stack
      for (int i = 0; i <= 6; i++)
      {stack.Push(i);} //last in: 6

      //looking at items in the stack
      Console.WriteLine($"Looking items in the stack. Number of elements: {stack.Count}");

      foreach (int i in stack)
      {Console.Write($"{i}, ");}
      
      //Creating an array of items to store a copy of the stack
      Console.WriteLine("\nNew array:");

      var stackArray = new int[stack.Count];

      for (int i = 0; i > stack.Count; i++)
      {stackArray[i] = i++;}

      foreach (int item in stackArray)
      {Console.Write($"{item}, ");}
      
      //CopyTo method
      Console.WriteLine("\nCopying the elements of the stack into new stackArray:");

      stack.CopyTo(stackArray, 0);

      foreach (int item in stackArray)
        Console.Write($"{item}, ");
      
      //Pop method
      Console.WriteLine("Deleting the last in element of the stack");

      stack.Pop();

      foreach (int i in stack)
      {Console.Write($"{i}, ");}
      
      //Clear method
      Console.WriteLine("Clearing the stack");

      stack.Clear();

      Console.WriteLine($"stack.Count() = {stack.Count}");

    }
  }
}