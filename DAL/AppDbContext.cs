using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ramirez_Mackenzie_HW4.Models;


namespace Ramirez_Mackenzie_HW4.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //this code makes sure the database is re-created on the $5/month Azure tier
            builder.HasPerformanceLevel("Basic");
            builder.HasServiceTier("Basic");
            base.OnModelCreating(builder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Add Dbsets here.  Products is included as an example.
        public DbSet<Product> Products { get; set; }
    }
}
