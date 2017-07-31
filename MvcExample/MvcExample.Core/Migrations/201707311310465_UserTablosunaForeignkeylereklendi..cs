namespace MvcExample.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTablosunaForeignkeylereklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("auth.User", "RoleId", c => c.Int(nullable: false));
            AddColumn("auth.User", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("auth.User", "RoleId");
            CreateIndex("auth.User", "DepartmentId");
            AddForeignKey("auth.User", "DepartmentId", "auth.Department", "Id", cascadeDelete: true);
            AddForeignKey("auth.User", "RoleId", "auth.Role", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("auth.User", "RoleId", "auth.Role");
            DropForeignKey("auth.User", "DepartmentId", "auth.Department");
            DropIndex("auth.User", new[] { "DepartmentId" });
            DropIndex("auth.User", new[] { "RoleId" });
            DropColumn("auth.User", "DepartmentId");
            DropColumn("auth.User", "RoleId");
        }
    }
}
