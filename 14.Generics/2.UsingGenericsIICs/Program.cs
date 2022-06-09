using System;
namespace GenericsICs
{
  class Program
  {
  //^¿Por qué usar Generics en lugar de clases?
  //!||||||||||Comprobación de errores en tiempo de compilación|||||||||||||||||
  //Mayor sencillez de código
  //Reutlización de código en numerosos escenarios
  //Uso continuo del casting. (parse)
  //Complicación del código
  //No posibilidad de comprobación de errores

    static void Main(string[] args)
    {
    //^De Objetos --> Strings
     //Usando clases en lugar de generics
     //especificamos el tipo genérico que será
     AlmacenObjetos<string> archivos = new AlmacenObjetos<string>(3);

     archivos.Agregar("elemento one");
     archivos.Agregar("elemento two"); // <--calling
     archivos.Agregar("elemento three");

    string nombreElemento = archivos.GetElementIndex(1); //ahora podemos prescindir del casting
     Console.WriteLine(archivos.GetElementIndex(1)); //devuelve un object, pero queremos un string
     

     //^De objetos --> Empleados
      //Las complicaciones de usar clases:
      //requiere casting constante de los objetos
      AlmacenObjetos<Empleado> archivoEmpleados = 
        new AlmacenObjetos<Empleado>(4);

      archivoEmpleados.Agregar(new Empleado(2100));
      archivoEmpleados.Agregar(new Empleado(1220));
      archivoEmpleados.Agregar(new Empleado(4121)); // <---calling
      archivoEmpleados.Agregar(new Empleado(1990));

      //string salarioEmpleado = (string)archivoEmpleados.GetElementIndex(3); //!Err System.InvalidCastException

      Empleado salarioTercerEmpleado = archivoEmpleados.GetElementIndex(2); //no prescindo del casting

      Console.WriteLine(salarioTercerEmpleado.Salario);
      
    }

  }
  //^Creando clase genérica por convención <T>
  //Creando una clase que sea capaz de almacenar en un array de objetos de diferente tipo para luego utilizar esta clase para almacenar objetos de cualquier tipo Class AlmacenObjetos, Class Empleado
  class AlmacenObjetos <T>
  {
    //fields
    private T[] _datosElemento;
    private int _i = 0;
    
    //constructor
    public AlmacenObjetos(int z)
    {
      _datosElemento = new T[z];
    }

    //methods
    public void Agregar(T obj)
    {
      _datosElemento[_i] = obj;
      _i++; //aumenta en 1 cada que llamamos el método
    }
    public T GetElementIndex(int i) => _datosElemento[i];
  }

//-----------------------------------------------------------------------------

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


}