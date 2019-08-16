namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoCategoria : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.categoriaDoProdutoes", "Tipo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.categoriaDoProdutoes", "Tipo");
        }
    }
}
