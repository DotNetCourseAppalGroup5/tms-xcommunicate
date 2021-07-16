namespace DataProvider.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Size", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Size");
        }
    }
}
