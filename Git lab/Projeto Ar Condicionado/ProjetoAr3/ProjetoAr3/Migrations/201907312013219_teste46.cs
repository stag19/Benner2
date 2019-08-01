namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste46 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.clientes", "Cpf", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.clientes", "Email", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
