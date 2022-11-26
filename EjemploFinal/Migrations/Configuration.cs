namespace EjemploFinal.Migrations
{
    using EjemploFinal.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EjemploFinal.Models.ApplicationDbContext>
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductOrder> productsOrder { get; set; }
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EjemploFinal.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
