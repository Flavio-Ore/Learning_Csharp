using System;
using AbstractICs.Models;

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