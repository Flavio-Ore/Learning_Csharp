using System;
//* GETTERS AND SETTERS | .this | partial
namespace get_set_this_partial
{
  class Program
  {
    static void Main(string[] args)
    {
      Coche cocheUno = new Coche(3500.55, 1300.98);

      Console.WriteLine(cocheUno);

      //propiedades por default del coche nuevo
      Console.WriteLine(cocheUno.GetPropertiesCoche());

      Console.WriteLine(cocheUno.getExtras()); 

      //extras por default del coche nuevo
      cocheUno.setExtras(true, "cuero");

      Console.WriteLine(cocheUno.getExtras());  
    }

  }
//^Dividiendo la clase en trozos con partial
  partial class Coche //DEFINE THE INITIAL STATEMENT
  { 
    public Coche()
    {
      wheel = 4;

      height = 2300.5;

      width = 0.800;

      upholstery = "tela";
    }
    //sobrecarga de constructores
    public Coche(double heightCoche, double widthCoche)
    {
      wheel = 4;

      height = heightCoche;

      width = widthCoche;

      upholstery = "tela";      
    }
  }
  partial class Coche //SETTERS, GETTERS
  {
    //método setter no devuelven información, la crean
    public void setExtras(bool climateControl, String upholstery)
    {
      this.climateControl = climateControl;
      //!.this HACE REFERENCIA AL CAMPO DE CLASE
      this.upholstery = upholstery;
    }
    //método getter devuelve informacion
    public String getExtras() => $"Extras del coche: \n Tapiceria: {upholstery} \n Climatizador: {climateControl} \n";
    
    //Imprime las propiedades de la clase Coche
    public String GetPropertiesCoche()
    {
      return $"Information about the Coche: \n Wheels: {wheel}\n Height: {height}\n Width: {width}\n ";
    }
  }
  partial class Coche //ROOT PROTERTIES
  {
    //inicializando propiedades y funciones del Coche. Campo de clase
    private int wheel; //4
    private double height, width; //centimeters
    private bool climateControl; //false
    private String upholstery; //void string

  }

}