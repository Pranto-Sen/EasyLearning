namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        AssignmentId = c.Int(nullable: false, identity: true),
                        AssignmentName = c.String(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        Mark = c.Int(nullable: false),
                        TeacherId = c.Int(),
                        CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.AssignmentId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        TeachingExperience = c.String(nullable: false),
                        TeachingDomain = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        Institute = c.String(nullable: false),
                        Education = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Assignments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Assignments", new[] { "CourseId" });
            DropIndex("dbo.Assignments", new[] { "TeacherId" });
            DropTable("dbo.Students");
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Assignments");
        }
    }
}
