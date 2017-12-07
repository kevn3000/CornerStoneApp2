namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advocates",
                c => new
                    {
                        MyId = c.String(nullable: false, maxLength: 128),
                        Tasks = c.String(),
                    })
                .PrimaryKey(t => t.MyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Advocates");
        }
    }
}
