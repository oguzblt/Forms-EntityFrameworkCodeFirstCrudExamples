namespace KitaplarEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaps", "Yazar_Id_Id", "dbo.Yazars");
            DropIndex("dbo.Kitaps", new[] { "Yazar_Id_Id" });
            RenameColumn(table: "dbo.Kitaps", name: "Yazar_Id_Id", newName: "YazarId");
            AddColumn("dbo.Kitaps", "TurId", c => c.Int(nullable: false));
            AlterColumn("dbo.Kitaps", "YazarId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kitaps", "YazarId");
            AddForeignKey("dbo.Kitaps", "YazarId", "dbo.Yazars", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaps", "YazarId", "dbo.Yazars");
            DropIndex("dbo.Kitaps", new[] { "YazarId" });
            AlterColumn("dbo.Kitaps", "YazarId", c => c.Int());
            DropColumn("dbo.Kitaps", "TurId");
            RenameColumn(table: "dbo.Kitaps", name: "YazarId", newName: "Yazar_Id_Id");
            CreateIndex("dbo.Kitaps", "Yazar_Id_Id");
            AddForeignKey("dbo.Kitaps", "Yazar_Id_Id", "dbo.Yazars", "Id");
        }
    }
}
