namespace EjemploFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyTableAndColumnsName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Client");
            RenameColumn(table: "dbo.Client", name: "name", newName: "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Client", name: "FirstName", newName: "name");
            RenameTable(name: "dbo.Client", newName: "Customers");
        }
    }
}
