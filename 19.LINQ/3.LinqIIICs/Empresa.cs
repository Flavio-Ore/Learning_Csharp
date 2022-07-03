using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIIICs
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GetCompanyData { get => $"Empresa {Name}, Id: {Id}"; }
    }
}