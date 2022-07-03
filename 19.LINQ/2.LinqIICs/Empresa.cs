using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIICs
{
    public class Empresa : EmpresaIdGenerator
    {
        private List<Empleado> _employees;
        private int _companyId;
        protected string CompranyName { get; }
        public List<Empleado> Employees { get => this._employees; }
        
        public Empresa(List<Empleado> employees, string compranyName)
        {
            this.CompranyName = compranyName;
            this._employees = employees;

            for (int i = 0; i < this._employees.Count; i++)
            {
                this._employees[i].CompanyId = this.CompanyId;
            }
        }
        public Empleado GetEmployeeByIndex(int index)
        {
            if (index <= this._employees.Count) return this._employees[index];
            else return new Empleado("UNDEFINED", 404);
        }
    }
}