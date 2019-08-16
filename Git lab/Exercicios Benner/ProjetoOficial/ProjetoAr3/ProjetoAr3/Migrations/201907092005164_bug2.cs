namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bug2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.funcionarios", "Telefone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.funcionarios", "Telefone", c => c.String(maxLength: 100));
        }
    }
}
