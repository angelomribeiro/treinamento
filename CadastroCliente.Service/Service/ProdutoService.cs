using AutoMapper;
using CadastroCliente.Data.Entity;
using CadastroCliente.Data.Interfaces;
using CadastroCliente.Data.Repository;
using CadastroCliente.Domain.Model;
using CadastroCliente.Service.Interfaces;
using System.Collections.Generic;

namespace CadastroCliente.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoService()
        {
            // instancia o repositorio do produto
            _repository = new ProdutoRepository();

            // configura automapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Produto, ProdutoEntity>().ReverseMap();
            });
            _mapper = config.CreateMapper();
        }

        public void Alterar(Produto produto)
        {
            var entity = _mapper.Map<ProdutoEntity>(produto);
            _repository.Update(entity);
        }

        public void AtualizaEstoque(int id, int quantidade)
        {
            _repository.AtualizaEstoque(id, quantidade);
        }

        public void Cadastrar(Produto produto)
        {
            var entity = _mapper.Map<ProdutoEntity>(produto);
            _repository.Add(entity);
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public ICollection<Produto> ListarPorDescricao(string descricao)
        {
            return Mapper.Map<ICollection<Produto>>(_repository.ListarPorDescricao(descricao));
        }

        public ICollection<Produto> ListarProdutos()
        {
            return _mapper.Map<ICollection<Produto>>(_repository.Listar());
        }
    }
}
