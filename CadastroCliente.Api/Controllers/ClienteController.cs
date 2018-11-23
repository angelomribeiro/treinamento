using CadastroCliente.Domain.Model;
using CadastroCliente.Service.Interfaces;
using CadastroCliente.Service.Service;
using System.Web.Http;

namespace CadastroCliente.Api.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _service;

        public ClienteController()
        {
            _service = new ClienteService();
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(_service.ListarClientes());
        }

        [HttpPost]
        public IHttpActionResult Salvar(Cliente cliente)
        {
            _service.Cadastrar(cliente);
            return Ok();
        }
    }
}