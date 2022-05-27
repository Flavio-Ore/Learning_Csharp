using System;
//*VARIABLES STATIC Y METHODS
namespace Calls_and_Math_class
{
  class Program
  {
    static void Main(string[] args)
    {
      pOOVI();
      pOOVII();
      pOOVIII();
    }
//----------------------------------------------------------------------------
    static void pOOVI()
    {
      Punto origen = new Punto();//this.x = 0; this.y = 0   

      Punto destino = new Punto(3,4);//this.x = x; this.y = y

      //parámetro variable tipo Punto (es decir que tendrá los mismos parámetros y funciones que la clase original pero realmente son copias)
      double distancia = origen.DistanciaHasta(destino);  

      Console.WriteLine($"La distancia entre los puntos es: {distancia}");     
    }
//----------------------------------------------------------------------------
    static void pOOVII()
    {
      Punto origenDos = new Punto(5,10);      

      Punto destinoDos = new Punto(-2,-9);

      double distanciaDos = origenDos.DistanciaHasta(destinoDos);
      
      Console.WriteLine(distanciaDos);
    }
//------------------------------------------------------------------------    
    static void pOOVIII()
    {
      Punto noStatic = new Punto();
//!UN OBJETO DE CLASE NUNCA PODRÁ ACTUAR SOBRE UNA VARIABLE DE CLASE/STAIC
      //noStatic.ContadorDeObjectos();

      Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeCantidadDeLlamadoDeObjectos()}");
      
      Punto.ContadorDeCantidadDeLlamadoDeObjectos();
    }

  }
  
}