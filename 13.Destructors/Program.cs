using System;

namespace Destructors
{
  //^Recolector de basura
  //Los recursos de un ordenador no son ilimatados, la memoria heap del ordenador quedaria saturada.
  //El recolector de basura detecta cuando un recurso que ocupa un espacio en memoria ya no se va a utilizar y lo elimina.
  //Elimna todo aquello relacionado con ese recurso, pero a veces esa eliminación no es inmediata.

  //^Destructor
  //Ejecuta un código cuando se elimina un recurso de la memoria por parte del recolector de basura.
  //Conexiones con BBDD.
  //Cierre de streams en el manejo externo de ficheros.
  //Eliminación de objetos de colecciones.

  public class Program
  {
    static void Main(string[] args)
    {
      ManejoArchivos miArchivo = new ManejoArchivos();
      miArchivo.Mensaje();
    }
  }

}