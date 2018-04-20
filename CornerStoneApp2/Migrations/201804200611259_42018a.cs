namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _42018a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "ChildID", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "ChildID");
        }
    }
}
