namespace MetodosCs
{
/* 
~TipoDeMetodo nombreMetodo (parámetros) {
~    contenido del método
~} 
~Cuando un método es extensamente largo, al punto de tener que hacer scroll, es entonces que el método esta mal organizado. Sus programas deben dividirse en pequeñas partes. MODULARIZACIÓN.
*/

//! TODOS LOS MÉTODOS IRÁN DENTRO DE UNA CLASE
// SE ESPECIFICA EL TIPO DEVUELTO Y PARÁMETROS

    class Program //~|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    { //~METODOS FUERA DE MAIN ↓ ↓ ↓
    static void metodoFueraDelMetodoMain() => Console.WriteLine("Estoy fuera del metodo Main y he sido llamado dentro del mismo");

    static void sumaFueraDelMain(int num1 , int num2) => Console.WriteLine($"La suma de ambos números da como resultado {num1+num2}");

        static void Main(string[] args)  //~||||||||||||||||||||||||||||||||||||
        {
//!===========================================================================
//? PARÁMETROS---------------------------------------------------------------
        sumaFueraDelMain(10,90); //?llamado por valor o referencia?

//? MÉTODOS Y FUNCIONES SON LO MISMO EN C#-----------------------------------

        int sumaDeEnteros (int a, int b) { //return un int y sus parámetros son un int
            //^Si no hay return, da error de compilación
            int result = a+b;
            return result; 
//*Cuando hay un return, devuelve el flujo de ejecución a la llamada. Es decir, en cuanto el código encuentre un return, se sale del método y devuelve el flujo de ejecución (el return). return; es mala práctica
        };

        sumaDeEnteros(2,3); //llamado con Console o no return

//--------------------------------------------------------------------------

        double divisionDeDoubleInt (int uno, double dos) => uno/dos;
            //^Con double, sea la division que sea, aceptara los numeros decimales
            //? Cuando es una sola linea a ejecutar, se usar la flecha
        Console.WriteLine(divisionDeDoubleInt(10,2.5));

//--------------------------------------------------------------------------

        void sumaSinReturn(int num1, int num2) {
            //^un método void (vacio), jamás llevará return
            int suma = num1+num2;
            Console.WriteLine(suma);
        };
        
        sumaSinReturn(5, 10);

//!===========================================================================

//?declaracion y llamada de void method--------------------------------------
        /*
        Todos los programas deben llevar un método Main, lleva void y la palabra reservada static que es de POO.
        static void Main(string[] args)
        {
            Console.WriteLine("Hola comentario");
        }
        */
//--------------------------------------------------------------------------
        //? Si el método no es static fuera del método Main, entonces no podrá encontrarla. Si es STATIC, la buscará por TODO EL BLOQUE DE LA APLICACIÓN

        metodoFueraDelMetodoMain(); //llamado a method fuera de main

        voidStaticMethod(); 
        
        Console.WriteLine("Mensaje luego del llamada al void static method");
        
        Console.WriteLine(otraDivision(10,5));
        //? Al correr el programa, lee el nombre de este método y busca ese método, si existe lo encuentra y ejecuta TODO su contenido, una vez lo ejecuta, reanudará la ejecución

//--------------------------------------------------------------------------
        } // ~ENDPOINT static void Main(string[] args) ||||||||||||||||||||||||
        
        static double otraDivision(double number1, double number2) => number1/number2;
//--------------------------------------------------------------------------
        static void voidStaticMethod() //Tiene una referencia
        //* Este método void está fuera del metodo Main
        //& método static diferente del método Main
        {

        Console.WriteLine("Este mensaje aparece porque al llamarla, previamente verificó si existe esa función para luego ejecutarla desde la posición en la que se encuentra");

        Console.WriteLine("Esta línea de código se ejecuatará segundo dentro de la funcion voidStaticMethod sin irrumpir al código Console.WriteLine(Mensaje luego del llamada al void static method)");
//--------------------------------------------------------------------------
        }

    } // ~ENDPOINT class Program |||||||||||||||||||||||||||||||||||||||||||||||
    
} // ~ |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||