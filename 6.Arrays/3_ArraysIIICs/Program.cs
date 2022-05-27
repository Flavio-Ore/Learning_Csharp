using System;
namespace bucleFor_Arrays
{ //^ Bucle for arrays
class Program
{
  static void Main(string[] args)
  {
    //Un buble for repite el código de su interior un número determinado de veces
    //iniciación del buble (int i=0) | condición del bucle (i <= 8) | incremento o decremento de la variable (i++)
    //for (int i = 0; i <= 8; i++) { //código interior del bucle for }

    var valores = new[] {132, 1561, 15.321, 198.115}; //array de tipo double

    Staff[] arrayStaff = new Staff[2]; //almacena 2 elementos

    arrayStaff[0] = new Staff("Steven", 25); //instanciamos una clase Staff

    Staff gon = new Staff("Gonzalo", 22);
    arrayStaff[1] = gon; //!puede ser usado previamente para optimizar el código

    var personas = new[] //array de tipos anónimos
    { //todos deben ser del mismo tipo
      new {Nombre = "Gon", Edad = 16}, //objeto en la posicion 0
      new {Nombre = "Stuart", Edad = 18}, //objeto en la posicion 1
      new {Nombre = "Jose", Edad = 95}, //objeto en la posicion 2
    };
    
//-----------------------------------------------------------------------------
    // i = cantidad de índice del array
    for (int i = 0; i < valores.Length; i++)
    {
      Console.WriteLine(valores[i]);
    }


    int[] edades = {1,2,3,4,5,6,7,8,9,10,11,12,13};

    for (int i = 0; i < edades.Length; i++)
    {
      Console.WriteLine($"Secuencia de números naturales: {edades[i]}");
    }

  }

}
class Staff
{
  public Staff(string nombre, int edad)
  {
    this.nombre = nombre;
    this.edad = edad;
  }
  string nombre;
  int edad;
}

}