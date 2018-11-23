using CadastroCliente.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CadastroCliente.Data.EntityMap
{
    public class ClienteMap : EntityTypeConfiguration<ClienteEntity>
    {
        public ClienteMap()
        {
            // define o nome da tabela
            // se não for definido, o nome da tabela será o nome da entidade
            ToTable("cliente");

            // definindo chave-primaria
            HasKey(k => k.ClienteId);

            // define que o banco de dados irá gerar o valor para a chave-primária
            Property(p => p.ClienteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // define nome, tipo e se será obrigatório
            Property(p => p.Nome)
                .HasColumnName("nome") // nome do campo
                .HasColumnType("varchar(100)") // tipo do campo
                .IsRequired(); // preenchimento obrigatório

            Property(p => p.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(100)")
                .IsRequired();

            Property(p => p.Endereco)
                .HasColumnName("endereco")
                .HasColumnType("varchar(300)")
                .IsRequired();

            Property(p => p.Telefone)
                .HasColumnName("telefone")
                .HasColumnType("varchar(20)");

            // se o tipo do campo não for definido, o EF irá definir baseado no tipo do atributo
            Property(p => p.DataNascimento)
                .HasColumnName("data_nascimento")
                .IsRequired();
        }
    }
}
