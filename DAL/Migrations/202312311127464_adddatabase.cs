namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatabase : DbMigration
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
                "dbo.StudentCourses",
                c => new
                    {
                        StudentCourseId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentCourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
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
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        CommentTime = c.DateTime(nullable: false),
                        StudentId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        StudentId = c.Int(),
                        CommunityId = c.Int(),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Communities", t => t.CommunityId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CommunityId);
            
            CreateTable(
                "dbo.Communities",
                c => new
                    {
                        CommunityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommunityId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.CommunityStudents",
                c => new
                    {
                        CommunityStudentId = c.Int(nullable: false, identity: true),
                        CommunityId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommunityStudentId)
                .ForeignKey("dbo.Communities", t => t.CommunityId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CommunityId)
                .Index(t => t.StudentId);
            
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
                "dbo.Enrolls",
                c => new
                    {
                        EnrollId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(),
                        CourseId = c.Int(),
                        EnrollTime = c.DateTime(nullable: false),
                        PaymentAmount = c.Int(nullable: false),
                        TnxId = c.String(),
                    })
                .PrimaryKey(t => t.EnrollId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrolls", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrolls", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Assignments", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Assignments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Comments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Posts", "CommunityId", "dbo.Communities");
            DropForeignKey("dbo.Communities", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CommunityStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.CommunityStudents", "CommunityId", "dbo.Communities");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrolls", new[] { "CourseId" });
            DropIndex("dbo.Enrolls", new[] { "StudentId" });
            DropIndex("dbo.CommunityStudents", new[] { "StudentId" });
            DropIndex("dbo.CommunityStudents", new[] { "CommunityId" });
            DropIndex("dbo.Communities", new[] { "CourseId" });
            DropIndex("dbo.Posts", new[] { "CommunityId" });
            DropIndex("dbo.Posts", new[] { "StudentId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Comments", new[] { "StudentId" });
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "StudentId" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.Assignments", new[] { "CourseId" });
            DropIndex("dbo.Assignments", new[] { "TeacherId" });
            DropTable("dbo.Enrolls");
            DropTable("dbo.Teachers");
            DropTable("dbo.CommunityStudents");
            DropTable("dbo.Communities");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Students");
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Courses");
            DropTable("dbo.Assignments");
        }
    }
}
