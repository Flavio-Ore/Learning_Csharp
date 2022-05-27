//^IMPORTAR MÉTODOS STATIC SON MALAS PRÁCTICAS
using static System.Console;
using static System.Math;
//^LAS CLASES ANÓNIMAS EN GENERAL SIRVEN PARA AHORRAR LINEAS DE CÓDIGO, EN C# SE UTILIZAN PARA LAS EXPRESIONES QUERY, CONSULTAS, SQL
namespace Anonymous_classes
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteLine("Clases anónimas:");
      POOIX(); //clases anónimas
      //? RESTRICCIONES AL USAR CLAES ANÓNIMAS
      //! Solo pueden contener campos públicos
      //! Todos los campos deben estar iniciados
      //! Los campos no pueden ser static
      //! N se pueden definir métodos
    }
    static void POOIX()
    {
      //!instancia de variable anónima:
      //con var el err desaparece
      var variableAnonima = new {Nombre = "Juan", Edad = 19}; 
      WriteLine(variableAnonima);

      WriteLine(variableAnonima.Nombre + " " + variableAnonima.Edad);

      var otraVariableAnonima = new {Nombre = "Ana", Edad = 25};

      variableAnonima = otraVariableAnonima; //tienen los mismos parámetros
      WriteLine(variableAnonima);
      WriteLine(otraVariableAnonima);
    }
    static void ImportacionesAPI()
    {
//! NO SE RECOMIENDA IMPORTAR LOS MÉTODOS STATICS using static System. ;
      WriteLine("Este texto se ejecutó sin llamar a la clase Console porque importé estos métodos static desde la directiva, paquete de .net, lo que ahorra a su vez, código a escribir");
      WriteLine($"Operaciones habiendo importanto métodos staticos: raiz de 25 = {Sqrt(25)}");
    }

  }



}
