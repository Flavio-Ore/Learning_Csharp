using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs
{
    public class Humano:
        Mamiferos, IMamiferosTerrestres, ISonidoMamifero
    {
        //constructor
        public Humano(string nombreHumano):
            base(nombreHumano)
        {}

        //methods
        public override void Pensar() => Console.WriteLine("Ser o no ser");
        public void Actividad() => Console.WriteLine("Hago mis deberes");

        //implementing
        public string SonidoMamifero() => "AAAAAhhh";
        public int CantidadPatas() => 4;
        public int PatasSaltar() => 2;
    }
}