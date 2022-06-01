using System;

namespace InterfacesICs
{
  class Program
  {
    public static void Main(string[] args)
    {
      //!Interfaces para Patrones de diseño
      //Podemos obligar a los futuros desarrolladores que utilizaran esta aplicación deberán especificar en esa nueva clase Mamiferos (por ejemplo) cuantas patas tiene el animal.
      //?Por ejemplo, que si crean la clase Burro, deban especificar un método que devuelve el número de patas 

      Mamiferos persona = new Humano("Steven");
      Console.WriteLine(persona.Nombre);

      //La Ballena no tiene patas, no tiene sentido que Ballena herede ese método, lo evitamos mediante una interface

      Loro perico = new Loro("LoroLoco");
      Console.WriteLine(perico.NumeroPatas());
      Console.WriteLine(perico.Nombre);
       
    }
  }
}