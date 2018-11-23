using CadastroCliente.Data.Context;
using CadastroCliente.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace CadastroCliente.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly CadastroClienteContext _db;

        public RepositoryBase()
        {
            _db = new CadastroClienteContext();
        }

        public void Add(T model)
        {
            _db.Set<T>().Add(model);
            Save();
        }

        public void Delete(int id)
        {
            var entity = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(entity);
            Save();
        }

        public IEnumerable<T> Listar()
        {
            return _db.Set<T>().ToList();
        }

        public void Update(T model)
        {
            _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }
    }
}
