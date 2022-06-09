using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredicateDeledateIICs
{
    public class Usuario
    {
        private int _age;
        private string _name;

        public int Age 
        { 
            get => _age; 
            set
            {
                if (value < 0)
                    _age = 0;
                else 
                    _age = value;
            }
        }
        public string Name { get => _name; set =>  _name = value; }
    }
}