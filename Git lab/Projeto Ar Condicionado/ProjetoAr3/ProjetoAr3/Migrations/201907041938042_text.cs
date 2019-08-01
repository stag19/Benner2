namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class text : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "Cpf", c => c.String(maxLength: 14));
        }
    }
}
