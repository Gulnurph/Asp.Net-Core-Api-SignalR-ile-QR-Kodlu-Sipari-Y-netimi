using EntiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-M81HR9O7;Database=SignalRDb;MultipleActiveResultSets=True;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        public DbSet<About> About { get; set; }
        public DbSet<Booking> Booging { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Discount> Discount { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SocialMedya> SocialMedya { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }




    }
}
