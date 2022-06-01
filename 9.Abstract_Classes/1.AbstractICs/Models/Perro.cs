using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    sealed public class Perro:
        Mamiferos, IMamiferosTerrestres, ISonidoMamifero
    {
        //constructor
        public Perro(string nombrePerro):
            base(nombrePerro)
        {}
        
        //methods
        public override void Pensar() => Console.WriteLine("Pensamiento de protección a mi amo.");
        public void Amo(string nombreAmo) => Console.WriteLine($"Mi amo es {nombreAmo}");
        
        //Implementing
        public string SonidoMamifero() => "Wof,wof";
        public int CantidadPatas() => 4;
        public int PatasSaltar() => 2;
        
    }
}