namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnderGradStudent_Added : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "GradStudents");
            CreateTable(
                "dbo.UnderGradStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoterId = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.GradStudents", "VoterId", c => c.Int(nullable: false));
            DropColumn("dbo.GradStudents", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GradStudents", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.GradStudents", "VoterId", c => c.Int());
            DropTable("dbo.UnderGradStudents");
            RenameTable(name: "dbo.GradStudents", newName: "Students");
        }
    }
}
