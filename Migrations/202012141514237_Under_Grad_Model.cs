namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Under_Grad_Model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GradStudents", "Thesis", c => c.String());
            AddColumn("dbo.GradStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.PartTimeStudents", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.UnderGradStudents", "StudentId", c => c.Int(nullable: false));
            DropTable("dbo.PhDStudents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PhDStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Result = c.Int(nullable: false),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.UnderGradStudents", "StudentId");
            DropColumn("dbo.PartTimeStudents", "StudentId");
            DropColumn("dbo.GradStudents", "StudentId");
            DropColumn("dbo.GradStudents", "Thesis");
        }
    }
}
