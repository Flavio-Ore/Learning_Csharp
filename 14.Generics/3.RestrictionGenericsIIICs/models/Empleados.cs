using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgGenericsIIICs.models
{
    public class Empleados : IToEmployees
    {
        protected double _salario;
        public Empleados(double salario) => _salario = salario;
        public double SalarioEmpleado {get => _salario;}
    }
}