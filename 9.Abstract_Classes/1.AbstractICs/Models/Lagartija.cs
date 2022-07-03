using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractICs.Models
{
    public class Lagartija : Animales
    {
        //fields
        private string nombreLagartija;
        //constructor
        public Lagartija(string nombreLagartija) => this.nombreLagartija = nombreLagartija;

        //abstraction
        public override string Nombre {get => nombreLagartija;}
    }
}