using CadastroCliente.Data.Entity;
using System.Collections.Generic;

namespace CadastroCliente.Data.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<ProdutoEntity>
    {
        IEnumerable<ProdutoEntity> ListarPorDescricao(string descricao);
        void AtualizaEstoque(int id, int quantidade);
    }
}
