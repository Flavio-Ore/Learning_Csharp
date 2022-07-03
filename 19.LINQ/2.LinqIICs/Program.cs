//Crear 2 objetos, empresas y empleados, cada uno con sus propiedades
//Cada empleado pertenece a una empresa
//Obtener información mediante LINQ

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIICs
{
  class Program
  {
    static void Main(string[] args)
    {
      var listEmpleados1 = new List<Empleado>(7);

      var listEmpleados2 = new List<Empleado>(4);

      //listEmpleados1
      for (int i = 0; i < listEmpleados1.Capacity; i++)
        listEmpleados1.Add(new Empleado($"Nombre{i*2}", i*2));
      

      //listEmpleados2
      var p1 = new Empleado("Pepe", 19);
      var p2 = new Empleado("Steven", 22);
      var p3 = new Empleado("Rosa", 23);
      var p4 = new Empleado("Junior", 38);

      listEmpleados2.Add(p1);
      listEmpleados2.Add(p2);
      listEmpleados2.Add(p3);
      listEmpleados2.Add(p4);

      //Empresas deStuart stevenCorp
      var deStuart = new Empresa(listEmpleados1, "DeStuart");

      var stevenCorp = new Empresa(listEmpleados2, "StevenCorp");

      IEnumerable<Empleado> sortEmpleadosdeStuart = 
        from employee in deStuart.Employees 
        select employee;

      Print(sortEmpleadosdeStuart);

      foreach (Empleado employee in sortEmpleadosdeStuart)
        Println($"{employee.Name}, {employee.Age}, id: {employee.CompanyId} | ");

      Console.WriteLine("\n");
      //EmpleadoEmpresa Id

      //id 0
      Print(deStuart.Id);

      Print(deStuart.Employees.First().CompanyId);
      Print(deStuart.Employees.Last().CompanyId);

      //id 1
      Print(stevenCorp.Id);

      Print(stevenCorp.Employees.First().CompanyId);
      Print(stevenCorp.Employees.Last().CompanyId);

      var listEmpleados3 = new List<Empleado>(2);

      var em1 = new Empleado("PepitoAmarillo", 22);
      var em2 = new Empleado("maria", 23);

      listEmpleados3.Add(em1);
      listEmpleados3.Add(em2);

      var empresaExtra = new Empresa(listEmpleados3, "EmpresaExtra");

      //id 2
      Print(empresaExtra.Id);

      Print(empresaExtra.Employees.First().CompanyId);
      Print(empresaExtra.Employees.Last().CompanyId);
      
      Console.WriteLine();
      //Buscando a través de Id

      var totalEmpleados = new List<Empleado>();
      totalEmpleados.AddRange(deStuart.Employees);
      totalEmpleados.AddRange(stevenCorp.Employees);
      totalEmpleados.AddRange(empresaExtra.Employees);

      foreach (Empleado employee in totalEmpleados)
        Println($"Name: {employee.Name}, Age: {employee.Age}, id: {employee.CompanyId} | ");

      Console.WriteLine("\n");

      //Success message
      foreach (Empleado employee in SortEmpleadosListIdCompany(0, totalEmpleados))
        Println($"{employee.Name}, {employee.Age} id: {employee.CompanyId}. | ");

      Console.WriteLine("\n");

      //Error message
      foreach (Empleado employee in SortEmpleadosListIdCompany(5, totalEmpleados))
        Println($"{employee.Name}, {employee.Age} id: {employee.CompanyId}. | ");

      Console.WriteLine("\n");

      //Error message
      foreach (Empleado employee in SortEmpleadosListIdCompany(-10, totalEmpleados))
        Println($"{employee.Name}, {employee.Age} id: {employee.CompanyId}. | ");
    }

    //other-methods----------------------------------------------------------------------------
    
    static List<Empleado> SortEmpleadosListIdCompany(int id, List<Empleado> employees)
    {
      var empleados = new List<Empleado>();

      IEnumerable<Empleado> theId =
        from employee in employees
        where employee.CompanyId == id
        select employee;

      if ((id >= 0) && (theId.Count() == empleados.Count))
      {
        empleados.Add(new Empleado("UNDEFINED", 404) { CompanyId = 404 });
        return empleados;
      }
      else if ((id >= 0))
      {
        foreach (Empleado employee in theId)
        {
          empleados.Add(employee);
        }
        return empleados;
      }
      else
      {
        empleados.Add(new Empleado("UNDEFINED", 404) { CompanyId = 404 });
        return empleados;
      }
    }
    static void Print(object _)
    {
      Console.WriteLine(_);  
    }
    static void Println(object _)
    {
      Console.Write(_);  
    }
  }
}