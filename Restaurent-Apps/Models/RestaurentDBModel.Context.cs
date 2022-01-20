using Restaurent_Apps.Models;

namespace Restaurent_Apps
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class RestaurantDBEntities : DbContext
    {
        public RestaurantDBEntities()
            : base("name=RestaurantDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
    }
}