using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Funcionario.DataAccess
{
    public class FuncionarioCrud : IEmpresaCrud<Models.Funcionario>
    {
        private readonly EmpresaContext _context;
        public FuncionarioCrud()
        {
            _context = new EmpresaContext();
        }

        public IEnumerable<Models.Funcionario> GetAll()
        {
           return  _context.Funcionario.ToList();
        }


        public Models.Funcionario Add(Models.Funcionario item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Funcionario Get(int id)
        {
            return _context.Funcionario.Find(id);
        }


        public bool Update(Models.Funcionario item)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
