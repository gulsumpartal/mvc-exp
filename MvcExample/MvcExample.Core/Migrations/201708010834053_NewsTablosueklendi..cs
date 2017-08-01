namespace MvcExample.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewsTablosueklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "news.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Content = c.String(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("news.News");
        }
    }
}
