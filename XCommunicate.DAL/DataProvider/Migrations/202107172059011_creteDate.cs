namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creteDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "CreateGroup", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "CreateGroup");
        }
    }
}
