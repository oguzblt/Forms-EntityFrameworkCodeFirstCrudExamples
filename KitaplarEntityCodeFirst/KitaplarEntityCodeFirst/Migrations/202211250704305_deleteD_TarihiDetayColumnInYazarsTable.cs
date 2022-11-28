namespace KitaplarEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteD_TarihiDetayColumnInYazarsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Yazars", "D_Tarihi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yazars", "D_Tarihi", c => c.DateTime(nullable: false));
        }
    }
}
