using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesICs
{
    public class Mamiferos
    {
        private string nombre;

        public Mamiferos(string nombre) => this.nombre = nombre;

        public void Voz() => Console.WriteLine("Voz animal");
        public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que mueran o hasta que valgan por sí mismas");
        public virtual void Pensar() => Console.WriteLine("Pensamiento de supervivencia");

        public string Nombre { get => nombre;}
    }
    //Balleno 0 patas
    public class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena): 
            base(nombreBallena)
        {}
        public void Nadar() => Console.WriteLine("Puedo nadar");
    }
    //Humano tiene 4 patas
    public class Humano:
        Mamiferos, IMamiferos //* <= Usando la interfaz en la subclase Humano
    {
        public Humano(string nombreHumano): 
            base(nombreHumano) 
        {}
        public override void Pensar() => Console.WriteLine("Ser o no ser");

        //^Desarrollando el método IMamiferosTerrestres
        public int NumeroPatas() => 4; //tiene 4 patas, modificamos el método y decimos que retorne 4 patas
    }
    //Loro tiene 2 patas
    public class Loro: 
        Mamiferos, IMamiferos
    {
        public Loro(string nombreLoro): 
            base(nombreLoro)
        {}
        public int NumeroPatas() => 2; //el loro tiene 2 patas
    }
    
}