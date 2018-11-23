using CadastroCliente.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CadastroCliente.Data.EntityMap
{
    public class ProdutoMap : EntityTypeConfiguration<ProdutoEntity>
    {
        public ProdutoMap()
        {
            // define nome da tabela
            ToTable("produto");

            // define chave primaria
            HasKey(k => k.ProdutoId);

            // configura chave primaria
            Property(p => p.ProdutoId)
                .HasColumnName("produto_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Descricao)
                .HasColumnName("descricao")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.Preco)
                .HasColumnName("preco")
                .HasPrecision(5, 2)
                .IsRequired();

            Property(p => p.Quantidade)
                .HasColumnName("quantidade")
                .IsRequired();
        }
    }
}
