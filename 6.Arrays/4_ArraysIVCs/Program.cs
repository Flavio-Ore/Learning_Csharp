using System;
namespace ForEachLoop_arrays
{ //^ ForEachLoop | microsoft documentation
class Program
{
  static void Main()
  { 
    var valores = new[] {132, 1561, 15.321, 198.115}; //array de tipo double
    
    // i = cantidad de índice del array
    for (int i = 0; i < valores.Length; i++) 
    { //Length property hace más flexible el for loop
      Console.WriteLine(valores[i]);
    }

    Console.WriteLine("||");

    foreach (double numbers in valores)
    { //numbers = variable para mostrar la variables en el array valores
      Console.WriteLine(numbers); 
    }

    Console.WriteLine("--------------------------------------------------");

    Staff[] arrayStaff = new Staff[3]; //almacena 2 elementos

    arrayStaff[0] = new Staff(25, "Steven"); //instanciamos una clase Staff

    Staff gon = new Staff(22, "Gonzalo");
    arrayStaff[1] = gon; //!puede ser usado previamente para optimizar el código

    arrayStaff[2] = new Staff(11,"Stuart");

    for (int i = 0; i < arrayStaff.Length; i++)
    {
     Console.WriteLine(arrayStaff[i].NombreEdad);
    }

    Console.WriteLine("||");

    foreach (Staff item in arrayStaff)
    {
      Console.WriteLine(item.NombreEdad);  
    }

    Console.WriteLine("-----------------------------------------------");
    //! FOREACH muy práctico para recorrer arrays implícitos o anónimos
    //? no se sabe primera posición, ni la última, ni el nombre del array, nada

    var personas = new[] //array de tipos anónimos
    { //todos deben ser del mismo tipo
      new {Edad = 16, Nombre = "Gon"}, //objeto en la posicion 0
      new {Edad = 18, Nombre = "Stuart"}, //objeto en la posicion 1
      new {Edad = 95, Nombre = "Jose"}, //objeto en la posicion 2
      new {Edad = 11, Nombre = "Eduardo"}
    };    

    //PIERDE FLEXIBLILIDAD | solo sirve para recorrer y acceder a la información de todos los datos del array, SI SE QUIERE MODIFICAR LOS DATOS DEL ARRAY, NO SIRVE

    foreach (var item in personas)
    {
      Console.WriteLine(item);
    }

  }
class Staff
{
  public Staff(int edad, string nombre)
  {
    this.edad = edad;
    this.nombre = nombre;
  }
  public string NombreEdad 
  {
    get => $"edad: {this.edad}, Nombre: {this.nombre}";
  }

  private string nombre;
  private int edad;
}
  static void Recapitulando()
  {
    int[] masEdades; //inicialización
    masEdades = new int[2]; //declaración
    masEdades[0] = 1; //posicionamieto
    masEdades[1] = 2; //posicionamiento

    int[] otrasEdades = new int[2]; //iniciación y declaración
    otrasEdades[0] = 1;
    otrasEdades[1] = 2;
    
    int[] aunHayEdades = new int[] {1,2,3,4}; //array fijo

    var estoSonEdades = new[] {1,2,3,4}; //array implícito

  }

}

}