namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CadastrosProdutos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categoriaDoProdutoes", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
            AlterColumn("dbo.categoriaDoProdutoes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.produtos", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.produtos", new[] { "CategoriaId" });
            AlterColumn("dbo.categoriaDoProdutoes", "Nome", c => c.String());
            DropTable("dbo.produtos");
        }
    }
}
