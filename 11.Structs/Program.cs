using System;
namespace Structs
{
  class Program
  {
    //^Diferencias entre structs y classes
    // Struct:
    //No permite la declaración de constructor por defecto
    //El compilador no inicia los campos. Puedes iniciarlos en el constructor
    //No puede haber sobrecarga de constructores
    //No heredan de otras clases pero si implementan interfaces
    //Son selladas (sealed)

    //^Cuando usar Struct
    //Cuando necesitas trabajar con una cantidad elevada de datos en memoria (representación de primitivos, números complejos, puntos tridimiensionales, etc)
    //Cuando las instancias no deban cambiar (inmutables)
    //Cuando la instancia tenga tamaño inferior a 16 bytes
    //Cuando no necesites convertir a objeto (boxed)
    //Por razones de rendimiento

    //^Stack Heap
    //stack es una memoria del tipo Last In First Out, lo primero que se almacenó sale de la memoria cuando no se necesita para dejar entrar a lo último. La información en el Heap se almacenan y están disponibles durante toda la ejecución del programa
    static void Main(string[] args)
    {
      Empleado empleadoUno = new Empleado(1000, 100);

      Console.WriteLine(empleadoUno);
      
      //!el método no modificará los valores del struct
      //porque está en la pila del stack, no en el heap. al declarar un objeto del struct, se crea una copia y los cambios se hacen en la copia del struct, NO en el struct original.
      //? por eso no modifica los datos el método CambiaSalario
      Empleado.CambiaSalario(empleadoUno, 600);  

      Console.WriteLine(empleadoUno);

    }
  }
  public struct Empleado
  {
    //field
    public double SalarioBase, Comision;
    
    //constructor
    public Empleado(int salarioBase, int comision)
    {
      this.SalarioBase = salarioBase;
      this.Comision = comision;
    }

    //method
    //? To string returna el dato que querramos con solo mencionar el objeto creado a partir de esta clase sin utilizar get,set o algún otro método.
    public override string ToString() => string.Format($"Salario y comisión del empleado: {this.SalarioBase}, {this.Comision}");

    //este método funcionará, pero los cambios hechos no modificaran al struct original
    public static void CambiaSalario(Empleado empleado, double incremento)
    {
      empleado.SalarioBase += incremento;
      empleado.Comision    += incremento;
    }
  }
  
}