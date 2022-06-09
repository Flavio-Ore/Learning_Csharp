using System;
using System.Collections.Generic;

namespace LambdaExpresionIIICs
{
  class Program
  {
    //^Lambda Expresions (funciones anónimas)

    //^ Parámetros => expresión/bloque de sentencia
    //Ejecutan funciones que no necesitan ser nombradas.
    //Para simplificar el código
    //Se utilizan para crear delegados sencillos
    //En expresiones LINQ query etc
    //!Métodos como parámetros

    static void Main(string[] args)
    {
      //using delegate MathOperations

      //operation lambda: create instructions as parameter
      var operation = new MathOperations((num1, num2) => num1 * num2);

      Console.WriteLine(operation(999, 888));
    
      //------------------------------------------------------------------------
      //Complicando las cosas

      List<int> nums = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,13,14};

      //To find impair nums
      List<int> impairNums = nums.FindAll(x => x % 2 == 0);

      //To loop all items in nums
      impairNums.ForEach(number => Console.Write($"{number}, "));

      //primeNums---------------------------------------------------------------
      Console.WriteLine();
      
      List<int> primeNums = nums.FindAll(num =>
        {
          if (num < 2)
            return false;
          for (int i = 2; i < num; i++)
          {
            if((num % i) == 0)
              return false;
          }
          return true;
        }
      );

      primeNums.ForEach(primeNum => Console.Write($"{primeNum}, "));

      //------------------------------------------------------------------------
      //To compare the names and ages of Personas
      Persona p1 = new Persona();
      p1.Nombre = "Gon";
      p1.Age = 12;
      
        
    }

    public delegate int MathOperations(int num1, int num2); //Line 20
    static int ToSqr(int x, int y) => x*y; //x^2 | Line 20/22
  }
  class Persona
  {
    private int _int;
    private string _string;
    
    public string Nombre { get => _string; set => _string = value; }
    public int Age 
    {
      get => _int; 
      set
      {
        if (value < 0)
        {
          _int = 0;
        }
        else
        {
          _int = value;
        }
      }
    }
    
    
  }
}