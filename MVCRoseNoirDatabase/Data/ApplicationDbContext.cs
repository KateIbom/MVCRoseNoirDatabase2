
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCRoseNoirDatabase.Models;

namespace MVCRoseNoirDatabase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }

        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentCard> Paymentcard { get; set; }

        public DbSet<Order> Order { get;set; }

        public DbSet<OrderItem> OderItems  { get; set; }

        //public DbSet<ProductIngredient> ProductIngredients { get; set; }

        //public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        public DbSet<Customer> Customers { get; set; }


    }
}