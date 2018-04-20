namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigration42018 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "projectManager_AdvoID" });
            RenameColumn(table: "dbo.Project", name: "projectManager_AdvoID", newName: "AdvoID");
            AlterColumn("dbo.Project", "AdvoID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Project", "AdvoID");
            AddForeignKey("dbo.Project", "AdvoID", "dbo.Advo", "AdvoID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Project", "AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "AdvoID" });
            AlterColumn("dbo.Project", "AdvoID", c => c.Guid());
            RenameColumn(table: "dbo.Project", name: "AdvoID", newName: "projectManager_AdvoID");
            CreateIndex("dbo.Project", "projectManager_AdvoID");
            AddForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo", "AdvoID");
        }
    }
}
