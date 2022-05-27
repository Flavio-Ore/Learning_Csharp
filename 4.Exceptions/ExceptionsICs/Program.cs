using System;
namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      //~ errores en el tiempo de ejecución del program que escapan de las manos del programador
      //? Memoria corrupta 
        //nuestro programa cae
      //? Desbordamiento de la pila de llamadas
        //nuestro programa cae
      //? Sectores de dico duro defectuosos
        //hacen que haya un error en la escritura o lectura y cae el programa
      //? Acceso a ficheros inexistentes
        //cuando los ficheros no estan donde deberian estar: cae el programa
      //? Conexiones a BBDD interrumpidas
        //motivos ajenos a nuestro control: cae el programa
      //? Etc.

      //! La captura o manejo de excepciones consiste en capturar una excepción o error en tiempo de ejecución. Nuestro programa realiza algo en caso se genera ese error o excepción

//-------------------------------------------------------------------------

      Random numero = new Random();

      int numeroAleatorio = numero.Next(0, 100);

      int intentos = 0;

      int miNumero;

      Console.WriteLine(intentos);
      
//-------------------------------------------------------------------------

/*
    Console.WriteLine("Introduce un número entre 0 y 100");

    while (numeroAleatorio != miNumero)
    {
      intentos++; 
      !El programa puede caer si inserta string en lugar numbers
      ?miNumero = int.Parse(Console.ReadLine()); 
      ?error: puede recibir simbolos no numericos

      if (miNumero > numeroAleatorio)
        Console.WriteLine("El número es más bajo");

      if (miNumero < numeroAleatorio)
        Console.WriteLine("El número es más alto");
    }

    Console.WriteLine($"Acertaste, te tomó {intentos} intentos.");
*/

//-------------------------------------------------------------------------

      //~ try-catch
/* 
    Console.WriteLine("Introduce un número entre 0 y 100");

    while (numeroAleatorio != miNumero)
    {
      intentos++; 
            
      //? Al intentarlo, puede que lo consiga o no, si no se consigue, no se ejecuta, la variable miNumero jamás inicia.
       //? miNumero no pueden
      try
      { 
        miNumero = int.Parse(Console.ReadLine());
      }
      catch (FormatException ex)
      { //? Si el try tiene exito, el catch no se ejecuta
        Console.WriteLine("No haz introducido un valor numérico. Se toma como número introducido el 0");
        miNumero = 0; 
        //? Le reasignamos el valor de miNumero a 0 para que luego los condicionales puedan usarla y compararla
      }

      if (miNumero > numeroAleatorio)
        Console.WriteLine("El número es más bajo");

      if (miNumero < numeroAleatorio)
        Console.WriteLine("El número es más alto");

    }

    Console.WriteLine($"Acertaste! Te tomó {intentos} intentos.");
*/

//-------------------------------------------------------------------------

    //~ try-catch-catch-catch
/*  
    Console.WriteLine("Introduce un número entre 0 y 100");
    //si ingresa strings o numeros muy extensos
    //? FormatException | OverFlowException

    do {

      intentos++; 
            
      try{ 

        miNumero = int.Parse(Console.ReadLine());

      } catch (FormatException ex){

        Console.WriteLine("No has introducido un valor numérico. Se toma como número introducido el 0");
        miNumero = 0; 

      } catch (OverflowException ex){

        Console.WriteLine("Has introducido un valor demasiado alto. Se toma como número introducido el 0");
        miNumero = 0; 

      }

      if (miNumero > numeroAleatorio)
        Console.WriteLine("El número es más bajo");
      
      if (miNumero < numeroAleatorio)
        Console.WriteLine("El número es más alto");
      
    } while (numeroAleatorio != miNumero);

    Console.WriteLine($"Acertaste! Te tomó {intentos} intentos.");
*/

//-------------------------------------------------------------------------

    //~ Exception in Inheritance
    //^ EXCEPTION > SystemException > FormatException <> OverflowException
/*    Console.WriteLine("Introduce un número entre 0 y 100");
    //si ingresa strings o numeros muy extensos
    //? FormatException | OverFlowException

    do {

      intentos++; 
            
      try { 

        miNumero = int.Parse(Console.ReadLine());

      } catch (Exception ex){ //ex es ua variable con métodos y propiedades

        //^ Cuando usas la clase Exception del tipo genérico, puedes omitir colocar (Exception ex) pero se considera mala práctica

        //? No tenemos bien en claro qué tipo de exception va a capturar

        //! Usar siempre la exception genérica no es recomendable, hay que ser muy específicos a la hora de capturar errores

        Console.WriteLine("No has introducido un valor numérico válido. Se toma como número introducido el 0");
        //?Console.WriteLine(ex.Message);
        miNumero = 0; 

      }

      if (miNumero > numeroAleatorio)
        Console.WriteLine("El número es más bajo");
      
      if (miNumero < numeroAleatorio)
        Console.WriteLine("El número es más alto");
      
    } while (numeroAleatorio != miNumero);

    Console.WriteLine($"Acertaste! Te tomó {intentos} intentos.");
*/

//-------------------------------------------------------------------------

    //~ Conflicts several exceptions, capture with filters.
/*    Console.WriteLine("Introduce un número entre 0 y 100");

    do {

      intentos++; 
            
      try { 

        miNumero = int.Parse(Console.ReadLine());
*/
/* //~ Cascada
      } catch (FormatException ex){
        
        Console.WriteLine("Has introducido texto");
        
        miNumero = 0;

      //Cuando el compilador encuentra el primero que se adecua a esa exception ignora el resto

      }catch (Exception ex){ 

        Console.WriteLine("No has introducido un valor numérico válido. Se toma como número introducido el 0");
        //Console.WriteLine(ex);
        
        miNumero = 0; 
*/
//~ Exepciones con Filtros
//& Cuando queremos capturar muchas excepciones y darles a todas un tratamiento genérico excepto a UNA de ellas usamos excepciones con filtro. 
//? Usamos la captura genérica, usamos la cláusula WHEN y dentro especificamos la excepcion a excluir de la captura, usamos la propiedad GetType que pertenece al objeto ex, mientras que el tipo de excepcion (ex.GetType) sea diferente de FormatException (tupeof(FormatException))
//* Capturar todas las exceptiones sin saber cuales van a ser pero hay una en concreto que quieres tratar de forma específica.
/*      } 
      catch (Exception ex) when (ex.GetType() != typeof(FormatException))
      { 
        Console.WriteLine("Hubo un error. Se toma como número introducido el cero");
        miNumero = 0;
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Has introducido texto. Formato no válido");
        miNumero = 0;
        
      }

      if (miNumero > numeroAleatorio)
        Console.WriteLine("El número es más bajo");
      
      if (miNumero < numeroAleatorio)
        Console.WriteLine("El número es más alto");
      
    } while (numeroAleatorio != miNumero);

    Console.WriteLine($"Acertaste! Te tomó {intentos} intentos.");
*/
    }

  }

}



