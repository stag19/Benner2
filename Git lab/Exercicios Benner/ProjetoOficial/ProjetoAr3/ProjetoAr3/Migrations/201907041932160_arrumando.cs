namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arrumando : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 14));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 11));
        }
    }
}
