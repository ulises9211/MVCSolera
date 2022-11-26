namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primarykey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductOrders");
            AddPrimaryKey("dbo.ProductOrders", new[] { "orderId", "productId" });
            DropColumn("dbo.ProductOrders", "id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductOrders", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ProductOrders");
            AddPrimaryKey("dbo.ProductOrders", "id");
        }
    }
}
