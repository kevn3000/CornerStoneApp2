namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _420183am : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "AdvoID" });
            RenameColumn(table: "dbo.Project", name: "AdvoID", newName: "advo_AdvoID");
            AlterColumn("dbo.Project", "advo_AdvoID", c => c.Guid());
            CreateIndex("dbo.Project", "advo_AdvoID");
            AddForeignKey("dbo.Project", "advo_AdvoID", "dbo.Advo", "AdvoID");
            DropColumn("dbo.Project", "ChildID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "ChildID", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Project", "advo_AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "advo_AdvoID" });
            AlterColumn("dbo.Project", "advo_AdvoID", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.Project", name: "advo_AdvoID", newName: "AdvoID");
            CreateIndex("dbo.Project", "AdvoID");
            AddForeignKey("dbo.Project", "AdvoID", "dbo.Advo", "AdvoID", cascadeDelete: true);
        }
    }
}
