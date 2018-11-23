namespace CadastroCliente.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        cliente_id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false, maxLength: 100),
                        endereco = c.String(nullable: false, maxLength: 300),
                        telefone = c.String(maxLength: 20),
                        data_nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.cliente_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cliente");
        }
    }
}
