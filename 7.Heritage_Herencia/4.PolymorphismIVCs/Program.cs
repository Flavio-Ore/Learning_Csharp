using System;

namespace IV_Polymorphism
{
//-----------------------------------------------------------------------------
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
    //&Cualquier animal puede llegar a pensar aparte de los humanos
    //!por lo que, si todos los mamíferos son capaces de pensar, entonces se debe declarar ese método como uno virtual, ya que TODAS LAS CLASES deberan heredar ese método Pensar, pero modificado en Humano, Perro, etc, PERO DEBE ESTAR PRESENTE!
    public virtual void Pensar() => Console.WriteLine("Pensamiento básico instintivo");
    
    public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que mueran");

    public void Resprirar() => Console.WriteLine("Soy capaz de respirar");

    //getters and setters
    //?old get
    public void GetAnimalInfo() => Console.WriteLine($"Name: {name}");
  }
//-----------------------------------------------------------------------------
  class Humano : Mamifero
  {
    public Humano(string humanoName) : base(humanoName)
    {
      //?this.name = dogName;
    }
    //! El error es debido a que ya exite un método en la clase padre, que devuelve el mismo tipo de dato y recibe el mismo tipo de parámetro. Lo que hace el método Pensar de humano es ocultar, invalidar el método Pensar de Mamifero
    //! Este método NO MODIFICA al de la clase padre, se trata de un método !=
    public void Pensar() => Console.WriteLine("Ser o no ser");
  }
//-----------------------------------------------------------------------------
  class Perro : Mamifero
  {
    public Perro(string dogName) : base(dogName)
    {
      //?this.name = dogName;
    }
    //!Hay diferentes razas de perros capaz de tener un pensamiento más avanzado, entonces CREAMOS un método Pensar especial para esa raza de perro
    //! Palabra new para ignorar la adverencia de V.S. porque nuestra intención es IGNORAR el método de la clase padre (Mamifero)
    new public void Pensar() => Console.WriteLine("Pensamiento de protección a su amo");
    
    public void Ladrar() => Console.WriteLine("Wof,Wof");
  }
//-----------------------------------------------------------------------------
  class Gato : Mamifero
  {
    public Gato(string catName) : base(catName)
    {
      //?this.name = catName;
    }
    
    //!Al indicar un método virtual, entonces debemos hacer que las clases hijas que tengan ese método pero modificado a su gusto, 
    public override void Pensar() => Console.WriteLine("Le pido a mi amo que me alimente y lo hago feliz!");

    public void Maullar() => Console.WriteLine("Miauuuu");
      
  }
//-----------------------------------------------------------------------------
  class Caballo : Mamifero
  {
    public Caballo(string horseName) : base(horseName)
    {
      //?this.name = horseName;
    }
    public void Galopar() => Console.WriteLine("Taran, taran, taran");
  }
//-----------------------------------------------------------------------------
  class Program
  {
    public static void Main(string[] args)
    {
      //creando un array donde almacenan los objetos de tipo caballo, gato, perro

      //instanciando las clases
      Perro dog2 = new Perro("Perro array");
      Gato gato2 = new Gato("Gato array");
      Caballo caballo2 = new Caballo("Caballo array");
      Humano primerHumano = new Humano("Humano array");

      //array de tipo mamifero
      Mamifero[] arrayAnimals = new Mamifero[4];

      //asignando posicion
      //? Heredado de sus objectos (Perro, Gato, Humano)
      arrayAnimals[0] = primerHumano; //func Pensar "ser o no ser"
      arrayAnimals[1] = dog2; //func Pensar "pesamiento de protección a su amo"
      arrayAnimals[2] = gato2; //func Pensar "Le pido a amo que me alimente"
      //? Heredado de Mamifero
      arrayAnimals[3] = caballo2; //func Pensar "básico instintivo"

      //ver el PENSAMIENTO de que cada elemento
      for (int i = 0; i < arrayAnimals.Length; i++)
      {
        arrayAnimals[i].Pensar();
      }

    }
  }
//-----------------------------------------------------------------------------
}