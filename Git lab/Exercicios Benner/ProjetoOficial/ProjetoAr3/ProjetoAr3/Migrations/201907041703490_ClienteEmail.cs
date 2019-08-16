namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.clientes", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.clientes", "Email");
        }
    }
}
