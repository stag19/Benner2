namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lointest2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.logins", newName: "Usuarios");
            AlterColumn("dbo.Usuarios", "Nome", c => c.String());
            AlterColumn("dbo.Usuarios", "Senha", c => c.String());
            DropTable("dbo.registrars");
        }
        
        public override void Down()
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
            
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false, maxLength: 100));
            RenameTable(name: "dbo.Usuarios", newName: "logins");
        }
    }
}
