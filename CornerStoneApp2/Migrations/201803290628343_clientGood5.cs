namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientGood5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "projectManager_AdvoID" });
            RenameColumn(table: "dbo.Project", name: "projectManager_AdvoID", newName: "advoID");
            AlterColumn("dbo.Project", "advoID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Project", "advoID");
            AddForeignKey("dbo.Project", "advoID", "dbo.Advo", "AdvoID", cascadeDelete: true);
            DropColumn("dbo.Client", "advoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "advoID", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Project", "advoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "advoID" });
            AlterColumn("dbo.Project", "advoID", c => c.Guid());
            RenameColumn(table: "dbo.Project", name: "advoID", newName: "projectManager_AdvoID");
            CreateIndex("dbo.Project", "projectManager_AdvoID");
            AddForeignKey("dbo.Project", "projectManager_AdvoID", "dbo.Advo", "AdvoID");
        }
    }
}
