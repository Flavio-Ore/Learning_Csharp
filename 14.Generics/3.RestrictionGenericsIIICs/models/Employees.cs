using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgGenericsIIICs.models
{
    //^Cualquier clase que no tenga salario nos dará un error, esto se logra a partir de la restricción
    public class Director : Empleados
    {
        public Director(double salario): 
            base(salario) 
        => _salario = salario;
    }
    public class Secretaria : Empleados
    {
        public Secretaria(double salario):
            base(salario) 
        => _salario = salario;
    }
    public class Electricista : Empleados
    {
        public Electricista(double salario):
            base(salario) 
        => _salario = salario; 
    }
}