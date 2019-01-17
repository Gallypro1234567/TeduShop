namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.ProductCategories", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.ProductCategories", "Image", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "Image", c => c.String());
            AlterColumn("dbo.ProductCategories", "Description", c => c.String());
            AlterColumn("dbo.ProductCategories", "Alias", c => c.String());
        }
    }
}
