namespace TLA.DataAccessLayer.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.Int(),
                        Online = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TrainerId = c.Int(),
                        AudienceId = c.Int(),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Audiences", t => t.AudienceId)
                .ForeignKey("dbo.Trainers", t => t.TrainerId)
                .Index(t => t.TrainerId)
                .Index(t => t.AudienceId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Extramural = c.Boolean(nullable: false),
                        Gender = c.String(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "TrainerId", "dbo.Trainers");
            DropForeignKey("dbo.Students", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Courses", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Groups", "AudienceId", "dbo.Audiences");
            DropIndex("dbo.Students", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "AudienceId" });
            DropIndex("dbo.Groups", new[] { "TrainerId" });
            DropIndex("dbo.Courses", new[] { "Group_Id" });
            DropTable("dbo.Trainers");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
            DropTable("dbo.Courses");
            DropTable("dbo.Audiences");
        }
    }
}
