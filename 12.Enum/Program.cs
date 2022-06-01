namespace Enum
{
  //^Enums para almacenar un conjunto de constantes con nombre
  //Se coloca por convención, en el namespace
  enum Estaciones {Primavera, Verano, Otonio, Invierno} //4 Constantes
  //Por defecto los valores son de tipo Int
  class Program
  {
    static void Main(string[] args)
    {
      Estaciones test = new Estaciones(); 
      Console.WriteLine(test); //Output: Primavera
      
      Estaciones verano = Estaciones.Verano;
      //!no es un string
      Console.WriteLine(verano); //output: Verano      

      //!para que sea string
      Estaciones estacion = Estaciones.Otonio; //primero declaramos
      Console.WriteLine(estacion); //no string
      
      string stringEstacion = estacion.ToString();
      Console.WriteLine(stringEstacion); //string
      
      Estaciones? otraAlergia = null; //?para tipos enumerados para valores null
      Console.WriteLine(otraAlergia.ToString()); //output: "void"

      Estaciones alergia = Estaciones.Primavera;
      Console.WriteLine(alergia.ToString()); //Output: Primavera

    //-------------------------------------------------------------------------

      //^Ejemplo

      //bonus para empleados
      Bonus Gon = Bonus.Normal;
      
      //para imprimir el valor de Bonus.Normal
      double bonusGon = (double)Gon;

      //sumarle el bonus al salario
      double salarioGon = 1400 + bonusGon;

      Console.WriteLine(Gon);        // Normal
      Console.WriteLine(bonusGon);   // 250
      Console.WriteLine(salarioGon); //1650

    //-------------------------------------------------------------------------

      //^Ejemplo empleado
      //como parámetro tipo Bonus es Bonus. y luego double
      Empleado gon = new Empleado(Bonus.Bueno, 1400);

      Console.WriteLine(gon.InfoEmpleado());

      gon.BonusEmpleado = Bonus.Extra;
      Console.WriteLine(gon.BonusEmpleado);

      gon.SalarioEmpleado = 2000;
      Console.WriteLine(gon.SalarioEmpleado);

      Console.WriteLine(gon.InfoEmpleado());
    }
  }
  enum Bonus{Bajo = 100, Normal = 250, Bueno = 400, Extra = 500}
  class Empleado
  {
    private double _salarioEmpleado;
    private Bonus _bonusEmpleado;

    public Empleado(Bonus bonusEmpleado, double salarioEmpleado)
    {
      this._bonusEmpleado = bonusEmpleado;
      this._salarioEmpleado = salarioEmpleado;
    }

    public string InfoEmpleado()
    {
      return $"El empleado tiene un bonus {_bonusEmpleado} equivalente a {(double)_bonusEmpleado}, un salario {_salarioEmpleado}. Con el bonus tiene {(double)_bonusEmpleado + _salarioEmpleado} para este mes";
    }

    public double SalarioEmpleado
    {
      get => this._salarioEmpleado;
      set
      {
        if (value < 1080)
          _salarioEmpleado = 1080;
        else 
          _salarioEmpleado = value;
      }
    }
    public Bonus BonusEmpleado
    {
      get => this._bonusEmpleado;
      set => _bonusEmpleado = value;
    }


  }
}