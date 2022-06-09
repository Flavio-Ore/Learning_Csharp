using System;
namespace GenericsICs
{
  class Program
  {
  //^Programación Genérica
  //consiste en crear clases "comodín" que van a permitir manejar cualquier tipo de objetos.
  //puedo crear una única clase que ea capaz de manejar cualquier tipo de objeto

  //EjemploClase <string> archivos = new EjemploClase <string>();
  //---------------------parámetro de tipo------------------
  //EjemploClase <File> archivos = new EjemploClase <File> ();

  //^Generics
  //Mayor sencillez de código
  //Reutlización de código en numerosos escenarios
  //!||||||||||Comprobación de errores en tiempo de compilación|||||||||||||||||

  //^¿Por qué usar Generics en lugar de clases?
  //Uso continuo del casting. (parse)
  //Complicación del código
  //No posibilidad de comprobación de errores

    static void Main(string[] args)
    {
    //^Objetos
     //Usando clases en lugar de generics
     AlmacenObjetos archivos = new AlmacenObjetos(3);

     archivos.Agregar("elemento one");
     archivos.Agregar("elemento two"); //ver
     archivos.Agregar("elemento three");

    string nombreElemento = (string)archivos.GetElementIndex(1); //no devuelve un string, devuelve un object, queremos string

     Console.WriteLine(archivos.GetElementIndex(1)); //devulve un object, pero queremos un string

     //^Empleados
      //Las complicaciones de usar clases:
      //requiere casting constante de los objetos
      AlmacenObjetos archivoEmpleados = new AlmacenObjetos(4);

      archivoEmpleados.Agregar(new Empleado(2100));
      archivoEmpleados.Agregar(new Empleado(1220));
      archivoEmpleados.Agregar(new Empleado(4121)); // <---calling
      archivoEmpleados.Agregar(new Empleado(1990));

      //string salarioEmpleado = (string)archivoEmpleados.GetElementIndex(3); //!Err System.InvalidCastException

      Empleado salarioEmpleado = (Empleado)archivoEmpleados.GetElementIndex(2);

      Console.WriteLine(salarioEmpleado.Salario);
      
    }

  }

  //Creando una clase que sea capaz de almacenar en un array de objetos de diferente tipo para luego utilizar esta clase para almacenar objetos de cualquier tipo Class AlmacenObjetos, Class Empleado
  class Empleado
  {
    //fields 
    private double _salario;

    //constructor
    public Empleado(double salario) => _salario = salario;

    //getter setter
    public double Salario
    {get => _salario;}
  }

  class AlmacenObjetos
  {
    //fields
    private object[] _datosElemento;
    private int _i = 0;
    
    //constructor
    public AlmacenObjetos(int z)
    {
      _datosElemento = new object[z];
    }

    //methods
    public void Agregar(object obj)
    {
      _datosElemento[_i] = obj;
      _i++; //aumenta en 1 cada que llamamos el método
    }
    public object GetElementIndex(int i) => _datosElemento[i];
  }

}