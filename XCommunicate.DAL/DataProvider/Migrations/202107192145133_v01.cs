namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        GroupRoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.GroupId })
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.GroupRoles", t => t.GroupRoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.GroupId)
                .Index(t => t.GroupRoleId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GroupDescription = c.String(nullable: false),
                        GroupAvatar = c.String(nullable: false),
                        GroupAvatarFullSize = c.String(),
                        CreateGroup = c.DateTime(nullable: false),
                        IsPrivate = c.Boolean(nullable: false),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        IsActive = c.Boolean(nullable: false),
                        Password = c.String(maxLength: 20),
                        EmailAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.EmailAddress, unique: true);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Country = c.String(maxLength: 30),
                        Town = c.String(maxLength: 30),
                        Avatar = c.String(),
                        AvatarFullSize = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProfiles", "UserId", "dbo.Users");
            DropForeignKey("dbo.GroupUsers", "GroupRoleId", "dbo.GroupRoles");
            DropForeignKey("dbo.GroupUsers", "GroupId", "dbo.Groups");
            DropIndex("dbo.UserProfiles", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "EmailAddress" });
            DropIndex("dbo.Users", new[] { "Name" });
            DropIndex("dbo.GroupUsers", new[] { "GroupRoleId" });
            DropIndex("dbo.GroupUsers", new[] { "GroupId" });
            DropIndex("dbo.GroupUsers", new[] { "UserId" });
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupUsers");
            DropTable("dbo.GroupRoles");
        }
    }
}
