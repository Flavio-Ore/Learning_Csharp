using System;
//* CONSTRUCTORES
namespace Builders
{
  class Program
  {
    static void Main(string[] args)
    {

      Coche cocheUno = new Coche(); //crear objeto/instancia de tipo Coche
      //dar un etado inicial a nuestro coche

      Coche cocheDos = new Coche();

      //nomenclatura del punto

      //!Accediedo a las propiedades de la clase a través de un método de acceso

      //solo obtener la propiedad wheel
      Console.WriteLine(cocheUno.GetWheel()); 
      //obtener la información de las propidades de Coche
      Console.WriteLine(cocheUno.GetInfoCoche());
      
      Console.WriteLine(cocheDos.GetInfoCoche());

      //creando un tercer coche con diferentes propiedades
      Coche cocheTres = new Coche(5000.95d, 1800.35);
      //información modificada a comparación de los demás coches
      Console.WriteLine(cocheTres.GetInfoCoche());
      
    }

  }

  class Coche
  { 
    //un método con mismo nombre de la clase, no devuelve ningun valor
    public Coche()
    { //definir un estado inicial 
      wheel = 4;

      height = 2300.5;

      width = 0.800;
    }
    //sobrecarga de constructores
    public Coche(double heightCoche, double widthCoche)
    {
      wheel = 4;

      height = heightCoche;

      width = widthCoche;
    }
    //Imprime las propiedades de la clase Coche
    public String GetInfoCoche()
    {
      return $"Information about the Coche: \n Wheels: {wheel}\n Height: {height}\n Width: {width}\n ";
    }
    //obtener el valor de la propiedad wheel
    public int GetWheel()
    {
      return wheel;
    }
    //inicializando propiedades y funciones del Coche
    private int wheel;
    private double height;
    private double width;
    //private bool climateControl;
    //private String upholstery;
    
  }


}