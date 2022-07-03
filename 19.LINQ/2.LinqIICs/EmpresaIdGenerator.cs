using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqIICs
{
    public class EmpresaIdGenerator
    {
        private int _id;
        protected static int CorpId = 0;
        public EmpresaIdGenerator()
        {
            this._id = CorpId++;
        }
        protected int CompanyId { get => this._id;}
        public int Id { get => CompanyId; }
    }
}