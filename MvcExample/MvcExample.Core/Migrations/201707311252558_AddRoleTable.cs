namespace MvcExample.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "auth.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("auth.Role");
        }
    }
}
