using System.Collections.Generic;
using System.Linq;
using CadastroCliente.Data.Context;
using CadastroCliente.Data.Entity;
using CadastroCliente.Data.Interfaces;

namespace CadastroCliente.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<ProdutoEntity>, IProdutoRepository
    {
        private readonly CadastroClienteContext _db;

        public ProdutoRepository()
        {
            _db = new CadastroClienteContext();
        }

        public void AtualizaEstoque(int id, int quantidade)
        {
            // busca produto por id
            var produto = _db.Produto.FirstOrDefault(w => w.ProdutoId == id);
            // altera quantidade
            produto.Quantidade = quantidade;
            // atualiza registro no banco
            Update(produto);
        }

        public IEnumerable<ProdutoEntity> ListarPorDescricao(string descricao)
        {
            return _db.Produto.Where(w => w.Descricao.Contains(descricao)).ToList();
        }
    }
}
