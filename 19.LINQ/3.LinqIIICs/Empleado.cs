using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIIICs
{
    public class Empleado
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //clave foráneo
        public int CompanyId { get; set; }

        public string GetEmployeeData { get => $"Empleado {Name}, Id: {Id}, Age: {Age}, Salary: {Salary}, CompanyId: {CompanyId}, Position: {Position}"; }
  }
}