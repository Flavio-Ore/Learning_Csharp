using System;

namespace Destructors
{
  //^Recolector de basura
  //Los recursos de un ordenador no son ilimatados, la memoria heap del ordenador quedaria saturada.
  //El recolector de basura detecta cuando un recurso que ocupa un espacio en memoria ya no se va a utilizar y lo elimina.
  //Elimina todo aquello relacionado con ese recurso, pero a veces esa eliminación no es inmediata.

  //^Destructor
  //Ejecuta un código cuando se elimina un recurso de la memoria por parte del recolector de basura.
  //Conexiones con BBDD.
  //Cierre de streams en el manejo externo de ficheros.
  //Eliminación de objetos de colecciones.

  //^Tener encuenta de los constructores
  //Los destructores solo se usan en clases
  //Cada clase solo puede tener un destructor
  //Los destructores no se heredan ni se sobrecargan
  //Los destructores no se llaman. Son invocados automáticamente
  //Los destrucores no tienen modificadores de acceso ni parámetros

  //^No utilizar destructores
  //Complican la sintaxis del código
  //Es fácil eliminar algo que te hace falta
  //!Solo utilizalo cuando tienes muy claro el recurso a elminar de forma inmediata y que ese recurso no tiene asociados a objetos, cosas que no controlas
  
  public class Program
  {
    static void Main(string[] args)
    {
      ManejoArchivos miArchivo = new ManejoArchivos();
      miArchivo.Mensaje();
    }
  }

}