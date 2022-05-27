using System;
//* CREACIÓN DE CLASES
namespace PooCreandoClases
{
  class Program
  {
    static void Main(string[] args)
    {

      Circulo miCirculo; //creación de objeto de tipo Círculo. Variable/objeto de tipo círculo

      miCirculo = new Circulo(); //Iniciacion de variable/objeto de tipo Círculo. Instancias una clase
      //? La palabra reservada new es una instancia. Instanciación. Ejemplarización. Creación de ejemplar de clase.

      miCirculo.CalculoArea(5); //!NO DEJA LLAMAR NI USAR LAS PROPIEDADES POR EL NIVEL DE PROTECCIÓN (ahora es public)

      Console.WriteLine(miCirculo.CalculoArea(10));

      Circulo miCirculoDos = new Circulo();

      Console.WriteLine(miCirculoDos.CalculoArea(9));

    }

  }

//una clase capaz de crear circulos, tamaño, area
  class Circulo //esta clase puede estar antes o despues de la clase Program
  {
    const double PI = 3.14159; //propiedad de la clase Circulo. Campos de clase
    //double numberUser = double.Parse(Console.ReadLine());
    public double CalculoArea (int radio) //método de clase. ¿Que pueden hacer los objetos de tipo círculo?
    {
      return PI * (radio * radio);
    }
  }

}