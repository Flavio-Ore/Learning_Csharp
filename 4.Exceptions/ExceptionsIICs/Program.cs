using System; //directiva
namespace program
{
class Program
{
  static void Main(string[] args)
  {
//------------------------------------------------------------------------

/* See https://aka.ms/new-console-template for more information

  int numero = int.MaxValue; //? EL MÁXIMO VALOR QUE ADMITE EL TIPO PRIMITIVO INT

  int intOverflowError = numero + 20; //? DEBERIA HABER UN DESBORDAMIENTO

  Console.WriteLine(intOverflowError); //! output : -2147483629 error de desbordamiento
  /*
  ! El error
  El programa se debería caer al realizar esa tarea, además de devolver un número negativo. La explicación de este comportamiento es el rendimiento.
  ! Lo que hace el compilador de C#
  El COMPILADOR intenta que los programas tengan el máximo redimiento en C#, de tal forma que permiten transparentemente para el usuario hacer un overflow y generar una respuesta errónea.
  ! Lo que hace el compilador tras bambalinas
  El COMPILADOR sabe que hay un desbordamiento pero anes de dejar que caiga el programa lo que hace es que de forma transparente trata la excepción y devuelve una respuesta errónea porque no sabe muy bien qué hacer.
  ! El porqué lo hace
  o realiza por rendimimento, porque en programa aritmético complejo tiene que ver si hay un desbordamiento o no en cada una de las operaciones aritméticas, esto ocasionaria un rendimento muy pobre por parte del compilador, de tal forma que lo que hace es asumir que puede haber un posible error y continuar con la ejecución del programa hacia adelante

*/

  //^ para hacer una exception ponemos checked para que tome en cuenta ese error y lo muestre, en visual studio se puede activar manualmente y realizar ese cheked siempre implícitamente

//------------------------------------------------------------------------

/* //~ Checked

  checked { //todo activo checked solo con primitos INT & LONG

    try 
    { //! al NO estar checked activo, el try funciona y ejecuta el desbordamiento

      int numero = int.MaxValue; //? EL MÁXIMO VALOR QUE ADMITE EL TIPO PRIMITIVO INT

      int intOverflowError = numero + 20; //? DEBERIA HABER UN DESBORDAMIENTO

      Console.WriteLine(intOverflowError); //! output : -2147483629 (error de desbordamiento)

    } 
    catch (OverflowException ex)
    { //! si está activo, se produce el error de desbordamiento y es capturado en CATCH

        Console.WriteLine("Error en la operación");

    }
    
  }
*/

//------------------------------------------------------------------------

  //~ forzar una exception | lanzamiento de excepciones
  //! NombreDelMes()
    Console.WriteLine("Introduce el número del mes");
/*
    int NumeroMes = int.Parse(Console.ReadLine());

    try
    {

      Console.WriteLine(NombreDelMes(NumeroMes));

      Console.WriteLine("Aquí continuaría la ejecución del resto del programa");

    } 
    catch (Exception ex)
    {
      
      Console.WriteLine("Mensaje de la excepción: " + ex.Message);
      
    }
*/

  Console.WriteLine("");

//------------------------------------------------------------------------

  }//END OF MAIN CLASS||||||||||||||||||||||||||||||||||||||||||||||||||||||||

//----------------------------------------------------------------------

  //~ CREANDO UNA EXCEPTION EN NUESTRO MÉTODO
  public static string NombreDelMes(int mes)
  { //? que sucede si el usuario introduce numeros fuera del rango
    // cuando se introduzca un valor fuera del rango del 1 al 12, lanzará una excepción del tipo ArgumentOutOfRangeException : Excepción que se produce cuando el valor de un argumento está fuera del intervalo de valores permitido definido por el método invocado.
    // https://docs.microsoft.com/es-es/dotnet/api/system.argumentoutofrangeexception?view=net-6.0
    switch (mes) 
    {
      case 1:
        return "Enero";

      case 2:
        return "Febrero";

      case 3:
        return "Marzo";

      case 4:
        return "Abril";

      case 5:
        return "Mayo";

      case 6:
        return "Junio";

      case 7:
        return "Julio";

      case 8:
        return "Agosto";

      case 9:
        return "Septiembre";

      case 10:
        return "Octubre";

      case 11:
        return "Noviembre";

      case 12:
        return "Diciembre";

      default:
        throw new ArgumentOutOfRangeException(); //llama y lanza una excepción para que se vean obligados a utilizar un bloque try catch para capturar la excepción que manda este método
    } 

  }



}

}