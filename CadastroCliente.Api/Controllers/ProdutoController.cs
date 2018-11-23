using CadastroCliente.Domain.Model;
using CadastroCliente.Service.Interfaces;
using CadastroCliente.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CadastroCliente.Api.Controllers
{
    public class ProdutoController : ApiController
    {
        // criando uma variavel privada para armazenar o servico
        private readonly IProdutoService _service;

        public ProdutoController()
        {
            // criando uma nova instancia do servico
            _service = new ProdutoService();
        }

        /// <summary>
        /// Lista produtos
        /// </summary>
        [HttpGet]
        [Route("produtos/listar")]
        public IHttpActionResult Index()
        {
            return Ok(_service.ListarProdutos());
        }

        /// <summary>
        /// Cadastra produtos
        /// </summary>
        [HttpPost]
        [Route("produtos/cadastrar")]
        public IHttpActionResult Cadastrar([FromBody]Produto produto)
        {
            _service.Cadastrar(produto);
            return Ok();
        }

        /// <summary>
        /// Altera produto
        /// </summary>
        [HttpPut]
        [Route("produtos/alterar")]
        public IHttpActionResult Alterar([FromBody]Produto produto)
        {
            _service.Alterar(produto);
            return Ok();
        }

        /// <summary>
        /// Exclui produto
        /// </summary>
        [HttpDelete]
        [Route("produto/excluir")]
        public IHttpActionResult Excluir(int id)
        {
            _service.Excluir(id);
            return Ok();
        }

        /// <summary>
        /// Altera estoque
        /// </summary>
        [HttpPost]
        [Route("produtos/alterar-estoque")]
        public IHttpActionResult AlterarEstoque(int id, int quantidade)
        {
            _service.AtualizaEstoque(id, quantidade);
            return Ok();
        }

        /// <summary>
        /// Lista produtos por descricao
        /// </summary>
        [HttpGet]
        [Route("produtos/listar-descricao")]
        public IHttpActionResult ListaPorDescricao(string descricao)
        {
            return Ok(_service.ListarPorDescricao(descricao));
        }
    }
}
