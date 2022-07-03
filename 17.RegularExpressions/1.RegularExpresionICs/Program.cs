using System;
using System.Text.RegularExpressions;

//^Expresiones regulares
//Realizar tareas complejas ahorrando varias lineas de código//Secuencias de carácteres que funcionan como un patrón de búsqueda//Posibles escenarios: validación de formularios, búsquedas de ficherexternos, búsquedas en BBDD, comprobación de entradas de usuario, etc
//^Clases útiles:
//Regex , Match , MatchCollection , GroupCollection
//^Métodos útiles:
//Matches
//^Propiedades útiles
//Groups

//!The form of the method call (static, interpreted, compiled) affects performance if the same regular expression is used repeatedly in method calls, or if an application makes extensive use of regular expression objects.

string oracion = "Que tal me llamo Gonzalo Oré Chávez, tengo 22 años y número telefónico es +51 951 015 482";

string patron = @"\d{2}|\[ñ]"; //decimales de 2 digitos y encontrar ñ

var firstRegex = new Regex(patron);

var secondRegex = new Regex(@"\+51");

MatchCollection theMatch = firstRegex.Matches(oracion);

if (theMatch.Count > 0)
  Console.WriteLine("Se encontró");
else
  Console.WriteLine("No hay");

MatchCollection theMatchCollection = secondRegex.Matches(oracion);

if (theMatchCollection.Count > 0)
  Console.WriteLine("Se encontró");
else
  Console.WriteLine("No hay");

//------------------------------------------------------------------------------

string hayDecimals = "Hay numeros como 123123 y 0909";

MatchCollection tmc = Regex.Matches(hayDecimals, @"\d");

foreach (Match match in tmc)
{
  Console.Write(match.Value);
}
//Para generarlas, está el link: https://regex-generator.olafneumann.org/?sampleText=Hay%20numeros%20como%20123123%20y%200909&flags=i&onlyPatterns=false&matchWholeLine=false&selection=