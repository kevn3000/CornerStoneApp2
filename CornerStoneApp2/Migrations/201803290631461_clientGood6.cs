namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientGood6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "advoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "advoID" });
            RenameColumn(table: "dbo.Project", name: "advoID", newName: "projectManager_AdvoID");
            AlterColumn("dbo.Project", "projectManager_AdvoID", c => c.Guid());
            CreateIndex("dbo.Project", "projectManager_AdvoID");
            AddForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo", "AdvoID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "projectManager_AdvoID" });
            AlterColumn("dbo.Project", "projectManager_AdvoID", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.Project", name: "projectManager_AdvoID", newName: "advoID");
            CreateIndex("dbo.Project", "advoID");
            AddForeignKey("dbo.Project", "advoID", "dbo.Advo", "AdvoID", cascadeDelete: true);
        }
    }
}
