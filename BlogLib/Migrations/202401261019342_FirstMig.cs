namespace BlogLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminInfoes",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.BlogInfoes",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subject = c.String(),
                        DateOfCreation = c.DateTime(nullable: false),
                        BlogUrl = c.String(),
                        EmpEmailId = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.EmpInfoes",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmailId = c.String(),
                        Name = c.String(),
                        DateOfJoining = c.DateTime(nullable: false),
                        PassCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpInfoes");
            DropTable("dbo.BlogInfoes");
            DropTable("dbo.AdminInfoes");
        }
    }
}
