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

            Console.WriteLine("¿Desea seguir en el bucle?");

            Console.Write(" si / no  ");

            result = Console.ReadLine(); //? Cambiamos el contenido de result.
            //^ ambito de variable

        }
        */

        Console.WriteLine();

        //~ WHILE 2DO CASO
//? Genera un numero aleatorio del 1 - 100. El programa debe pregunar por consola de qué numero se trata, como no sabemos cual es, introducimos un numero aleatorio, luego el programa debe indicar si el numero introducido es mayor o menor, hasta que insertemos el numero correcto, me debe indicar el numero de intentos que tomó adivinarlo y el que el número fue adivinado.

//~ 1RA SOLUCION |||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        // Console.WriteLine("Adivine el número del 1 - 100 (no se mostrará en pantalla el número a adivinar)");
        
        // //numero aleatorio del 1 - 100.
        // Random rand = new Random(); //genera numero aleatorio

        // int numAleatorio = rand.Next(0,100); //entre 0 y 100

        // //Console.WriteLine(numAleatorio); //!solo test


        // //numero que ingresa el usuario        
        // int numUser = Int32.Parse(Console.ReadLine());


        // //numero de intentos
        // int numIntentos = 0;


        // //bucle while

        // while (numAleatorio != numUser)
        // {    
        //     while (numAleatorio > numUser)
        //     {
        //         Console.WriteLine($"El numero es MAYOR a {numUser}");
        //         numIntentos++;
        //         numUser = Int32.Parse(Console.ReadLine());
        //     };

        //     while (numAleatorio < numUser)
        //     {
        //         Console.WriteLine($"El numero es MENOR a {numUser}");
        //         numIntentos++;
        //         numUser = Int32.Parse(Console.ReadLine());
        //     };
        // }

        // Console.WriteLine($"Te tomó {numIntentos} intentos.");

//~ 2DA SOLUCION |||||||||||||||||||||||||||||||||||||||||||||||||||||||||

         Console.WriteLine("Bienvenido al juego del bucle numérico");

        Console.WriteLine();
        
        Console.WriteLine("Introduce tu nombre");

        string Nombre = Console.ReadLine();

        Console.WriteLine($"Bien {Nombre} introduce un número entre el 1 y el 100");

        int nIngresado = Int32.Parse(Console.ReadLine());

        Random numero = new Random();

        int numeroAleatorio = numero.Next(0, 100);

        int intentos = 0;

        while (nIngresado != numeroAleatorio)
        {
            if (nIngresado < numeroAleatorio){

                Console.WriteLine("Debes ingresar un número mayor");

                nIngresado = int.Parse(Console.ReadLine());

            } else if (nIngresado > numeroAleatorio) {

                    Console.WriteLine("Debes ingresar un número menor");

                    nIngresado = int.Parse(Console.ReadLine());
                    
                }

                intentos++;
            }
            
            Console.WriteLine("Felicitaciónes adivinaste el número del bucle");
            Console.WriteLine();
            Console.WriteLine($"{Nombre} tu número de intentos es {intentos}");
//--------------------------------------------------------------------


        }
    }
}
