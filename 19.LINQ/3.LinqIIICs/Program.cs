using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIIICs
{
  class Program
  {
    static void Main(string[] args)
    {
      ControlEmpleadoEmpresa lima = new();

      Print("Empleados en las empresas de Lima");
      
      lima.listEmpleado.ForEach(delegate (Empleado employee)
      {
        Print(employee.GetEmployeeData);
      });

      Print("\nEmpresas en Lima");
      lima.listEmpresa.ForEach(delegate (Empresa company)
      {
        Print(company.GetCompanyData);
      });

      Print("\nEmpleados de la empresa index 1");
      //Empleados de la empresa ubicada en la lista  listEmpresa
      List<Empleado> lstEmpleadosLaUni = lima.GetEmpleadosFrom(lima.listEmpresa[1]);

      lstEmpleadosLaUni.ForEach(delegate(Empleado employee)
      {
        Print(employee.GetEmployeeData);
      });

      //Salario a partir de lo que ingrese el usuario
      try
      {
        int userInput = Convert.ToInt32(Console.ReadLine());
        lima.GetEmpleadosSalary(userInput).ForEach(delegate (Empleado employee)
        {
          Print(employee.GetEmployeeData);
        });
      }
      catch (Exception)
      {
        Print("Error: no se ha introducido un valor numérico. Invalid Id input.");
      }
  }
    static void Print(object _) => Console.WriteLine(_);
  }
}