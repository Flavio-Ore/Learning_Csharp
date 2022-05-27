using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visual_Studio_POO //mismo namespace
{
    class Punto
    {
        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto");
        }
        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenada en R2x: {x}, y: {y}");            
        }
        public Punto(int x, int y, int z)
        {
            Console.WriteLine($"Coordenada en R3: x: {x}, y: {y}, z: {z}");
            
        }
            
    }
}