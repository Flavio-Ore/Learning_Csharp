using System;

namespace EgInterfacesIIICs
{
  class Program
  {
    public static void Main(string[] args)
    {
      Usuario one = new Usuario("AdolfxD121", 123);

      Console.WriteLine(one.Name);

      Moderador two = new Moderador("stevan", 321, "El rey");

      Console.WriteLine(two.UserInfo);

      //Como la clase Moderador hereda también de la interfaz IUserLocation, podemos usar el principio de substitución
      IUserLocation Itwo = two;
            
      Itwo.Location("text1", "text2", "text3");

      Console.WriteLine(two.Location("Lima Metropolitana", "Lima", "Perú"));
      
    }
  }
}