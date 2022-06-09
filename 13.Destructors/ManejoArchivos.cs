using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Destructors
{
    //^un flujo de datos, stream
    public class ManejoArchivos
    {
        //fields
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        //constructor
        public ManejoArchivos()
        {
            archivo = new StreamReader(@"D:\Csharp\13.Destructors\text\public\anotherText.txt");
            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        
        //method
        public void Mensaje() => Console.WriteLine($"Hay {contador} líneas.");

        //destructor
        //~ el destructor debe tener el mismo nombre de la clase
        ~ManejoArchivos()
        {
            //el código que se ejecute cuando el garbage collection está eliminando ese recurso
            //Close() para cerrar la conexión.
            //para eliminar todo aquello que se quiere que se ejecute inmediatamente después de haber elminado el recolector de basura, el recurso correspondiente.
            archivo.Close(); 
        }

    }
}