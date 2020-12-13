namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParTime_and_PHD_Student_Model_Added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartTimeStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Studentid = c.Int(nullable: false),
                        VoterId = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhDStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoterId = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.GradStudents", "Result", c => c.Int(nullable: false));
            AddColumn("dbo.UnderGradStudents", "Result", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UnderGradStudents", "Result");
            DropColumn("dbo.GradStudents", "Result");
            DropTable("dbo.PhDStudents");
            DropTable("dbo.PartTimeStudents");
        }
    }
}
