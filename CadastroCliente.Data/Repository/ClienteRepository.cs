using CadastroCliente.Data.Entity;
using CadastroCliente.Data.Interfaces;

namespace CadastroCliente.Data.Repository
{
    public class ClienteRepository : RepositoryBase<ClienteEntity>, IClienteRepository
    {
    }
}
