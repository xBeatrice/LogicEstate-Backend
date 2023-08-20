using System.Data.Entity;
using System.Collections.Generic;

namespace LogicEstate.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection")
        {
        }

        // DbSet representing your property data model
        public DbSet<HomeEntity> Homes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure your model here if needed
        }

        
    }
}
