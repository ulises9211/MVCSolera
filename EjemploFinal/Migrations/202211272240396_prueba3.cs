 namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "email", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "email", c => c.String());
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
