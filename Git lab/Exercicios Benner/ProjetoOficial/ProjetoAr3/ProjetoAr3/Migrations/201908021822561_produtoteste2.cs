namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class produtoteste2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.produtos", "Quantidade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.produtos", "Quantidade");
        }
    }
}
