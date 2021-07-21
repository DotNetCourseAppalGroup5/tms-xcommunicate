namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colleagues",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ColleaguesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ColleaguesId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
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
                "dbo.ConfirmationCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        EmailAddress = c.String(maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        Code = c.String(maxLength: 6),
                        IsConfirmed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityTypeId = c.Int(),
                        UploadedAt = c.DateTime(nullable: false),
                        UserId = c.Int(),
                        Content = c.String(),
                        Image = c.String(),
                        EntityParentId = c.Int(),
                        ParentGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EntityTypes", t => t.EntityTypeId)
                .ForeignKey("dbo.Groups", t => t.ParentGroupId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.EntityTypeId)
                .Index(t => t.UserId)
                .Index(t => t.ParentGroupId);
            
            CreateTable(
                "dbo.EntityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.EntityId })
                .ForeignKey("dbo.Entities", t => t.EntityId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.EntityId);
            
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
                "dbo.GroupRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromUserId = c.Int(),
                        ToUserId = c.Int(),
                        Content = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.FromUserId)
                .Index(t => t.FromUserId);
            
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
            
            CreateTable(
                "dbo.UserStateHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        UserStateId = c.Int(nullable: false),
                        StateUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.UserStates", t => t.UserStateId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.UserStateId);
            
            CreateTable(
                "dbo.UserStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStateHistory", "UserStateId", "dbo.UserStates");
            DropForeignKey("dbo.UserStateHistory", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProfiles", "UserId", "dbo.Users");
            DropForeignKey("dbo.Messages", "FromUserId", "dbo.Users");
            DropForeignKey("dbo.Entities", "UserId", "dbo.Users");
            DropForeignKey("dbo.Entities", "ParentGroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.GroupUsers", "GroupRoleId", "dbo.GroupRoles");
            DropForeignKey("dbo.GroupUsers", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Likes", "EntityId", "dbo.Entities");
            DropForeignKey("dbo.Entities", "EntityTypeId", "dbo.EntityTypes");
            DropForeignKey("dbo.ConfirmationCodes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Colleagues", "UserId", "dbo.Users");
            DropIndex("dbo.UserStates", new[] { "Name" });
            DropIndex("dbo.UserStateHistory", new[] { "UserStateId" });
            DropIndex("dbo.UserStateHistory", new[] { "UserId" });
            DropIndex("dbo.UserProfiles", new[] { "UserId" });
            DropIndex("dbo.Messages", new[] { "FromUserId" });
            DropIndex("dbo.GroupUsers", new[] { "GroupRoleId" });
            DropIndex("dbo.GroupUsers", new[] { "GroupId" });
            DropIndex("dbo.GroupUsers", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "EntityId" });
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropIndex("dbo.EntityTypes", new[] { "Name" });
            DropIndex("dbo.Entities", new[] { "ParentGroupId" });
            DropIndex("dbo.Entities", new[] { "UserId" });
            DropIndex("dbo.Entities", new[] { "EntityTypeId" });
            DropIndex("dbo.ConfirmationCodes", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "EmailAddress" });
            DropIndex("dbo.Users", new[] { "Name" });
            DropIndex("dbo.Colleagues", new[] { "UserId" });
            DropTable("dbo.UserStates");
            DropTable("dbo.UserStateHistory");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Messages");
            DropTable("dbo.GroupRoles");
            DropTable("dbo.GroupUsers");
            DropTable("dbo.Groups");
            DropTable("dbo.Likes");
            DropTable("dbo.EntityTypes");
            DropTable("dbo.Entities");
            DropTable("dbo.ConfirmationCodes");
            DropTable("dbo.Users");
            DropTable("dbo.Colleagues");
        }
    }
}
