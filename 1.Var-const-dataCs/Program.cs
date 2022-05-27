/*
.NET 5 :
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
} 
See https://aka.ms/new-console-template for more information

//------------------------------------------------------------------------------
.NET 6:*/
Console.WriteLine("Hello");

Console.WriteLine("What's your name?");

var name = Console.ReadLine();
var name = "default name";
var currentDate = DateTime.Now;

Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
Console.WriteLine($"{Environment.NewLine}Press any key to exit.");
Console.ReadKey(true);

//!=============================================================================

//*variables-------------------------------------------------------------------

//declaración e inicialización de variables respectivamente
int edadModificacle; //modificable-declarada
int edadMayorDeEdad = 18; //modificable-inicializada

int edad2;
int edad3;
int edad4;

//signo-igual
edad2 = edad3 = edad4 = 18; //iniciando una variable a multiples declaraciones

// int edad9 = edad8 = edad7 = 60; //solo edad9 es iniciado como int 60

edad2 = edad3 = edad4 = edadMayorDeEdad;

edadModificacle = 66;

Console.WriteLine(edadModificacle);
Console.WriteLine(edad2);
Console.WriteLine(edad3);
Console.WriteLine(edad4);
Console.WriteLine(edad9);
Console.WriteLine(edad7);

//var
var edadNoModificable = 11; //no se puede modificar
var edadString = "12"; // var asigna un tipo de dato automaticamente
Console.WriteLine(edadNoModificable);
Console.WriteLine(edadString);

//!=============================================================================

//*Conversiones https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/numeric-conversions
//?Para que aplique en todos los tipos se hace obligatoriamente un EXPLICIT CASTING

//?conversión EXPLICIT, casting----------------------------------------------
// sbyte - byte - short - ushort - int - uint - long - ulong - float - nint - nuint

double temperatura = 22.3; //double, decimales

//&conversión double to int
int temperaturaLima; //int, enteros
Console.WriteLine(temperatura);
//el valor de temperatura lo paso a entero y luego lo almacena en temperaturaLima
temperaturaLima = (int) temperatura; 
Console.WriteLine(temperaturaLima); 
//*NO REDONDEA, SOLO QUITA EL DECIMAL


//?conversión IMPLICIT, casting------------------------------------------------
int habitantesCiudad = 9999;
long habitantesCiudad2018 = habitantesCiudad;
//habitantesCuidad es inicializada como long
//luego almacenada el valor de tipo int habitantesCiudad como long
Console.WriteLine(habitantesCiudad2018);


//&conversión flaot to double

//*VARIABLE DE TIPO FLOAT SIEMPRE LLEVA SUFIJO F
float pesoMaterial = 5.78F;
//*DOUBLE ES UN VALOR DECIMAL PERO EL DOBLE DE PRECISO
double pesoMaterialPrecio = pesoMaterial;
Console.WriteLine(pesoMaterial);
Console.WriteLine(pesoMaterialPrecio);


//?muy implícita--------------------------------------------------------------
int soyImplicito = 1294;
double soyMasImplicito;
soyMasImplicito = soyImplicito;
Console.WriteLine(soyMasImplicito);

//?typeConversion--------------------------------------------------------------
//& string to a number

//~ EXCEPTIONS ↓
Console.WriteLine("Introduce el primer valor numérico");
int num1 = int.Parse(Console.ReadLine());//error: puede recibir simbolos no numericos

Console.WriteLine("Introduce el segundo valor numérico");
int num2 = int.Parse(Console.ReadLine()); //error: puede recibir simbolos no numericos

Console.WriteLine($"La suma de ambos valores es: {num1 + num2}");
//~ EXCEPTIONS ↑

string numString1 = "12";
string numString2 = "78";
int resultado = Int32.Parse(numString1) + Int32.Parse(numString2);

Console.WriteLine($"El resultado de la suma es {resultado}");

//!=============================================================================
//?const-----------------------------------------------------------------------
//siempre se les asigna un nombre en mayúscula
const string VALOR = "Una constante siempre va en mayúscula";
const int VALORDOS = 123;

Console.WriteLine($"DATO IMPORTANTE: {VALOR}. Numero.{VALORDOS}");
Console.WriteLine("El valor de la constante es string primero y luego int respectivamente: {1} , {0}", VALOR, VALORDOS);

//?operacion-------------------------------------------------------
const double PI = Math.PI;

Console.WriteLine("Introduce el radio de la cirfunferencia: "); 

double radio = float.Parse(Console.ReadLine());

double areaDelCirculo = Math.Pow(radio,2); //elevando al cuadrado el radio
Console.WriteLine($"El área del circulo es: {areaDelCirculo} "); 
//? float * double error?

//!=============================================================================

//?operadores-aritmeticos-------------------------------------------------------

Console.WriteLine("Operadores aritmeticos", 2 + 2);
Console.WriteLine(2 - 2);
Console.WriteLine(2 * 2); //numeros enteros
Console.WriteLine(2.5 * 2.5); //numeros decimales
Console.WriteLine(10 / 4); //numero entero
Console.WriteLine(10 / 4.0); //numero decimal

//!=============================================================================
//&
//!
//^
//?
//*
//~
//todo