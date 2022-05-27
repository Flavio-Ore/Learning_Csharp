using System;

namespace Arrays_by_parameters
{
  class Program
  {
    static void Main()
    {
      //1
      int[] numbers = new int[4];
      numbers[0] = 1;
      numbers[1] = 2;
      numbers[2] = 3;
      numbers[3] = 4;

      ProcesoDatos(numbers); //suma a cada valor del array +10

      foreach (var i in numbers) //resultado luego de procesar esa suma
      {
        Console.WriteLine(i);
      }
 
    //-------------------------------------------------------------------      
    //2
      int[] arrayElementos = LeerData();   

      Console.WriteLine("imprimiendo el array:");      
      
      foreach (int elem in arrayElementos)
      {        
        Console.WriteLine(elem);
      } 

    //-------------------------------------------------------------------      

    }
    //?método que devuelve un array, al ejecutarlo, nos pregunte cuantos elementos queremos que tenga el array
    static int[] LeerData()
    {
      Console.WriteLine($"Ingrese la cantidad de elementos que desea en el array: ");
      //elementosUsu = cantidad de elementos en el array que está por crearse
      int elementosUsu = Int32.Parse(Console.ReadLine());

      //int[] userArray = new int[valor que ingrese el usuario] <- n° de elementos en el array
      int[] userArray = new int[elementosUsu];

      //elementosUsu sirve para repetir el loop for e ir agregando ints dentro del array userArray
      for (int i = 0; i < elementosUsu; i++)
      {
        Console.Write($"Introduce el numero para la posición {i}: ");

        int contenidoArray = Int32.Parse(Console.ReadLine());

        //userArray[0] = int que el usuario haya ingresado
        //userArray[1] = int que el usuario haya ingresado
        //userArray[2] = int que el usuario haya ingresado
        userArray[i] = contenidoArray;
      }

      return userArray; //userArray = new int [elemento1, elemento2, elemento3]
    }
    
    //método que recibe por parámetro un array
    static void ProcesoDatos(int[] data)
    {
      
      for (var i = 0; i < data.Length; i++)
      {
        data[i] +=10; //manipulando datos
      }

    }

  }
}