namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSize1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Colleagues", "UserId", "dbo.Users");
            DropForeignKey("dbo.ConfirmationCodes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Entities", "EntityTypeId", "dbo.EntityTypes");
            DropForeignKey("dbo.Likes", "EntityId", "dbo.Entities");
            DropForeignKey("dbo.Likes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Entities", "ParentGroupId", "dbo.Groups");
            DropForeignKey("dbo.Entities", "UserId", "dbo.Users");
            DropForeignKey("dbo.Messages", "FromUserId", "dbo.Users");
            DropForeignKey("dbo.UserStateHistory", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserStateHistory", "UserStateId", "dbo.UserStates");
            DropIndex("dbo.Colleagues", new[] { "UserId" });
            DropIndex("dbo.ConfirmationCodes", new[] { "UserId" });
            DropIndex("dbo.Entities", new[] { "EntityTypeId" });
            DropIndex("dbo.Entities", new[] { "UserId" });
            DropIndex("dbo.Entities", new[] { "ParentGroupId" });
            DropIndex("dbo.EntityTypes", new[] { "Name" });
            DropIndex("dbo.Likes", new[] { "UserId" });
            DropIndex("dbo.Likes", new[] { "EntityId" });
            DropIndex("dbo.Messages", new[] { "FromUserId" });
            DropIndex("dbo.UserStateHistory", new[] { "UserId" });
            DropIndex("dbo.UserStateHistory", new[] { "UserStateId" });
            DropIndex("dbo.UserStates", new[] { "Name" });
            DropTable("dbo.Colleagues");
            DropTable("dbo.ConfirmationCodes");
            DropTable("dbo.Entities");
            DropTable("dbo.EntityTypes");
            DropTable("dbo.Likes");
            DropTable("dbo.Messages");
            DropTable("dbo.UserStateHistory");
            DropTable("dbo.UserStates");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserStateHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        UserStateId = c.Int(nullable: false),
                        StateUpdate = c.DateTime(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.EntityId });
            
            CreateTable(
                "dbo.EntityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colleagues",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ColleaguesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ColleaguesId });
            
            CreateIndex("dbo.UserStates", "Name", unique: true);
            CreateIndex("dbo.UserStateHistory", "UserStateId");
            CreateIndex("dbo.UserStateHistory", "UserId");
            CreateIndex("dbo.Messages", "FromUserId");
            CreateIndex("dbo.Likes", "EntityId");
            CreateIndex("dbo.Likes", "UserId");
            CreateIndex("dbo.EntityTypes", "Name", unique: true);
            CreateIndex("dbo.Entities", "ParentGroupId");
            CreateIndex("dbo.Entities", "UserId");
            CreateIndex("dbo.Entities", "EntityTypeId");
            CreateIndex("dbo.ConfirmationCodes", "UserId");
            CreateIndex("dbo.Colleagues", "UserId");
            AddForeignKey("dbo.UserStateHistory", "UserStateId", "dbo.UserStates", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserStateHistory", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Messages", "FromUserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Entities", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Entities", "ParentGroupId", "dbo.Groups", "Id");
            AddForeignKey("dbo.Likes", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Likes", "EntityId", "dbo.Entities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Entities", "EntityTypeId", "dbo.EntityTypes", "Id");
            AddForeignKey("dbo.ConfirmationCodes", "UserId", "dbo.Users", "Id");
            AddForeignKey("dbo.Colleagues", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
