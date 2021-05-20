using System.Collections.Generic;
using System.Threading.Tasks;

namespace Funcionario.DataAccess
{

    public interface IEmpresaCrud<T> where T : class
    {
        List<T> GetAll();
        Task <List<T>> GetAllAsync();
        T Get(int id);
        T Add(T item);
        bool Update(T item);
        bool Delete(int id);
    }


}
