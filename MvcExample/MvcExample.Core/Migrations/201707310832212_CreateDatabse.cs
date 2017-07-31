namespace MvcExample.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "auth.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false),
                        Firstname = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("auth.User");
        }
    }
}
