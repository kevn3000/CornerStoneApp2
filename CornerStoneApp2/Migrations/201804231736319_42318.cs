namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _42318 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Project", "client_clientID", "dbo.Client");
            DropForeignKey("dbo.Project", "advo_AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "advo_AdvoID" });
            DropIndex("dbo.Project", new[] { "client_clientID" });
            RenameColumn(table: "dbo.Project", name: "advo_AdvoID", newName: "AdvoID");
            AddColumn("dbo.Project", "ClientID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Project", "AdvoID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Project", "AdvoID");
            AddForeignKey("dbo.Project", "AdvoID", "dbo.Advo", "AdvoID", cascadeDelete: true);
            DropColumn("dbo.Project", "studentName");
            DropColumn("dbo.Project", "totalHours");
            DropColumn("dbo.Project", "client_clientID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "client_clientID", c => c.Guid());
            AddColumn("dbo.Project", "totalHours", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "studentName", c => c.String());
            DropForeignKey("dbo.Project", "AdvoID", "dbo.Advo");
            DropIndex("dbo.Project", new[] { "AdvoID" });
            AlterColumn("dbo.Project", "AdvoID", c => c.Guid());
            DropColumn("dbo.Project", "ClientID");
            RenameColumn(table: "dbo.Project", name: "AdvoID", newName: "advo_AdvoID");
            CreateIndex("dbo.Project", "client_clientID");
            CreateIndex("dbo.Project", "advo_AdvoID");
            AddForeignKey("dbo.Project", "advo_AdvoID", "dbo.Advo", "AdvoID");
            AddForeignKey("dbo.Project", "client_clientID", "dbo.Client", "clientID");
        }
    }
}
