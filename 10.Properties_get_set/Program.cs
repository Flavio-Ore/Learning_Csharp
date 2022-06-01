using System;
namespace Properties_get_set
{
  class Program
  {
    static void Main(string[] args)
    {
      GetSet test = new GetSet("PRUEBA", -10);
      Console.WriteLine(test.Edad);
      
      test.Edad = -1212;
      Console.WriteLine(test.Edad);

      test.Edad = 25;
      Console.WriteLine(test.Edad);
    }

  }

  class GetSet
  {
    //por convencion los private o internal fields inician con _
    private string _name;
    private int _edad;

    public string Name
    {get => _name;} //visual studio no muestra el nombre real de la variable al colocar el prefijo "_" en "name"
    
    //tanto get como set modificables
    public int Edad
    {
      get => this._edad; 
      set
      {
        if (value < 0 )
          this._edad = 0;
        else
          this._edad = value;
      }
    }

    public GetSet(string name, int edad)
    {
      if (edad < 0)
        this._edad = 0;  
      else
        this._edad = edad;
      
      this._name = name;
    }
  }

}