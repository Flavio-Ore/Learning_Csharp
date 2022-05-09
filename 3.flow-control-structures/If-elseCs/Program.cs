using System;
namespace program
{   
    class Program
    {
        static void Main(string[] args)
        {
//-----------------------------------------------------------------------------

        bool booleans;
        booleans = true;
        // && and ||
        Console.WriteLine(!booleans); 
        //^invierte el valor almacenado de true a false

//-----------------------------------------------------------------------------

        int edad = 22;

        if (edad >= 18) {
            Console.WriteLine("Eres mayor de edad");
        } else {Console.WriteLine("Eres menor de edad");
        }

//-----------------------------------------------------------------------------

        bool carnet = false;
        //? Sin usar las llaves | el bloque pertenece al condicional if
        //! Si es una linea de código
        if(carnet) Console.WriteLine("Tienes el permiso para conducir"); 
        else Console.WriteLine("No tienes el permiso");   

//-----------------------------------------------------------------------------

       Console.WriteLine("Estas viendo si puedes entrar a una fiesta, a continuación coloca los siguientes datos. (Para entrar a la fiesta debes ser mayor de edad y tener carnet de vacunación)");

        string carnetUsu = "no";

//-----------------------------------------------------------------------------
        //* &&
        
        //Console.Write("¿Cuantos años tienes? ");

        //int edadUsu = int.Parse(Console.ReadLine());

        //~ SOLUCION 1
        /*
        if(edadUsu >= 18) {
            Console.Write("Tienes carnet de vacunación? ");

            carnetUsu = Console.ReadLine();
        }

        if(edadUsu >= 18 && carnetUsu == "si") //! Estamos usando la variable carnetUsu sin que se haya inicializado anteriormente, por lo que dará error si no se realizó ello.
            Console.WriteLine("Puede ingresar");
        else 
            Console.WriteLine("No puede entrar a la fiesta");
        */

        //~ SOLUCION 2
        /*
        if(edadUsu < 18) 
            Console.WriteLine("No puede ingresar.");

        else {
            Console.Write("¿Tienes carnet de vacunación? ");

            carnetUsu = Console.ReadLine();

            int compara = String.Compare(carnetUsu, "si", true);

            if(compara==0) Console.WriteLine("Puede entrar a la fiesta.");

            else Console.WriteLine("Lo siento, no puede ingresar a la fiesta.");
        }
        */

//--------------------------------------------------------------            
        //* ||

        Console.WriteLine("Introduce el primer parcial: ");
        float parcial1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el primer parcial: ");
        float parcial2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el primer parcial: ");
        float parcial3 = Int32.Parse(Console.ReadLine());

//--------------------------------------------------------------            
//? Se hace la media con tal de que apruebes uno de los tres parciales, obtendrás la media. Pero si suspendes los tres, desapruebas, por más que en un parcial hayas sacado bajo

        if(parcial1 >= 12 || parcial2 >= 12 || parcial3 >= 12)
            Console.WriteLine("La nota media es: " + (parcial1+parcial2+parcial3)/3);
        else 
            Console.WriteLine("Vuelve en septiembre");

//--------------------------------------------------------------            
        }
    }
}
