﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Funcionario.DataAccess
{

    public interface IEmpresaCrud<T> where T : class
    {
        List<T> GetAll();
        Task <List<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task Add(T item);
        Task Update(T item);
        bool Delete(int id);
    }


}
