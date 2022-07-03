using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIIICs
{
    public class ControlEmpleadoEmpresa
    {
      public List<Empleado> listEmpleado;
      public List<Empresa> listEmpresa;
      
      public ControlEmpleadoEmpresa()
      {
        listEmpleado = new List<Empleado>();
        listEmpresa = new List<Empresa>();

        listEmpresa.Add(new Empresa { Id = 1, Name = "ThePePe"});
        listEmpresa.Add(new Empresa { Id = 2, Name = "LaUni"});

        listEmpleado.Add(new Empleado { CompanyId = 2, Id = 1, Name = "Pepito", Age = 32, Position = "Co-Gerente", Salary = 4000 });

        listEmpleado.Add(new Empleado { CompanyId = 2, Id = 2, Name = "Rosa", Age = 26, Position = "Gerente", Salary = 4600 });

        listEmpleado.Add(new Empleado { CompanyId = 1, Id = 3, Name = "Steven", Age = 35, Position = "Gerente", Salary = 6000 });

        listEmpleado.Add(new Empleado { CompanyId = 1, Id = 4, Name = "Stuart", Age = 23, Position = "Developer", Salary = 1800 });
        
        listEmpleado.Add(new Empleado { CompanyId = 2, Id = 5, Name = "Maria", Age = 40, Position = "Marketing", Salary = 2100 });
      }
      public List<Empleado> GetEmpleadosFrom(Empresa corp)
      {
        var employeesIds = new List<Empleado>();

        IEnumerable<Empleado> employeeCompany =
          from employee in listEmpleado 
          join company in listEmpresa
          on employee.CompanyId equals corp.Id
          where company.Name == corp.Name
          select employee;

        employeesIds.AddRange(employeeCompany);

        return employeesIds;
      }

      public List<Empleado> GetEmpleadosSalary(int salary)
      {
        var empSalaries = new List<Empleado>();

        IEnumerable<Empleado> employeesSalary = 
          from employee in listEmpleado
          where employee.Salary == salary
          select employee;

        empSalaries.AddRange(employeesSalary);

        return empSalaries;
      }

      public List<Empleado> GetListGerente()
      {
        var gerentes = new List<Empleado>();

        IEnumerable<Empleado> positionGerentes = 
          from employee in listEmpleado
          where employee.Position == "Gerente"
          select employee;

        gerentes.AddRange(positionGerentes);

        return gerentes;
      }
    }
}