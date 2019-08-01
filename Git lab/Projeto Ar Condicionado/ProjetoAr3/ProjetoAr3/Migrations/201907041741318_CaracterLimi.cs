namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaracterLimi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "Nome", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "Nome", c => c.String());
        }
    }
}
