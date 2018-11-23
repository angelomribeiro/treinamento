using CadastroCliente.Domain.Model;
using System.Collections.Generic;

namespace CadastroCliente.Service.Interfaces
{
    public interface IClienteService
    {
        ICollection<Cliente> ListarClientes();
        void Cadastrar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(int id);
    }
}
