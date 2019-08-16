namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.produtos", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.produtos", "Image", c => c.String());
        }
    }
}
