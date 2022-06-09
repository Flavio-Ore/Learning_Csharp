using System;
<<<<<<< HEAD
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace Destructors
{
    //^un flujo de datos, stream
=======
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Destructors
{
    //un flujo de datos, stream
>>>>>>> 08e6a22c1a416bbcbb2d7fa4faf5c54bf12ecb6d
    public class ManejoArchivos
    {
        //fields
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        //constructor
        public ManejoArchivos()
        {
<<<<<<< HEAD
            archivo = new StreamReader(@"D:\Csharp\13.Destructors\text\public\anotherText.txt");
=======
            archivo = new StreamReader(@"C:\text_to_read_DestructorsCsharp");
>>>>>>> 08e6a22c1a416bbcbb2d7fa4faf5c54bf12ecb6d
            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
<<<<<<< HEAD
        
        //method
        public void Mensaje() => Console.WriteLine($"Hay {contador} líneas.");

        //destructor
        //~ el destructor debe tener el mismo nombre de la clase
        ~ManejoArchivos()
=======

        //method
        public void Mensaje()
        {
            Console.WriteLine($"Hay {contador} líneas.");
        }

        //destructor
        //~ el destructor debe tener el mismo nombre de la clase
        ~ManejoArchivos() 
>>>>>>> 08e6a22c1a416bbcbb2d7fa4faf5c54bf12ecb6d
        {
            //el código que se ejecute cuando el garbage collection está eliminando ese recurso
            //Close() para cerrar la conexión.
            //para eliminar todo aquello que se quiere que se ejecute inmediatamente después de haber elminado el recolector de basura, el recurso correspondiente.
            archivo.Close(); 
        }

    }
}