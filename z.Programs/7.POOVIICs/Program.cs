using System;
namespace Calls_and_Math_class
{
  class Program
  {
    static void Main(string[] args)
    {
      //intento 1
      /*
      Humano newHuman = new Humano();

      Humano flavio = new Humano(15,"Flavio Ore");
      
      Console.WriteLine(flavio.GetInfoHumano());
      */

      doTask();
    }
//----------------------------------------------------------------------------
    static void doTask()
    {
      Punto origen = new Punto();      

      Punto destino = new Punto(3,4);

      //parámetro Punto otroPunto | parámetro variable tipo Punto
      double distancia = origen.DistanciaHasta(destino);  

      Console.WriteLine($"La distancia entre los puntos es: {distancia}");
    }
  }
}