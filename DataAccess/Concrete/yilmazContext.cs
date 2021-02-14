
using Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete
{
    public class yilmazContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  optionsBuilder.UseSqlServer(@"Server = 175.145.2.2");
            optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database=Recapproject;Trusted_Connection=True");
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<Customer> Customer { get; set; }


        public DbSet<RentedCars> Rentals  { get; set; }
    }
}
