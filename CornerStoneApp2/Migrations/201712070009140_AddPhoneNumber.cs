namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advocates", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Advocates", "PhoneNumber");
        }
    }
}
