using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    public class Mamiferos : Animales
    {
        //fields
        private string nombreMamifero;

        //constructor
        public Mamiferos(string nombreMamifero) => this.nombreMamifero = nombreMamifero;

        //methods   
        public virtual void Pensar() => Console.WriteLine("Pensamiento de supervivencia");
        public void CuidarCrias(int cantidadCrias) => Console.WriteLine($"Debo cuidar a mis {cantidadCrias}");
        
        //abstraction
        public override string Nombre{get => nombreMamifero;}

    }
}