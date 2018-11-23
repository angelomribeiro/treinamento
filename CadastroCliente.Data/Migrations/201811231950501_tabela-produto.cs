namespace CadastroCliente.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabelaproduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.produto",
                c => new
                    {
                        produto_id = c.Int(nullable: false, identity: true),
                        descricao = c.String(nullable: false, maxLength: 100),
                        preco = c.Decimal(nullable: false, precision: 5, scale: 2),
                        quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.produto_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.produto");
        }
    }
}
