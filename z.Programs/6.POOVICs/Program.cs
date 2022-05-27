using System;
//continuar por aqui
// TODO: visual studio tiene un panel de tareas
namespace Visual_Studio_POO //mismo namespace
{
  class Program 
  {

    static void Main(string[] args)
    {
      RealizarTarea();
    }

    static void RealizarTarea()
    {
      //el Punto está porque lo modularizamos, está ubicado en otro archivo
      Punto origen = new Punto();

      Punto origenDos = new Punto(5, 10);

      Punto origenTres = new Punto(4,5,5);
    }

  }


}