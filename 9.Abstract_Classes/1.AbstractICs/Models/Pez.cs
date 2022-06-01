using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    public class Pez : Mamiferos
    {
        //constructor
        public Pez(string nombrePez):
            base(nombrePez)
        {}
        //method
        public void Nadar() => Console.WriteLine("Soy capaz de nadar");
        
    }
}