namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class preçoproduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.produtos", "Preço", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.produtos", "Preço");
        }
    }
}
