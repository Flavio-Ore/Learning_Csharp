using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//*VARIABLES STATIC Y METHODS
namespace Calls_and_Math_class
{
class Punto
{
// constructor
  public Punto() 
  { 
    //private int x,y; | setting the default values
    this.x = 0;
    this.y = 0;
    Console.WriteLine($"Este es el constructor por defecto. x = {x}, y = {y}.");
    contadorDelObjeto++;          
  }
  // constructor sobrecarga
  public Punto(int x, int y) 
  { 
    //private int x,y;
    this.x = x;
    this.y = y;
    Console.WriteLine($"Coordenada en R2. x = {x}, y = {y}");
    contadorDelObjeto++;          
  }
  //hallar la distancia entre dos puntos
  public double DistanciaHasta(Punto otroPunto)//la variable otroPunto tiene de propiedaes al x, y.
  {
    //this. hace referencia al objeto que creamos a partir de una clase
    int xDif = this.x - otroPunto.x;
    // this.y, x = 0 | otroPunto.x,y = a los parámetros que colocamos:       Punto destino = new Punto(3,4);
    int yDif = this.y - otroPunto.y;
    //sqrt = raiz cuadrada | pow = potenciación
    double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
    
    contadorDelObjeto++;

    return distanciaPuntos;
  }
  public void SetZ(int z) => this.z = z; 
  public static int ContadorDeCantidadDeLlamadoDeObjectos()
  {
    contadorDelObjeto++;
    return contadorDelObjeto;
  }
  //una variable STATIC pertenece a la propia clase y es compartida con todos los objetos, cada que creamos uno se incrementa en 1
  private static int contadorDelObjeto = 0; 
  private int x,y,z;
  //modificador de acceso - static - type of data
  }
}