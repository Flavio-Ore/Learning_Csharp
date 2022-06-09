using System;
//! Se debe hacer una jerarquia...
//un gato es siempre un perro?       ...no
//un mamífero es siempre un perro?   ...no, puede ser un gato, un tigre, etc
//un perro es siempre un mamífero?   ...sí, puede ser un mamífero, pero no gato
namespace Substitution_principleIIICs //^Es siempre un...?
{
  class Program
  {
    static void Main(string[] args)
    {
    //----------------------------------------------------------------

      Perro dog1 = new Perro("Pepito");
      dog1.Ladrar();
      dog1.GetAnimalInfo();
      
      Gato cat1 = new Gato("Bigotin");
      cat1.Maullar();
      cat1.GetAnimalInfo();
      
    //----------------------------------------------------------------
      //Al usar el principio de substitución
      
      Perro perro = new Perro("Gon");
      Mamifero animal = new Mamifero("Rodolfo");
      animal = perro;

      perro.Ladrar();

      //perroMamifero es de tipo Mamifero y no Perro
      Mamifero perroMamifero = new Perro("Perro Mamifero");
      Mamifero caballoMamifero = new Caballo("Caballo que solo tiene clase la infomación de la clase Mamifero");

      //! No tiene su método Galopar, Maullar y Ladrar
      //es de tipo Mamífero y solo puede usar sus instrucciones correspondiente a esa super clase
      perroMamifero.GetAnimalInfo();
      caballoMamifero.GetAnimalInfo();

    //----------------------------------------------------------------
      //aplicando principio de substitución usando instancia creadas anteriormente

      Mamifero animal1 = new Mamifero("Gato");
      Gato egipcio = new Gato("Egipcio");

      //un mamífero no siempre es un gato | egipcio = animal; error

      //!un Gato es SIEMPRE un mamifero
      animal1 = egipcio;

      egipcio.Maullar(); //puede usar el método correspondiente al hijo Gato
      animal.GetAnimalInfo(); //output: Name: Egipcio

    //----------------------------------------------------------------

    //todo es un objeto
      Object miAnimalito = new Caballo("CABALLO");
      Object miGato = new Gato("GATO");
      Object miPerro = new Perro("PERRO");

    //----------------------------------------------------------------
      //creando un array donde almacenan los objetos de tipo caballo, gato, perro

      //instanciando las clases
      Perro dog2 = new Perro("Perro array");
      Gato gato2 = new Gato("Gato array");
      Caballo caballo2 = new Caballo("Caballo array");

      //array de tipo mamifero
      Mamifero[] arrayAnimals = new Mamifero[3];

      //asignando posicion
      arrayAnimals[0] = dog2;
      arrayAnimals[1] = gato2;
      arrayAnimals[2] = caballo2;

      //ver el  contenido de que cada elemento
      for (int i = 0; i < arrayAnimals.Length; i++)
      {
        Console.Write($"El mamifero {i} | ");
        arrayAnimals[i].GetAnimalInfo();
      }

    }
  }
  class Mamifero
  {
    //fields
    private string name;

    //constructor
    public Mamifero(string name)
    {
      this.name = name;
    }

    //methods
    public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que mueran");
    public void Resprirar() => Console.WriteLine("Soy capaz de respirar");

    //getters and setters
    //?old get
    public void GetAnimalInfo() => Console.WriteLine($"Name: {name}");
  }
  class Perro : Mamifero
  {
    public Perro(string dogName) : base(dogName)
    {
      
    }
    public void Ladrar() => Console.WriteLine("Wof,Wof");
  }
  class Gato : Mamifero
  {
    public Gato(string catName) : base(catName)
    {
      //?this.name = catName;
    }
    public void Maullar() => Console.WriteLine("Miauuuu");
      
  }
  class Caballo : Mamifero
  {
    public Caballo(string horseName) : base(horseName)
    {
      //?this.name = horseName;
    }
    public void Galopar() => Console.WriteLine("Taran, taran, taran");
  }
}