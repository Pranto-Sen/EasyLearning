namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudentTeacher : DbMigration
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
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssignmentId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
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
                    })
                .PrimaryKey(t => t.CourseId);
            
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
            
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Course_CourseId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignments", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Assignments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.TeacherCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.TeacherCourses", "Teacher_TeacherId", "dbo.Teachers");
            DropIndex("dbo.TeacherCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.TeacherCourses", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Assignments", new[] { "CourseId" });
            DropIndex("dbo.Assignments", new[] { "TeacherId" });
            DropTable("dbo.TeacherCourses");
            DropTable("dbo.Students");
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Assignments");
        }
    }
}
