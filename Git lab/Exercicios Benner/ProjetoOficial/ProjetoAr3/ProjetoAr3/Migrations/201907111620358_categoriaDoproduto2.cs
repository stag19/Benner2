namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoriaDoproduto2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.categoriaDoProdutoes", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.categoriaDoProdutoes", "Nome", c => c.Int(nullable: false));
        }
    }
}
