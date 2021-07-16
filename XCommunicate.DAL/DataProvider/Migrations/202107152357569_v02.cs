namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Groups", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Groups", "GroupDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Groups", "GroupAvatar", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Groups", "GroupAvatar", c => c.String());
            AlterColumn("dbo.Groups", "GroupDescription", c => c.String());
            AlterColumn("dbo.Groups", "Name", c => c.String());
        }
    }
}
