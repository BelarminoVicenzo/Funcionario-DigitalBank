using Funcionario.Models;

using System;
using System.Collections.Generic;
using System.Linq;


namespace Funcionario.DataAccess
{
    public class EstadoCrud : IEmpresaCrud<Models.Estado>
    {
        private readonly EmpresaContext _context;

        public EstadoCrud()
        {
            _context = new EmpresaContext();
        }

        public IEnumerable<Models.Estado> GetAll()
        {
            return _context.Estado;
        }


        public Models.Estado Add(Models.Estado item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Estado Get(int id)
        {
            throw new NotImplementedException();
        }


        public bool Update(Models.Estado item)
        {
            throw new NotImplementedException();
        }
    }


}
