namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CommunityStudents", "StudentId", "dbo.Students");
            DropIndex("dbo.CommunityStudents", new[] { "StudentId" });
            AlterColumn("dbo.CommunityStudents", "StudentId", c => c.Int());
            CreateIndex("dbo.CommunityStudents", "StudentId");
            AddForeignKey("dbo.CommunityStudents", "StudentId", "dbo.Students", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CommunityStudents", "StudentId", "dbo.Students");
            DropIndex("dbo.CommunityStudents", new[] { "StudentId" });
            AlterColumn("dbo.CommunityStudents", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.CommunityStudents", "StudentId");
            AddForeignKey("dbo.CommunityStudents", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
        }
    }
}
