namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelBuilder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "customerId", "dbo.Customers");
            AddColumn("dbo.Orders", "Customer_id", c => c.Int());
            CreateIndex("dbo.Orders", "Customer_id");
            AddForeignKey("dbo.Orders", "Customer_id", "dbo.Customers", "id");
            AddForeignKey("dbo.Orders", "customerId", "dbo.Customers", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "customerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Customer_id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Customer_id" });
            DropColumn("dbo.Orders", "Customer_id");
            AddForeignKey("dbo.Orders", "customerId", "dbo.Customers", "id", cascadeDelete: true);
        }
    }
}
