namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee_FullTimeFaculty_LabManager_Secretary_LabManager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Empid = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Department = c.String(maxLength: 50),
                        Telephone = c.Int(nullable: false),
                        Voterid = c.Int(),
                        Voterid1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.GradStudents", "Result");
            DropColumn("dbo.PartTimeStudents", "Result");
            DropColumn("dbo.UnderGradStudents", "Result");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UnderGradStudents", "Result", c => c.Int(nullable: false));
            AddColumn("dbo.PartTimeStudents", "Result", c => c.Int(nullable: false));
            AddColumn("dbo.GradStudents", "Result", c => c.Int(nullable: false));
            DropTable("dbo.Employees");
        }
    }
}
