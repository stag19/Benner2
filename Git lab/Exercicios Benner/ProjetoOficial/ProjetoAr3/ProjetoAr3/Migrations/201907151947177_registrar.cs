namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class registrar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.registrars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.logins", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.logins", "Senha", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.logins", "Senha", c => c.String());
            AlterColumn("dbo.logins", "Nome", c => c.String());
            DropTable("dbo.registrars");
        }
    }
}
