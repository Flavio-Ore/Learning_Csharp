using System;

namespace InterfacesIICs
{
  class Program
  {
    public static void Main(string[] args)
    {
      //Interfaces I --------------------------------------------------------   
      //!Interfaces para Patrones de diseño
      //Podemos obligar a los futuros desarrolladores que utilizaran esta aplicación deberán especificar en esa nueva clase Mamiferos (por ejemplo) cuantas patas tiene el animal.
      //?Por ejemplo, que si crean la clase Burro, deban especificar un método que devuelve el número de patas 

      Mamiferos persona = new Humano("Steven");
      Console.WriteLine(persona.Nombre);

      //La Ballena no tiene patas, no tiene sentido que Ballena herede ese método, lo evitamos mediante una interface

      //!Interfaces II ---------------------------------------------------------
      //Para usar los métodos con el nombre NumeroPatas(), se debenn instanciar interfaces. Para aplicarlos, usamos el "es-un".
      Loro perico = new Loro("LoroLoco");
      Console.WriteLine(perico.Nombre);

      //Console.WriteLine(perico.NumeroPatas()); No se puede usar el método NumeroPatas porque no es public, se debe crear un objeto en base a la interfaz para llamar ese método     

      IPatasMamiferos IsaltoLoro = perico; //?un perico tiene patas? entonces usamos la interfaz IPatasMamiferos
    
      Console.WriteLine($"Cantidad de patas que usa {perico.Nombre} es {IsaltoLoro.NumeroPatas}");

    }
  }
}