namespace University_ERP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PHDAdvisor_Model_Updated_New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhDStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phdadvisor = c.String(maxLength: 250),
                        Firstname = c.String(maxLength: 10),
                        Lastname = c.String(maxLength: 10),
                        Streetaddress = c.String(maxLength: 300),
                        City = c.String(maxLength: 20),
                        Telephone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhDStudents");
        }
    }
}
