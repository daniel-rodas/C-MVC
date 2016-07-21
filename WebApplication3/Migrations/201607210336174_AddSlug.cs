namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSlug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Slug", c => c.String());
            AddColumn("dbo.Products", "Slug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Slug");
            DropColumn("dbo.Categories", "Slug");
        }
    }
}
