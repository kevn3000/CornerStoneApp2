namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientGood3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "totalHours", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "totalHours");
        }
    }
}
