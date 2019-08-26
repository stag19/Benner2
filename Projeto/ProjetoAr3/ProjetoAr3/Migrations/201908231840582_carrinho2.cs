namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carrinho2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.clientes", "CarrinhoId", "dbo.carrinhoes");
            DropIndex("dbo.clientes", new[] { "CarrinhoId" });
            AlterColumn("dbo.clientes", "CarrinhoId", c => c.Int());
            CreateIndex("dbo.clientes", "CarrinhoId");
            AddForeignKey("dbo.clientes", "CarrinhoId", "dbo.carrinhoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.clientes", "CarrinhoId", "dbo.carrinhoes");
            DropIndex("dbo.clientes", new[] { "CarrinhoId" });
            AlterColumn("dbo.clientes", "CarrinhoId", c => c.Int(nullable: false));
            CreateIndex("dbo.clientes", "CarrinhoId");
            AddForeignKey("dbo.clientes", "CarrinhoId", "dbo.carrinhoes", "Id", cascadeDelete: true);
        }
    }
}
