using CadastroCliente.Data.Entity;
using CadastroCliente.Data.Repository;
using CadastroCliente.Domain.Model;
using CadastroCliente.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Service.Service
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void Alterar(Cliente cliente)
        {
            ClienteEntity entity = new ClienteEntity {
                ClienteId = cliente.ClienteId,
                DataNascimento = cliente.DataNascimento,
                Email = cliente.Email,
                Endereco = cliente.Email,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };

            _repository.Update(entity);
        }

        public void Cadastrar(Cliente cliente)
        {
            ClienteEntity entity = new ClienteEntity
            {
                DataNascimento = cliente.DataNascimento,
                Email = cliente.Email,
                Endereco = cliente.Email,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };

            _repository.Add(entity);
        }

        public void Excluir(int id)
        {
            _repository.Delete(id);
        }

        public ICollection<Cliente> ListarClientes()
        {
            var lista = _repository.Listar();
            ICollection<Cliente> lstClienteDomain = new List<Cliente>();

            foreach(var cliente in lista)
            {
                lstClienteDomain.Add(new Cliente {
                    ClienteId = cliente.ClienteId,
                    DataNascimento = cliente.DataNascimento,
                    Email = cliente.Email,
                    Endereco = cliente.Endereco,
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone
                });
            }

            return lstClienteDomain;
        }
    }
}
