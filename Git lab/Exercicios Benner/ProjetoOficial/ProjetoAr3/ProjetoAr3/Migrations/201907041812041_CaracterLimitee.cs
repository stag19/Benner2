namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaracterLimitee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "Senha", c => c.String(maxLength: 50));
            AlterColumn("dbo.clientes", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.Double(nullable: false));
            AlterColumn("dbo.clientes", "Email", c => c.String());
            AlterColumn("dbo.clientes", "Senha", c => c.String());
        }
    }
}
