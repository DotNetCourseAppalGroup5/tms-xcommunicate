namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crete1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GroupDescription = c.String(),
                        GroupAvatar = c.String(),
                        IsPrivate = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GroupRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.GroupRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupUserGroups",
                c => new
                    {
                        GroupUser_Id = c.Int(nullable: false),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GroupUser_Id, t.Group_Id })
                .ForeignKey("dbo.GroupUsers", t => t.GroupUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.GroupUser_Id)
                .Index(t => t.Group_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupUsers", "RoleId", "dbo.GroupRoles");
            DropForeignKey("dbo.GroupUserGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.GroupUserGroups", "GroupUser_Id", "dbo.GroupUsers");
            DropIndex("dbo.GroupUserGroups", new[] { "Group_Id" });
            DropIndex("dbo.GroupUserGroups", new[] { "GroupUser_Id" });
            DropIndex("dbo.GroupUsers", new[] { "RoleId" });
            DropTable("dbo.GroupUserGroups");
            DropTable("dbo.GroupRoles");
            DropTable("dbo.GroupUsers");
            DropTable("dbo.Groups");
        }
    }
}
