using System;
namespace Proram
{
    class Program
    {
//----------------------------------------------------------------------------

    static void Main(string[] args)
    { //~MAIN|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        firstMethod();

        //Console.WriteLine(secondMethod());

        Console.WriteLine(Addition(2,5.5));
         
         //? imagina en un futuro estas usando un futuro metodo que aun no declaras pero sabes que lo usarás, como:
         //~VISUAL STUDIO IDE 2022 methods
         Console.WriteLine(Subtraction(11, 6.5));

//----------------------------------------------------------------------------

        int value1 = 123;
        int value2 = 77;
        double value3 = 1.11;

        //^PARÁMETROS OPCIONALES

        Console.WriteLine(Subtraction(value1,value2)); //llama a la segunda sobrecarga

        Console.WriteLine(Subtraction(value1,value2,value3)); //llama a la primera sobrecarga
        //? El parámetro opcional debe ir siempre luego de asignar los parámetros obligatorios
    } //~MAIN|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    static double Subtraction(int v1, double v2, double v3 = 0) => v1 - v2 - v3; //no es una sobrecarga
    static double Subtraction(int v1, double v2) => v1 - v2;
//----------------------------------------------------------------------------

        //^------AMBITO, ALCANCE Y SOBRECARGA DE METODOS-------------------
        //* La sobrecarga de métodos es la creación de varios métodos con el mismo nombre, pero con diferentes firmas y definiciones. Se utiliza el número y tipo de argumentos para seleccionar qué definición de método ejecutar.
        //!EXPRESSION-BODIED | nomeclatura abreviada
        // Expression body definitions let you provide a member's implementation in a very concise, readable form. You can use an expression body definition whenever the logic for any supported member, such as a method or property, consists of a single expression. An expression body definition has the following general syntax:
        static int Addition(int operator1, int operator2) => operator1 + operator2;

        static double Addition(int number1, double number2) => number1 + number2;

        static double Addition(double numero1, double numero2, double numero3, double numero4, double numero5) => numero1 + numero2 + numero3 + numero4 + numero5;

//----------------------------------------------------------------------------

        static void firstMethod()
        { //? AMBITO LOCAL
            int number1 = 4; 
            int number2 = 6;
            Console.WriteLine($"La suma de {number1} y {number2} es {number1+number2}. Este mensaje incluye un {MENSAJECONSTANTE}");
        }

        void secondMethod() => Console.WriteLine(numberGlobal1 + numberGlobal2);
        //No tiene que ser static (razon aun descnocida, tema de POO)

//----------------------------------------------------------------------------

        //!VARIABLES ACCESIBLES Y VISIBLES DESDE CUALQUIER MÉTODO
        //? CAMPOS DE CLASE
        //ámbito global
        int numberGlobal1 = 3;
        int numberGlobal2 = 7;
        const string MENSAJECONSTANTE = "MENSAJECONSTANTE";

//----------------------------------------------------------------------------

    }
}