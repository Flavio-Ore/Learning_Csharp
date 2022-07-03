using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIICs
{
    public class Empleado
    {
        private string _name;
        private int _age;
        public string Name { get => this._name; }
        public int Age { get => this._age; }
        public int CompanyId { get; set; }

        public Empleado(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}