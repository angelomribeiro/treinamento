using System.Collections.Generic;

namespace CadastroCliente.Domain.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T model);
        void Update(T model);
        IEnumerable<T> Listar();
        void Delete(int id);
    }
}
