using System;
namespace Heritage_II_ClassObject
{
  class Program
  {
    static void Main(string[] args)
    {
      //instanciando en base a clases hijas
      Gato Bigotes = new Gato();

      Humano Juanca = new Humano();

      //objetos que tienen todos los métodos y propiedades de la clase padre
      Bigotes.CuidarCrias(); //no puede pensasr

      Juanca.Pensar(); //no puede maullar

      //! Object siempre será una clase top, da métodos que cualquier clase puede usar      unInt.Equals();
      Object ola = new Object();

    }
    
  }
  
//-------------------------------------------------------
  //Decir que una clase nueva hereda de Object es absurdo.
  //& OBJECT ES UNA SUPERCLASE CÓSMICA (según libros)
  class Mamiferos : Object //Una clase simple, muy absurda
  { //? Object es la clase top de todas las clases que se creen.
     public void Respirar()
     {
       Console.WriteLine("Este animal puede respirar :o");
     }
     public void CuidarCrias()
     {
       Console.WriteLine("Cuido de mis crías hasta que mueran o se vayan");
     }
  }
  //gato hereda de Mamiferos
  class Gato : Mamiferos //como Mamiferos, dentro de Perro están los métodos Respirar() y CuidarCrias()
  {
    public void Maullar()
    {
      Console.WriteLine("MIAU, (soy un gato)");
      
    }
  }
  //humenao capaz de Respirar y cuidar crias
  class Humano : Mamiferos
  {
    public void Pensar()
    {
      Console.WriteLine("Pienso, luego existo");
      
    }
  }
}