namespace Inheritance_Builders_BaseIICs
{
  class Program
  {
    static void Main(string[] args)
    { 
      //creating staments
      Perro dogo = new Perro("Dogo");

      Gato bigotes = new Gato("Bigotes");

      //get, set call
      Console.WriteLine(dogo.NombreSerVivo);
      Console.WriteLine(bigotes.NombreSerVivo);


    }
  }
  class Mamiferos
  { //^ Las clases hijas llaman siempre al constructor padre
    private string nombreSerVivo;
    
    public Mamiferos(string nombre)
    {
      nombreSerVivo = nombre; //el string ingresado 
    } 
    public string NombreSerVivo
    {
      get => $"Nombre: {nombreSerVivo}";

      set
      {
        if (!string.IsNullOrEmpty(value))
        {
          nombreSerVivo = value;
        }
      }
    }
    public void Movimiento(){Console.WriteLine("Soy capaz de moverme");}
    public void CuidarCrias(){Console.WriteLine("CUIDO A MIS CRIAS");}
  }
//----------------------------------------------------------------  
//^ Las subclases tienen implícitamente una instrucción que no veiamos que era :base() esta instrucción llama al constructor de la clase padre por defecto
  class Perro : Mamiferos
  {
    public Perro(string nombrePerro) : base(nombrePerro)
    {
      //?el dato almacenado e.g. Perro dog = new Perro("Nombre del perro"). Viaja hasta la subclase Perro como parámetro para que luego almacenarse en base y llevarlo al constructor de la clase padre, es decir al parámetro nombre
    }
    public void Ladrido(){Console.WriteLine("Wof, wof");
    }
  }
//----------------------------------------------------------------  
  class Gato : Mamiferos
  {
    public Gato(string nombreGato) : base(nombreGato)
    {
    }
    public void Maullido(){Console.WriteLine("Miau");
    }
  }

}