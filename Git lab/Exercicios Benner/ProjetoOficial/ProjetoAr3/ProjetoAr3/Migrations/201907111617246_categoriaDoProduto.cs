namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoriaDoProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categoriaDoProdutoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.categoriaDoProdutoes");
        }
    }
}
