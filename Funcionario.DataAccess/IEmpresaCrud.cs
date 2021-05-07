using System.Collections.Generic;
 
namespace Funcionario.DataAccess
{

    public interface IEmpresaCrud<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T item);
        bool Update(T item);
        bool Delete(int id);
    }


}
