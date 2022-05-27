using System;
//* ENCAPSULAMIENTO Y CONVENTIONS
//? Hacer que los datos de una clase no sean accesibles desde otra clase externa a menos que nosotros querramos
namespace private_public
{
  class Program
  {
    static void Main(string[] args)
    {

    ConvertionEuroDolar objOne = new ConvertionEuroDolar();

    objOne.cambiaValorEuro(1.45);

    Console.WriteLine(objOne.Convertion(10));
    
    }

  }

  //? CUANDO USES DATOS EN UNA CLASE, DEBEN ESTAR SIEMPRE ENCAPSULADAS

  class ConvertionEuroDolar
  {
    //su valor del euro puede cambiar a través del tiempo
    private double euro = 1.253; 

    public double Convertion(double cantidad)
    {
      return cantidad * euro;
    }

    public void cambiaValorEuro(double nuevoValor)
    { //to avoid a negative value for euro
      if (nuevoValor < 0)
      {
        euro = 1.253;
      }
      else 
       {
         euro = nuevoValor;
       }
    }
  }

  class Circulo
  { //? Encapsulando datos con private
  //el ámbito, le dice que es accesible en el método Circulo
    private const double PI = 3.14159; 

    public double CalculoArea(int radio)
    {
      return PI * (radio * radio);
    }
    
  }


}