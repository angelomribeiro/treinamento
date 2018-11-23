using CadastroCliente.Data.Entity;
using CadastroCliente.Data.EntityMap;
using System.Data.Entity;

namespace CadastroCliente.Data.Context
{
    /// <summary>
    /// Essa classe de contexto administra os objetos entidades durante o tempo de execução, 
    /// o que inclui preencher objetos com dados de um banco de dados, controlar alterações, 
    /// e persistir dados para o banco de dados.
    /// </summary>
    public class CadastroClienteContext : DbContext
    {
        // define nome da string de conexao (sera definido no web.config do projeto asp.net mvc)
        public CadastroClienteContext() : base("name=CadastroConnection") {}

        // representacao da entidade dentro do contexto
        public virtual DbSet<ClienteEntity> Cliente { get; set; }
        public virtual DbSet<ProdutoEntity> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // cria mapeamento da classe com tabela no banco de dados
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
