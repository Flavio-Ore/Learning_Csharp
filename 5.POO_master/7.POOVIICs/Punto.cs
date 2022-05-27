using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calls_and_Math_class
{
class Punto
{
  public Punto() // constructor
  { //private int x,y; | setting the default values
    this.x = 0;
    this.y = 0;
    Console.WriteLine($"Este es el constructor por defecto. x = {x}, y = {y}.");
  }
  public Punto(int x, int y) // constructor sobrecarga
  { //private int x,y;
    this.x = x;
    this.y = y;
    Console.WriteLine($"Coordenada en R2. x = {x}, y = {y}");            
  }
  //hallar la distancia entre dos puntos
  public double DistanciaHasta(Punto otroPunto)
  {//this. hace referencia al objeto origen o al 
    int xDif = this.x - otroPunto.x;
    int yDif = this.y - otroPunto.y;
    //sqrt = raiz cuadrada | pow = potenciación
    double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
        
    return distanciaPuntos;
  }
  private int x,y;  
  }
}