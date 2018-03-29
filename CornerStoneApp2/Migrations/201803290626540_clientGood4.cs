namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientGood4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "advoID", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "advoID");
        }
    }
}
