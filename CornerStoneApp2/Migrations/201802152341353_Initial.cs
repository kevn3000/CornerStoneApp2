namespace CornerStoneApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advo",
                c => new
                    {
                        AdvoID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AdvoID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        AdvoID = c.Int(nullable: false),
                        ChildID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Advo", t => t.AdvoID, cascadeDelete: true)
                .Index(t => t.AdvoID);
            
            CreateTable(
                "dbo.Child",
                c => new
                    {
                        ChildID = c.Int(nullable: false, identity: true),
                        AdvoID = c.Int(nullable: false),
                        ProjectID = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MidName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ChildID);
            
            CreateTable(
                "dbo.Parent",
                c => new
                    {
                        ParentID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MidName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ParentID);
            
            CreateTable(
                "dbo.Donor",
                c => new
                    {
                        DonorID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MidName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.DonorID);
            
            CreateTable(
                "dbo.ParentChild",
                c => new
                    {
                        Parent_ParentID = c.Int(nullable: false),
                        Child_ChildID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Parent_ParentID, t.Child_ChildID })
                .ForeignKey("dbo.Parent", t => t.Parent_ParentID, cascadeDelete: true)
                .ForeignKey("dbo.Child", t => t.Child_ChildID, cascadeDelete: true)
                .Index(t => t.Parent_ParentID)
                .Index(t => t.Child_ChildID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParentChild", "Child_ChildID", "dbo.Child");
            DropForeignKey("dbo.ParentChild", "Parent_ParentID", "dbo.Parent");
            DropForeignKey("dbo.Project", "AdvoID", "dbo.Advo");
            DropIndex("dbo.ParentChild", new[] { "Child_ChildID" });
            DropIndex("dbo.ParentChild", new[] { "Parent_ParentID" });
            DropIndex("dbo.Project", new[] { "AdvoID" });
            DropTable("dbo.ParentChild");
            DropTable("dbo.Donor");
            DropTable("dbo.Parent");
            DropTable("dbo.Child");
            DropTable("dbo.Project");
            DropTable("dbo.Advo");
        }
    }
}
