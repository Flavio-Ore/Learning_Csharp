using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    abstract public class Animales
    {
        public void Respirar() => Console.WriteLine("Soy capaz de respirar");
        
        public abstract string Nombre{get;}
    }
}