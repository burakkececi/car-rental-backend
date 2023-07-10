using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalDbContext : DbContext
    {
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Staff> Staffs { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CarRental;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Booking>()
            .HasOne(b => b.DropOffLoc)
            .WithMany(l => l.DropOffBookings)
            .HasForeignKey(b => b.DropOffLocId);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.PickUpLoc)
                .WithMany(l => l.PickUpBookings)
                .HasForeignKey(b => b.PickUpLocId);

            //modelBuilder.Entity<Customer>()
            //    .HasKey(c => c.Id);

            //modelBuilder.Entity<Booking>()
            //    .HasOne(b => b.Customer)
            //    .WithOne(l => l.Booking)
            //    .HasForeignKey<Customer>(b => b.Id);

            //modelBuilder.Entity<Car>()
            //    .HasOne(b => b.Customer)
            //    .WithOne(l => l.Car)
            //    .HasForeignKey<Customer>(b => b.Id);
        }
    }
}
