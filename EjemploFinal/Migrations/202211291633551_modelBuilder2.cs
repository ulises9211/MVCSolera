namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelBuilder2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductOrders", "productId", "dbo.Products");
            AddColumn("dbo.ProductOrders", "Product_id", c => c.Int());
            CreateIndex("dbo.ProductOrders", "Product_id");
            AddForeignKey("dbo.ProductOrders", "productId", "dbo.Products", "id");
            AddForeignKey("dbo.ProductOrders", "Product_id", "dbo.Products", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrders", "Product_id", "dbo.Products");
            DropForeignKey("dbo.ProductOrders", "productId", "dbo.Products");
            DropIndex("dbo.ProductOrders", new[] { "Product_id" });
            DropColumn("dbo.ProductOrders", "Product_id");
            AddForeignKey("dbo.ProductOrders", "productId", "dbo.Products", "id", cascadeDelete: true);
        }
    }
}
