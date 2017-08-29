namespace Jay.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Long(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 20),
                        Middlename = c.String(nullable: false, maxLength: 20),
                        Lastname = c.String(nullable: false, maxLength: 20),
                        Gender = c.String(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        DateOfHire = c.DateTime(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.EmploymentStatus",
                c => new
                    {
                        EmploymentStatusId = c.Long(nullable: false, identity: true),
                        Designation = c.String(nullable: false),
                        EmploymentAssignment = c.String(),
                        BasicSalary = c.Double(nullable: false),
                        EmployeeId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EmploymentStatusId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmploymentStatus", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmploymentStatus", new[] { "EmployeeId" });
            DropTable("dbo.EmploymentStatus");
            DropTable("dbo.Employees");
        }
    }
}
