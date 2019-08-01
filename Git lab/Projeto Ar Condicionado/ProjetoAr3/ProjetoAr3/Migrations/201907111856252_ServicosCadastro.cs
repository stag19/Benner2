namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicosCadastro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.serviços",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serviço = c.String(nullable: false),
                        Preço = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.clientes", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.clientes", "Senha", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.clientes", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.clientes", "Cpf", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.funcionarios", "Senha", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.funcionarios", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.funcionarios", "Cpf", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.produtos", "Nome", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.produtos", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.funcionarios", "Cpf", c => c.String(maxLength: 15));
            AlterColumn("dbo.funcionarios", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.funcionarios", "Senha", c => c.String(maxLength: 50));
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 15));
            AlterColumn("dbo.clientes", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.clientes", "Senha", c => c.String(maxLength: 50));
            AlterColumn("dbo.clientes", "Nome", c => c.String(maxLength: 100));
            DropTable("dbo.serviços");
        }
    }
}
