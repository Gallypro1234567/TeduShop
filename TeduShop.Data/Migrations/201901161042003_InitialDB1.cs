namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderDetails", name: "ProductsID", newName: "ProductID");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_ProductsID", newName: "IX_ProductID");
            AddColumn("dbo.OrderDetails", "Quantitty", c => c.Int(nullable: false));
            DropColumn("dbo.OrderDetails", "Quantily");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "Quantily", c => c.Int(nullable: false));
            DropColumn("dbo.OrderDetails", "Quantitty");
            RenameIndex(table: "dbo.OrderDetails", name: "IX_ProductID", newName: "IX_ProductsID");
            RenameColumn(table: "dbo.OrderDetails", name: "ProductID", newName: "ProductsID");
        }
    }
}
