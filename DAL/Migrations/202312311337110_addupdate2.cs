namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addupdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "StudentId" });
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            AlterColumn("dbo.StudentCourses", "StudentId", c => c.Int());
            AlterColumn("dbo.StudentCourses", "CourseId", c => c.Int());
            CreateIndex("dbo.StudentCourses", "StudentId");
            CreateIndex("dbo.StudentCourses", "CourseId");
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "CourseId");
            AddForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "CourseId" });
            DropIndex("dbo.StudentCourses", new[] { "StudentId" });
            AlterColumn("dbo.StudentCourses", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentCourses", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentCourses", "CourseId");
            CreateIndex("dbo.StudentCourses", "StudentId");
            AddForeignKey("dbo.StudentCourses", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
    }
}
