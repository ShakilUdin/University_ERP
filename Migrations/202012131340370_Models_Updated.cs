namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models_Updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PartTimeStudents", "VoterId", c => c.Int(nullable: false));
            DropColumn("dbo.GradStudents", "StudentId");
            DropColumn("dbo.PartTimeStudents", "Studentid");
            DropColumn("dbo.PhDStudents", "StudentId");
            DropColumn("dbo.UnderGradStudents", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnderGradStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.PhDStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.PartTimeStudents", "Studentid", c => c.Int(nullable: false));
            AddColumn("dbo.GradStudents", "StudentId", c => c.Int(nullable: false));
            DropColumn("dbo.PartTimeStudents", "VoterId");
        }
    }
}
