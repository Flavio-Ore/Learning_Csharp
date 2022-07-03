using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Func_ActionIVCs
{
  partial class Program
  {/*
    static LinkedList<int> SumEachIntList(
      Func<LinkedList<int>, LinkedListNode<int>> aFunc, 
      LinkedList<int> list)
    {
      for (int i = 0; i < list.Count; i++)
      {
        list.AddFirst(aFunc);
      }

      return list;
    }
    */
    static string Del() => "Holaaa,a,a,a,";

    static void Do(Func<string> action) => Console.WriteLine(action());
    
//------------------------------------------------------------------------------
    //final test function
    static LinkedList<int> Sort(LinkedList<int> list)
    {
      LinkedListNode<int> tempNode;

      for
      (tempNode = list.First.Next; tempNode != null; tempNode = tempNode.Next)
      {
        LinkedListNode<int> sortedListBoundary = tempNode.Previous;
        
        list.Remove(tempNode);

        while ((sortedListBoundary != null) && 
        (tempNode.Value < sortedListBoundary.Value))
        {
          sortedListBoundary = sortedListBoundary.Previous;
        }

        if(sortedListBoundary == null)
          list.AddFirst(tempNode);

        else
          list.AddAfter(sortedListBoundary, tempNode); 
      }
      return list;
    }
/*    static void SumXtoXNum(LinkedList<int> x)
    {
      LinkedList<int> resultList = new LinkedList<int>();

      LinkedListNode<int> node;

      for (int i = 0; i < x.Count; i++)
      {
        for (node = x.First.Next; node != null;(node = node.Next) && (x.Previous != null))
        {
          for (int a = 0; a < node.Value; a++)
          {
            node.Value += i;
          }
        }
        resultList.AddFirst(node);
      }
    }
*/
    //to show the array
    static void ShowCollection(LinkedList<int> aList)
    {
        foreach (int item in aList)
            Console.WriteLine(item); 
    }

  //--------------------------------------------------------------------------

    //first
    static string IntStringText(string text) => $"{text.ToUpper()}. Number of characters: {text.Count()}";

    //second
    static void FuncText(Func<string, string> firstFunc) => Console.WriteLine("This text has the following characteristics: " + firstFunc(Console.ReadLine()));
  }


}