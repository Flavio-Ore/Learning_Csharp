using System;

namespace ExceptionIII
{
class Program
{
  static void Main(string[] args)
  {
        
    //~ try-catch-finally
    //? Si el programa falla en alguna parte del código del bloque try no se ejecutrará
    //? Si necesitamos un código que necesitamos que se ejecute siempre, usamos finally, ya que en try o catch se puede ignorar parte del código
    //! EL FINALLY SE USA EN BBDD Y LECTURA DE FICHEROS EXTERNOS
    //? Se utiliza siempre que necesitemos liberar recursos para BBDD
    //? Cuando leemos ficheros se crea un canal de conexión

    //^ conexión con el sistema de archivos llamado throw.txt

    //en archivo se almacenará el contenido de throw.txt en la carpeta Csharp
    //! ESTA CONSUMIENDO RECURSOS EL StreamReader
    System.IO.StreamReader archivo = null;

    try
    {
    
      string linea; //almacenando lineas del fichero

      int contador = 0; //avance el fichero linea por linea

      string path = @"D:\Csharp\4.Exceptions\throw.txt"; //el enrutamiento
      
      archivo = new System.IO.StreamReader(path);

      while ((linea = archivo.ReadLine()) != null)
      {

        Console.WriteLine(linea);

        contador++;

      }

    }

    catch (Exception ex)
    {
      Console.WriteLine("Error con la lectura del archivo");
    }

    finally
    {
      if (archivo != null) archivo.Close();

      Console.WriteLine("Conexión con el fichero cerrada");      
    }


  }


}
}