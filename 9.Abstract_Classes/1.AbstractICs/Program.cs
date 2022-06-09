using System;
<<<<<<< HEAD
using AbstractICs.Models;
=======
>>>>>>> 08e6a22c1a416bbcbb2d7fa4faf5c54bf12ecb6d
namespace AbstractICs
{
  //^Abstract classes
  class Program
  {
    static void Main(string[] args)
    {
      Humano aphex = new Humano("Aphex Twin");

      Pez memo = new Pez("Memo");

      Mamiferos unMamifero = new Mamiferos("Soy un mamifero");

      Lagartija Steven = new Lagartija("Soy una lagartija");

      Console.WriteLine(Steven.Nombre);

      Steven.Respirar();

      aphex.Pensar();
    }
  }
}