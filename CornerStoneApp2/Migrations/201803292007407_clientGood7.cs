namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clientGood7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donation", "donorFirst", c => c.String());
            AddColumn("dbo.Donation", "donorLast", c => c.String());
            AddColumn("dbo.Donation", "donorZip", c => c.String());
            DropColumn("dbo.Donation", "DonorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Donation", "DonorID", c => c.Int(nullable: false));
            DropColumn("dbo.Donation", "donorZip");
            DropColumn("dbo.Donation", "donorLast");
            DropColumn("dbo.Donation", "donorFirst");
        }
    }
}
