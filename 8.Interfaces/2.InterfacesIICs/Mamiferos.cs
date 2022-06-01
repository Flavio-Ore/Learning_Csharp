using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesIICs
{
    //^¿Qué animales participan en deportes?¿Qué cantidad de patas tienen?¿Con qué cantidad de pantas son capaces de brincar?
    public class Mamiferos
    {
        private string nombre;

        public Mamiferos(string nombre) => this.nombre = nombre;

        public void Voz() => Console.WriteLine("Voz animal");
        public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que mueran o hasta que valgan por sí mismas");
        public virtual void Pensar() => Console.WriteLine("Pensamiento de supervivencia");

        public string Nombre { get => nombre;}
    }
    //Humano tiene 4 patas
    public class Humano:
        Mamiferos, IPatasMamiferos, IAnimalesDeportes, ISaltoCantidadPatas //* <= Interfaces en la subclase Humano
    {
        public Humano(string nombreHumano): 
            base(nombreHumano) 
        {}
        public override void Pensar() => Console.WriteLine("Ser o no ser");

        //^Desarrollando el método de IAnimalesDeportes
        public string TipoDeporte() => "Todo tipo de deporte";
        public bool EsOlimpico() => true;

        //!Ambigüedad. ICantidadPatas tiene el mismo método que ISaltoCantidadPatas. Solución:
        int ISaltoCantidadPatas.NumeroPatas() => 2; //salta con 2 patas
        int IPatasMamiferos.NumeroPatas() => 4; //tiene 4 patas, modificamos el método y decimos que retorne 4 patas
    }

    //Loro tiene 2 patas
    public class Loro: 
        Mamiferos, IPatasMamiferos, IAnimalesDeportes //* <= La interfaz
    {
        public Loro(string nombreLoro): 
            base(nombreLoro)
        {}
        int IPatasMamiferos.NumeroPatas() => 2; //el loro tiene 2 patas

        public string TipoDeporte() => "Acrobacias de vuelo";
        public bool EsOlimpico() => false;
    }
    //Balleno 0 patas
    public class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena): 
            base(nombreBallena)
        {}
        public void Nadar() => Console.WriteLine("Puedo nadar");
    }
    
}