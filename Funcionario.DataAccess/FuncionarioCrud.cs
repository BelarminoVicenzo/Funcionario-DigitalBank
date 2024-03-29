﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        public List<Models.Funcionario> GetAll()
        {
            return _context.Funcionario.ToList();
        }

        public Task<List<Models.Funcionario>> GetAllAsync()
        {
            return _context.Funcionario.ToListAsync();
        }

        public Task Add(Models.Funcionario item)
        {
            _context.Funcionario.Add(item);
            return _context.SaveChangesAsync();
        }

        public Task Update(Models.Funcionario item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Funcionario> GetAsync(int id)
        {
            return _context.Funcionario.FindAsync(id);
        }


    }


}
