namespace KitaplarEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kitaps", "Tur_ID_Id", c => c.Int());
            AddColumn("dbo.Kitaps", "Yazar_Id_Id", c => c.Int());
            CreateIndex("dbo.Kitaps", "Tur_ID_Id");
            CreateIndex("dbo.Kitaps", "Yazar_Id_Id");
            AddForeignKey("dbo.Kitaps", "Tur_ID_Id", "dbo.KitapTurs", "Id");
            AddForeignKey("dbo.Kitaps", "Yazar_Id_Id", "dbo.Yazars", "Id");
            DropColumn("dbo.Kitaps", "Yazar_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kitaps", "Yazar_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Kitaps", "Yazar_Id_Id", "dbo.Yazars");
            DropForeignKey("dbo.Kitaps", "Tur_ID_Id", "dbo.KitapTurs");
            DropIndex("dbo.Kitaps", new[] { "Yazar_Id_Id" });
            DropIndex("dbo.Kitaps", new[] { "Tur_ID_Id" });
            DropColumn("dbo.Kitaps", "Yazar_Id_Id");
            DropColumn("dbo.Kitaps", "Tur_ID_Id");
        }
    }
}
