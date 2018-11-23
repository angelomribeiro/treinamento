using CadastroCliente.Domain.Model;
using System.Collections.Generic;

namespace CadastroCliente.Service.Interfaces
{
    public interface IProdutoService
    {
        ICollection<Produto> ListarProdutos();
        void Cadastrar(Produto produto);
        void Alterar(Produto produto);
        void Excluir(int id);
        ICollection<Produto> ListarPorDescricao(string descricao);
        void AtualizaEstoque(int id, int quantidade);
    }
}
