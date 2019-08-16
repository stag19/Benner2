namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cadastroFuncionario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.funcionarios",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(maxLength: 50),
                        Email = c.String(maxLength: 100),
                        Telefone = c.String(maxLength: 100),
                        Cpf = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.funcionarios");
        }
    }
}
