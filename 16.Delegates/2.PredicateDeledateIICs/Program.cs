using System;
using System.Collections.Generic;

namespace PredicateDeledateIICs
{
  class Program
  {
    //^Delegados predicados
    //Delegates that return a true or false value (methods)
    //Muy utilizados para filtrar listas de valores comprobando si una codición es cierta para un valor dado
    //Predicate<T> PredicateName = new Predicate<T>(DelegateFunction)

    static void Main(string[] args)
    {
      int[] numArray = new int[20];
      for (int i = 0; i < numArray.Length; i++)
        numArray[i] = i;
      
      List<int> numList = new List<int>();

      //AddRange adds the elements of the specified collection to the end of the list<T>
      numList.AddRange(numArray);

      foreach (int num in numList)
        Console.Write($"{num}, ");

      //state predicate delegate
      Predicate<int> PredDel = new Predicate<int>(IsPair);

    //Pares---------------------------------------------------------------
      Console.WriteLine("\nPares");
      
      //FindAll todos los pares y los almacena en una lista

      //FindAll() method. That returns a List<T> containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty List<T>.
      List<int> pairNumList = numList.FindAll(PredDel);

      foreach (int pairNum in pairNumList)
        Console.Write($"{pairNum}, ");

    //Impares---------------------------------------------------------------
      Console.WriteLine("\nImpares");

      PredDel = new Predicate<int>(IsOdd);

      List<int> oddNumList = numList.FindAll(PredDel);

      foreach (int oddNum in oddNumList)
        Console.Write($"{oddNum}, ");      

    //Primos-----------------------------------------------------------------
      Console.WriteLine("\nPrimos");  

      PredDel = new Predicate<int>(IsPrime);

      List<int> primeList = numList.FindAll(PredDel);
      
      foreach (int primeNum in primeList)
        Console.Write($"{primeNum}, ");

    //Usuarios-----------------------------------------------------------------
      Console.WriteLine("\nUsuarios"); 

      Usuario user1 = new Usuario();
      user1.Age = 14;
      user1.Name = "Steven";

      Usuario user2 = new Usuario();
      user2.Age = 51;
      user2.Name = "Stuart";

      Usuario user3 = new Usuario();
      user3.Age = 91;
      user3.Name = "Jhon";

      List<Usuario> usersList = new List<Usuario>();

      usersList.AddRange(new Usuario[] { user1, user2, user3 });

      //Are there users who are called...?
      Predicate<Usuario> UserFilter = new Predicate<Usuario>(IsThereThisUser);
      
      bool userExistProcess = usersList.Exists(UserFilter);

      if (userExistProcess)
          Console.WriteLine("This users exists");
      else
          Console.WriteLine("This users doesn't exists");

      //Are there adult users?  
      UserFilter = new Predicate<Usuario>(AdultUsers);

      bool adultProcess = usersList.Exists(UserFilter);

      if (adultProcess)
        Console.WriteLine("There are adults users");
      else
        Console.WriteLine("There are users under 18 years old");

    }

    //to prove determinaded user 
    static bool IsThereThisUser(Usuario user) => user.Name == "nameless";
    //to prove if user's age is greater than 18 years
    static bool AdultUsers(Usuario user) => user.Age > 17;

    //el número solo puede ser divisible por sí mismo, entonces es primo
    //https://andresledo.es/csharp/saber-si-un-numero-es-primo/
    static bool IsPrime(int num)
    {
      if (num < 2)
        return false;

      for (int i = 2; i < num; i++)
      {
        if((num % i) == 0)
          // No es primo :(
          return false;
      }
      // Es primo :)
      return true;
    }

    //si el residuo es 0 es par, filtra números pares
    static bool IsPair(int num) => num % 2 == 0;

    //si el residuo es  != 0 es impar, filtra número impares
    static bool IsOdd(int num) => num % 2 != 0;
  }

}