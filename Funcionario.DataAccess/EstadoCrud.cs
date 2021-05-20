using Funcionario.Models;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionario.DataAccess
{
    public class EstadoCrud : IEmpresaCrud<Models.Estado>
    {
        private readonly EmpresaContext _context;

        public EstadoCrud()
        {
            _context = new EmpresaContext();
        }

        public List<Models.Estado> GetAll()
        {
            return  _context.Estado.ToList();
        }
        
        public Task <List<Models.Estado>> GetAllAsync()
        {
            return  _context.Estado.ToListAsync();
        }


        public Task Add(Models.Estado item)
        {
            throw new NotImplementedException();
        }

        public Task Update(Models.Estado item)
        {
            throw new NotImplementedException();
        }


        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Estado> GetAsync(int id)
        {
            throw new NotImplementedException();
        }


    }


}
