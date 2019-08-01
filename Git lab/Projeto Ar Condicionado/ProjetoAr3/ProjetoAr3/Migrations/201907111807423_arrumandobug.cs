namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arrumandobug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.produtos", "Nome", c => c.String(nullable: false));
            DropColumn("dbo.produtos", "Nomeproduto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.produtos", "Nomeproduto", c => c.String(nullable: false));
            DropColumn("dbo.produtos", "Nome");
        }
    }
}
