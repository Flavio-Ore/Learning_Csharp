using System;
using System.Collections.Generic; //^To make Generics Collections

namespace CollectionsICs
{
  class Program
  {
    static void Main(string[] args)
    {
    //^Colecciones genéricas (nodos)
    //Las colecciones permiten agregar elementos en tiempo de ejecución

    //--------------------------------------------------------------------------
      //Colección genérica
      List<int> numeros = new List<int>();

      numeros.Add(1);
      numeros.Add(2);
      numeros.Add(3);

      for (int i = 0; i < 3; i++)
        Console.WriteLine(numeros[i]);

    //--------------------------------------------------------------------------
      Console.WriteLine();
      
      List<int> numeros2 = new List<int>();

      int[] arrayNums = new int[] {1,2,3,4,5}; //elementos fijos

      for (int i = 0; i < 5; i++)
        numeros2.Add(arrayNums[i]);

      for (int i = 0; i < 5; i++)
        Console.WriteLine(numeros2[i]);

    //--------------------------------------------------------------------------
      Console.WriteLine();

    //Las colecciones permiten agregar elementos en tiempo de ejecución
      List<int> numerosUsu = new List<int>();
      Console.Write("Introduzca la cantidad de elementos: ");

      int elemUsu = int.Parse(Console.ReadLine());

      for (int i = 0; i < elemUsu; i++)
      {
        Console.Write($"Elemento para la posición {i}: ");        
        numerosUsu.Add(int.Parse(Console.ReadLine()));
      }
      Console.Write("Imprimiento elementos de la lista creada: ");
      
      for (int i = 0; i < numerosUsu.Count; i++)
      {
        Console.Write($"{numerosUsu[i]}, ");
      }

    //--------------------------------------------------------------------------

    //!Lo hecho anteriormente se puede hace también SOLO con arrays:
      Console.WriteLine();

      Console.WriteLine("How many attended today: ");

    //se pide la variable c que es la cantidad de usuarios
			int numOfStudents = int.Parse(Console.ReadLine());
      
    //se hace un array con esa cantidad de usuarios
			string[] students = new string[numOfStudents];

    //se repite tantas veces como elementos hay, para eso se utiliza la variable anterior utilizada que es numOfStudents
			for (int i = 0; i < numOfStudents; i++)
			{
				Console.Write("Name of student: ");

      //se piden los nombres del estudiante y se guarda en el array
				students[i] = Console.ReadLine();
			}

    //se recorre el array y se muestran los strings del array en pantalla
			Console.Write("Attended to school today: ");
			for (int i = 0; i < numOfStudents; i++)
				Console.Write($"{students[i]}, ");

    //--------------------------------------------------------------------------
      Console.WriteLine();

      List<int> numbers = new List<int>();

      Console.WriteLine("Introducir elementos en la colección (0 terminar)");

      int elem = 1;

      while (elem != 0)
      {
        elem = int.Parse(Console.ReadLine());
        numbers.Add(elem);
      }

      numbers.Remove(numeros.Count - 1);

      Console.WriteLine("Elementos introducidos: ");
      
      foreach (int integers in numbers)
        Console.Write($"{integers}, ");
      
    }

  }
  
}