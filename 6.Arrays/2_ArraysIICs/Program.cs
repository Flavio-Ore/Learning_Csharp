using System;
namespace Arrays_Implicit_objects
{ //^ Implicitly, objects,  anonymous classes. Arrays
class Program
{
  static void Main(string[] args)
  {
 //!Implicitly Typed Arrays | Arrays implícitos
      //var datos = new[] {"Gon", "Lima", "Perú", 17}; //no sabe si debe asginar un tipo string o entero
    
    var valores = new[] {132, 1561, 15.321, 198.115}; //array de tipo double


 //! ARRAYS DE OBJETOS | creamos una clase Staff 2 formas de hacer lo mismo:
 //? Si creas un array "Object" podes meter datos de todo tipo, int, String, Persona, Coche, Boolean
    Staff[] arrayStaff = new Staff[2]; //almacena 2 elementos

    //creamos el objeto de tipo Stuff mientras lo almacenamos dentro del array
    arrayStaff[0] = new Staff("Steven", 25); //instanciamos una clase Staff

    Staff gon = new Staff("Gonzalo", 22);
    //almacenamos un objeto creado previamente: 
    arrayStaff[1] = gon; //!puede ser usado previamente para optimizar el código


//! ARRAY de tipos o clases anónimas 
    var personas = new[] //array de tipos anónimos
    { //todos deben ser del mismo tipo
      new {Nombre = "Gon", Edad = 16}, //objeto en la posicion 0
      new {Nombre = "Stuart", Edad = 18}, //objeto en la posicion 1
      new {Nombre = "Jose", Edad = 95}, //objeto en la posicion 2
    };
    Console.WriteLine(personas[0]);
    
//! ARRAY de más dimensiones:
    //2 dimensiones
    int[,] masEdades = new int[4,2]; //dimension de 4 filas y 2 columnas
    masEdades[0, 0] = 17; //asignar valor a la posicion 0,0
    Console.WriteLine(masEdades[0,0]);
    
  }
}

class Staff
{
  public Staff(String nombre, int edad)
  {
    this.nombre = nombre;
    this.edad = edad;
  }
  String nombre;
  int edad;
}


}