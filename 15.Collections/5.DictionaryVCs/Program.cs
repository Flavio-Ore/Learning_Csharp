using System;
using System.Collections.Generic;

namespace DictionaryVCs
{
  class Program
  {
    //^Dictionary (diccionarios)
    //En una colección, se van agregando elementos, pero esta vez piden Add(Tkey, Tvalue). Una clave y un valor
    //Cada elemento dentro de esta colección, tiene un valor determinado, está identificado con una clave, de forma única, las claves no se pueden repetir
    //Como para manejar información de BBDD
    //!Consumen más recursos que cualquier otra colección
    //Al recorrer sus elementos, nos retornan un elemento con clave y un valor
    
    static void Main(string[] args)
    {
      Dictionary<string, int> dictio = new Dictionary<string, int>();
      Dictionary<int, string> otherDictio = new Dictionary<int, string>();
      //adding elements in the diccionary
      try
      {
        //dictio
        for (int i = 95; i >= 90; i--)
        {dictio.Add($"name{i}", i);}

        //otherDictio
        for (int i = 0; i < 7; i++)
        {otherDictio[i] = $"{i}name";}

      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);        
      }
      finally
      {
        Console.WriteLine("dictio Dictionary");        
        //Looking at the keys and value of each key
        foreach (string key in dictio.Keys)
        {Console.WriteLine(key);} //strings "name95"...

        foreach (int value in dictio.Values)
        {Console.WriteLine(value);} //ints 95...

        //Looking at the values and keys in the dictio
        foreach (KeyValuePair<string, int> name in dictio)
        {Console.WriteLine($"Name: {name.Key} | Age: {name.Value}");}

      //----------------------------------------------------------------

        Console.WriteLine("\notherDictio Dictionary");

        //Looking at the values and keys in the otherDictio
        foreach(KeyValuePair<int, string> element in otherDictio)
        {Console.WriteLine($"Number: {element.Key} | Name: {element.Value}");}
      
      //----------------------------------------------------------------

        Console.WriteLine("TrimExcess method ");
        //This method can be used to minimize memory overhead once it is known that no new elements will be added to the dictionary. To allocate a minimum size storage array, execute the following statements:
        dictio.Clear();
        dictio.TrimExcess();
      }

    }
  }
}