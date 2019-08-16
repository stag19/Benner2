namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loginarrumando : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Preço = c.String(),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categoriaDoProdutoes", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
            DropTable("dbo.Produtoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Single(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        Descricao = c.String(),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.produtos", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.produtos", new[] { "CategoriaId" });
            DropTable("dbo.produtos");
            CreateIndex("dbo.Produtoes", "CategoriaId");
            AddForeignKey("dbo.Produtoes", "CategoriaId", "dbo.categoriaDoProdutoes", "Id", cascadeDelete: true);
        }
    }
}
