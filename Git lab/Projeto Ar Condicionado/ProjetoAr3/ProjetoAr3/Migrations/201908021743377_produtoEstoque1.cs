namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class produtoEstoque1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.produtos", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.produtos", new[] { "CategoriaId" });
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categoriaDoProdutoes", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            DropTable("dbo.produtos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Preço = c.String(),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            DropTable("dbo.Produtoes");
            CreateIndex("dbo.produtos", "CategoriaId");
            AddForeignKey("dbo.produtos", "CategoriaId", "dbo.categoriaDoProdutoes", "Id");
        }
    }
}
