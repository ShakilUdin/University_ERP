namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnderGradStudent_GradStudent_Field_Added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.PhDStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.UnderGradStudents", "StudentId", c => c.Int(nullable: false));
            DropColumn("dbo.GradStudents", "VoterId");
            DropColumn("dbo.PartTimeStudents", "VoterId");
            DropColumn("dbo.PhDStudents", "VoterId");
            DropColumn("dbo.UnderGradStudents", "VoterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnderGradStudents", "VoterId", c => c.Int(nullable: false));
            AddColumn("dbo.PhDStudents", "VoterId", c => c.Int(nullable: false));
            AddColumn("dbo.PartTimeStudents", "VoterId", c => c.Int(nullable: false));
            AddColumn("dbo.GradStudents", "VoterId", c => c.Int(nullable: false));
            DropColumn("dbo.UnderGradStudents", "StudentId");
            DropColumn("dbo.PhDStudents", "StudentId");
            DropColumn("dbo.GradStudents", "StudentId");
        }
    }
}
