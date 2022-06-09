using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesICs
{
//^Crear un delegado que delegará su tarea en los métodos Greeting and Farewell aún estando en clases diferentes.
    public class WelcomeMsg
    {

        public static void Greeting() => Console.WriteLine("Hello there");

        public static string Args(string word) => $"This is an Method with args: {word}";

    }
    
    public class ByeMsg
    {
        public static void Farewell() => Console.WriteLine("Goodbye");

        public static string Args(string word) => $"User msg: {word}";
    }
}