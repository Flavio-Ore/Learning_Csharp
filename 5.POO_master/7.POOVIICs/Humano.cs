using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calls_and_Math_class
{
    class Humano
    {
        //main constructor
        public Humano()
        {
            this.edad = 0;
            this.nombre = "sin nombre";
            Console.WriteLine($"Valores por defecto de este humano son: edad {edad}, nombre: {nombre}");
        }
        public Humano(int edad, String nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }
        /*
        public string CrearHijo(Humano hijo)
        {
            hijo.edad = this.edad;
            this.nombre = hijo.nombre;
            String info = $"Nombre: {nombre}. Edad: {edad}";
            return info;
        }
        */
        public string GetInfoHumano() => $"Nombre: {nombre}. Edad: {edad}";
        private int edad;
        private String nombre;
        
    }
}