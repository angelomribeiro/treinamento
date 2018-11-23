using CadastroCliente.Domain.Model;
using CadastroCliente.Service.Interfaces;
using CadastroCliente.Service.Service;
using System.Web.Http;

namespace CadastroCliente.Api.Controllers
{
    public class ClienteController : ApiController
    {
        // criando uma variavel privada para armazenar o servico
        private readonly IClienteService _service;

        public ClienteController()
        {
            // criando uma nova instancia do servico
            _service = new ClienteService();
        }

        /// <summary>
        /// Lista clientes
        /// </summary>
        [HttpGet]
        [Route("clientes/listar")]
        public IHttpActionResult Index()
        {
            return Ok(_service.ListarClientes());
        }

        /// <summary>
        /// Cadastra clientes
        /// </summary>
        [HttpPost]
        [Route("clientes/cadastrar")]
        public IHttpActionResult Cadastrar([FromBody]Cliente cliente)
        {
            _service.Cadastrar(cliente);
            return Ok();
        }

        /// <summary>
        /// Altera clientes
        /// </summary>
        [HttpPut]
        [Route("clientes/alterar")]
        public IHttpActionResult Alterar([FromBody]Cliente cliente)
        {
            _service.Alterar(cliente);
            return Ok();
        }

        /// <summary>
        /// Exclui clientes
        /// </summary>
        [HttpDelete]
        [Route("clientes/excluir")]
        public IHttpActionResult Excluir(int id)
        {
            _service.Excluir(id);
            return Ok();
        }
    }
}