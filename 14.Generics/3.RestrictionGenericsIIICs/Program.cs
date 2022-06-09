using System;
using EgGenericsIIICs.models;

namespace EgGenericsIIICs
{
  //!Estudiante no es un empleado
  class Estudiante
  {
    //fields
    private double _edad;
    
    //constructor
    public Estudiante (double edad) => _edad = edad;

    //Implement
    public double Edad {get => _edad;}
  }

  class Program
  {
    static void Main(string[] args)
    {
      AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(3);

      directores.AgregarEmpleadosSalario(new Director(5400));
      directores.AgregarEmpleadosSalario(new Director(4900));
      directores.AgregarEmpleadosSalario(new Director(8000));

      directores.GetAllSalario();//de los agregados arriba solo tipo directores 

    //--------------------------------------------------------------------------

      Director director1 = new Director(5600.50);
      Electricista electricista1 = new Electricista(2200);
      Secretaria secretaria1 = new Secretaria(1600);
      
      Console.WriteLine(director1.SalarioEmpleado);

    //--------------------------------------------------------------------------

      AlmacenEmpleados<Empleados> salarioDeEmpleados = 
        new AlmacenEmpleados<Empleados>(3); //alamacenar 3 tipos de empleados
      
      //3 elements, every kind of Employee in Employees.cs
      salarioDeEmpleados.AgregarEmpleadosSalario(new Electricista(2400));
      salarioDeEmpleados.AgregarEmpleadosSalario(new Secretaria(1600));
      salarioDeEmpleados.AgregarEmpleadosSalario(new Director(4121));

      //printting
      salarioDeEmpleados.GetAllSalario();//de los agregados arriba, imprime a todos los objetos que son subclases pertenecientes al tipo Empleados

      Console.WriteLine(salarioDeEmpleados.GetEmployeeClassByIndex(2));


    //!Con los genéricos, VStudio marca error al objeto
      //La clase Estudiante no implementa la interfaz IToEmployees
      //^AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(2);
      
      //Almacenaría su edad, pero no salario, porque no poseen salario
      //^estudiantes.AgregarEmpleadosSalario(new Estudiante(13)); 
      


    }
  }

}