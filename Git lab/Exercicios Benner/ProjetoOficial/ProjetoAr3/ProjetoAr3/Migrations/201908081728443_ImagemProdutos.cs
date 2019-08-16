namespace ProjetoAr3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagemProdutos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.produtos", "Imagem", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.produtos", "Imagem");
        }
    }
}
