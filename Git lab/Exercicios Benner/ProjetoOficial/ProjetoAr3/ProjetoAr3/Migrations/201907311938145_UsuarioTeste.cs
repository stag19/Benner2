namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuarioTeste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.clientes", "Usuarioid", c => c.Int(nullable: false));
            CreateIndex("dbo.clientes", "Usuarioid");
            AddForeignKey("dbo.clientes", "Usuarioid", "dbo.Usuarios", "Id", cascadeDelete: true);
            DropColumn("dbo.clientes", "Nome");
            DropColumn("dbo.clientes", "Senha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.clientes", "Senha", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.clientes", "Nome", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.clientes", "Usuarioid", "dbo.Usuarios");
            DropIndex("dbo.clientes", new[] { "Usuarioid" });
            DropColumn("dbo.clientes", "Usuarioid");
        }
    }
}
