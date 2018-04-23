namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _42318a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "ChildID", c => c.Guid(nullable: false));
            AddColumn("dbo.Project", "client_clientID", c => c.Guid());
            CreateIndex("dbo.Project", "client_clientID");
            AddForeignKey("dbo.Project", "client_clientID", "dbo.Client", "clientID");
            DropColumn("dbo.Project", "ClientID");
            DropColumn("dbo.Project", "startDate");
            DropColumn("dbo.Project", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Project", "Status", c => c.String());
            AddColumn("dbo.Project", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Project", "ClientID", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Project", "client_clientID", "dbo.Client");
            DropIndex("dbo.Project", new[] { "client_clientID" });
            DropColumn("dbo.Project", "client_clientID");
            DropColumn("dbo.Project", "ChildID");
        }
    }
}
