namespace EFDemo.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId })
                .ForeignKey("dbo.Student", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", "CourseId", "dbo.Course");
            DropForeignKey("dbo.StudentCourse", "StudentId", "dbo.Student");
            DropIndex("dbo.StudentCourse", new[] { "CourseId" });
            DropIndex("dbo.StudentCourse", new[] { "StudentId" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Student");
            DropTable("dbo.Course");
        }
    }
}
