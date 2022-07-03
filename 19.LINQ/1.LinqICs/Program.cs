//^Languaje INtegrated Query
//Lenguaje de consulta integrado
//Guarda y consulta datos dediferentes orígenes de datos
//El programador realiza una consulta de datos a través de LINQ y obtiene acceso a los mismos
//!Datos de:
//Colecciones de objetos
//XML
//SQL BBDD
//Entidades
//Recordset
//Otras estructuras

//^Lo que trae LINQ
//Uniformidad en lenguajes de consulta
//Reducción de código
//Código más legible

//^API LINQ (IEnumerable | IQueryable)
//!Enumerable | Queryable

using System;
using System.Collections.Generic;
using System.Linq; 

int[] ints1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 0 };

List<int> pairInts1 = new List<int>();

IEnumerable<int> pairInts2 = 
  from i in ints1 
  where i % 2 == 0 
  select i;

foreach (int item in pairInts1)
{
  Console.WriteLine(item);
}