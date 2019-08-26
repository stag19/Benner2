namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carrinho1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.carrinhoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProdutosId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.produtos", t => t.ProdutosId)
                .Index(t => t.ProdutosId);
            
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Quantidade = c.String(),
                        Preço = c.String(),
                        CategoriaId = c.Int(),
                        Imagem = c.Binary(),
                        Pedido_PedidoID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.categoriaDoProdutoes", t => t.CategoriaId)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_PedidoID)
                .Index(t => t.CategoriaId)
                .Index(t => t.Pedido_PedidoID);
            
            CreateTable(
                "dbo.categoriaDoProdutoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuarioid = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Cpf = c.String(nullable: false),
                        CarrinhoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.carrinhoes", t => t.CarrinhoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.Usuarioid, cascadeDelete: true)
                .Index(t => t.Usuarioid)
                .Index(t => t.CarrinhoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuarioid = c.Int(nullable: false),
                        Email = c.String(),
                        Cpf = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuarioid, cascadeDelete: true)
                .Index(t => t.Usuarioid);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdutosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.serviços",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Serviço = c.String(nullable: false),
                        Preço = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.produtos", "Pedido_PedidoID", "dbo.Pedidoes");
            DropForeignKey("dbo.funcionarios", "Usuarioid", "dbo.Usuarios");
            DropForeignKey("dbo.clientes", "Usuarioid", "dbo.Usuarios");
            DropForeignKey("dbo.clientes", "CarrinhoId", "dbo.carrinhoes");
            DropForeignKey("dbo.carrinhoes", "ProdutosId", "dbo.produtos");
            DropForeignKey("dbo.produtos", "CategoriaId", "dbo.categoriaDoProdutoes");
            DropIndex("dbo.Pedidoes", new[] { "UsuarioId" });
            DropIndex("dbo.funcionarios", new[] { "Usuarioid" });
            DropIndex("dbo.clientes", new[] { "CarrinhoId" });
            DropIndex("dbo.clientes", new[] { "Usuarioid" });
            DropIndex("dbo.produtos", new[] { "Pedido_PedidoID" });
            DropIndex("dbo.produtos", new[] { "CategoriaId" });
            DropIndex("dbo.carrinhoes", new[] { "ProdutosId" });
            DropTable("dbo.serviços");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.funcionarios");
            DropTable("dbo.Usuarios");
            DropTable("dbo.clientes");
            DropTable("dbo.categoriaDoProdutoes");
            DropTable("dbo.produtos");
            DropTable("dbo.carrinhoes");
        }
    }
}
