namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.funcionarios");
            AddColumn("dbo.funcionarios", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.funcionarios", "Usuarioid", c => c.Int(nullable: false));
            AlterColumn("dbo.funcionarios", "Email", c => c.String());
            AlterColumn("dbo.funcionarios", "Cpf", c => c.String());
            AddPrimaryKey("dbo.funcionarios", "Id");
            CreateIndex("dbo.funcionarios", "Usuarioid");
            AddForeignKey("dbo.funcionarios", "Usuarioid", "dbo.Usuarios", "Id", cascadeDelete: true);
            DropColumn("dbo.funcionarios", "Nome");
            DropColumn("dbo.funcionarios", "Senha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.funcionarios", "Senha", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.funcionarios", "Nome", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.funcionarios", "Usuarioid", "dbo.Usuarios");
            DropIndex("dbo.funcionarios", new[] { "Usuarioid" });
            DropPrimaryKey("dbo.funcionarios");
            AlterColumn("dbo.funcionarios", "Cpf", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.funcionarios", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.funcionarios", "Usuarioid");
            DropColumn("dbo.funcionarios", "Id");
            AddPrimaryKey("dbo.funcionarios", "Nome");
        }
    }
}
