using System;
namespace program
{   
    class Program
    {
        static void Main(string[] args)
        {
//-----------------------------------------------------------------------------

        bool booleans;
        booleans = false;

        // && and ||
        Console.WriteLine(!booleans); 
        //^invierte el valor almacenado de true a false

        if (booleans) // (booleans == true)
            Console.WriteLine("Booleans is true");
        else  if (!booleans) // (booleans == false)
            Console.WriteLine("Booleans is false");

//-----------------------------------------------------------------------------

        int edad = 22;

        if (edad >= 18)
            Console.WriteLine("Eres mayor de edad");
        else 
            Console.WriteLine("Eres menor de edad");
        

//-----------------------------------------------------------------------------

        bool carnet = false;
        //? Sin usar las llaves | el bloque pertenece al condicional if
        //! Si es una linea de código
        if(carnet) Console.WriteLine("Tienes el permiso para conducir"); 
        else Console.WriteLine("No tienes el permiso");   

//-----------------------------------------------------------------------------

       Console.WriteLine("Estas viendo si puedes entrar a una fiesta, a continuación coloca los siguientes datos. (Para entrar a la fiesta debes ser mayor de edad y tener carnet de vacunación)");

        //string carnetUsu = "no";

//-----------------------------------------------------------------------------
        //~ &&
/*
        Console.Write("¿Cuantos años tienes? ");

        int edadUsu = int.Parse(Console.ReadLine());

        //~ SOLUCION 1
        
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
        //~ ||
/*
        Console.WriteLine("Introduce el primer parcial: ");
        float parcial1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el primer parcial: ");
        float parcial2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el primer parcial: ");
        float parcial3 = Int32.Parse(Console.ReadLine());
*/
//--------------------------------------------------------------            
//? Se hace la media con tal de que apruebes uno de los tres parciales, obtendrás la media. Pero si suspendes los tres, desapruebas, por más que en un parcial hayas sacado bajo
/*
        if(parcial1 >= 12 || parcial2 >= 12 || parcial3 >= 12)
            Console.WriteLine("La nota media es: " + (parcial1+parcial2+parcial3)/3);
        else 
            Console.WriteLine("Vuelve en septiembre");
*/
//-------------------------------------------------------------- 
     
/*
        Console.WriteLine("Introduce tu altura");
        
        double altura = double.Parse(Console.ReadLine());

        if (altura <1.30)
            Console.WriteLine("Eres muy pequeño para entrar");
        else if(altura >1.80)
            Console.WriteLine("Lo lamento, no puede ingresar");
        else 
            Console.WriteLine("Puede ingresar al juego");
*/         

//--------------------------------------------------------------------    

        Console.WriteLine("Que medio de transporte desea utilizar: ");
        Console.Write("(coche, tren, avión, barco): ");

        //~ SWITCH condicional
//& Cada expresión constante ha de ser única.
//& Solo se puede usar el switch para evaluar:
    //? int - char - String - Los demás usan if (float, double)
//& Los case solo pueden contener expresiones constantes.
//& Todos los case deben llevar su break
    //? Se puede utiliza return y throw
/*
        string Transporte = Console.ReadLine();

        switch(Transporte)
        { //?    ^ ^ ^ solo evalua valores enteros char o string
            //? Solo evalua expresiones constantes
            case "coche":
                Console.WriteLine("La velocidad máxima permitida es 120km/h");
                break; 

            case "tren":
                Console.WriteLine("La velocidad máxima permitida es 200km/h");
                break;

            case "avión":
                Console.WriteLine("La velocidad máxima permitida es 250km/h"); 
                break;

            case "barco":
                    Console.WriteLine("La velocidad máxima permitida es 24 nudos");
                break;

            default:
                Console.WriteLine("Este transporte no está disponible");
                break;
        //! break; es obligatorio
        }; 
*/
//--------------------------------------------------------------------
        Console.WriteLine();

        //~ WHILE
        Console.WriteLine("¿Desea entrar al bucle?");
        Console.Write($" si / no  ");
        
        //string result = Console.ReadLine();

    
        //while (result != "no") //! while could be true or false
        //? si decimos que "no", esta condición será false, porque "no" NO es diferente del string "no", es igual. FALSE.
        //? si decimos cualquier otra cosa string, esta condición será true, porque es diferente del string no. TRUE
        //! mientras result ES diferente de "no", el programa ejecutará las líneas de código con normalidad, pero si es igual que "no", entonces no se ejecutará
/*
        { 
            Console.WriteLine("Entraste al bucle");

            Console.WriteLine("¿Desea seguir en el bucle?");

            Console.Write(" si / no  ");

            result = Console.ReadLine(); //? Cambiamos el contenido de result.
            //^ ambito de variable
        }
*/

        Console.WriteLine();

        //~ WHILE bucle indeterminado | Situación a resolver
//? Genera un numero aleatorio del 1 - 100. El programa debe pregunar por consola de qué numero se trata, como no sabemos cual es, introducimos un numero aleatorio, luego el programa debe indicar si el numero introducido es mayor o menor, hasta que insertemos el numero correcto, me debe indicar el numero de intentos que tomó adivinarlo y el que el número fue adivinado.
/*
//~ 1RA SOLUCION |||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        Console.WriteLine("Adivine el número del 1 - 100 (no se mostrará en pantalla el número a adivinar)");
        
        //numero aleatorio del 1 - 100.
        Random rand = new Random(); //genera numero aleatorio

        int numAleatorio = rand.Next(0,100); //entre 0 y 100

        //Console.WriteLine(numAleatorio); //!solo test


        //numero que ingresa el usuario        
        int numUser = Int32.Parse(Console.ReadLine());


        //numero de intentos
        int numIntentos = 0;


        //bucle while

        while (numAleatorio != numUser)
        {    
            while (numAleatorio > numUser)
{
                Console.WriteLine($"El numero es MAYOR a {numUser}");
                numIntentos++;
                numUser = Int32.Parse(Console.ReadLine());
            }

            while (numAleatorio < numUser)
            {
                Console.WriteLine($"El numero es MENOR a {numUser}");
                numIntentos++;
                numUser = Int32.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine($"Te tomó {numIntentos} intentos.");
*/
//~ 2DA SOLUCION |||||||||||||||||||||||||||||||||||||||||||||||||||||||||
/*
        Random numero = new Random();

        int numeroAleatorio = numero.Next(0, 100);

        int miNumero = 101;

        int intentos = 0;

        Console.WriteLine("Introduce un número entre 0 y 100");

        while (numeroAleatorio != miNumero)
        {
            intentos++;

            miNumero = int.Parse(Console.ReadLine());

            if (miNumero > numeroAleatorio)
                Console.WriteLine("El número es más bajo");

            if (miNumero < numeroAleatorio)
                Console.WriteLine("El número es más alto");
        }

        Console.WriteLine($"Acertaste, te tomó {intentos} intentos.");
*/
//--------------------------------------------------------------------

        //~ DO-WHILE bucle indeterminado
//? Su funcionamiento es idéntido al bucle while excepto que; el bucle do-while ejecutará el códgo de su interior al menons una vez (aunque la condición sea false).
/*
        int z = 10;

        do {

            Console.WriteLine("Impresión" + z);

            z++;

        } while (z < 16); // NO z = 10 => ERR
*/
//--------------------------------------------------------------------
/*
        Random numero = new Random();

        int numeroAleatorio = numero.Next(0, 100);

        int miNumero;

        int intentos = 0;

        Console.WriteLine("Introduce un número entre 0 y 100");

        do {

            intentos++;

            miNumero = int.Parse(Console.ReadLine());

            if (miNumero > numeroAleatorio)
                Console.WriteLine("El número es más bajo");

            if (miNumero < numeroAleatorio)
                Console.WriteLine("El número es más alto");

        } while (numeroAleatorio != miNumero);

        Console.WriteLine($"Acertaste, te tomó {intentos} intentos.");
*/
//--------------------------------------------------------------------
        }
    }
}
