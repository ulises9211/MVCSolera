namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "name", c => c.String());
        }
    }
}
