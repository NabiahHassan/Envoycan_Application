using Envoycan_Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Envoycan_Application.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Services.ACRepair>().ToTable("ACRepair");
            modelBuilder.Entity<Services.Carpenter>().ToTable("Carpenter");
            modelBuilder.Entity<Services.HouseCleaning>().ToTable("HouseCleaning");
            modelBuilder.Entity<Services.Painter>().ToTable("Painter");
            modelBuilder.Entity<Services.PestControl>().ToTable("PestControl");
            modelBuilder.Entity<Services.Plumber>().ToTable("Plumber");
            modelBuilder.Entity<Services.Salon>().ToTable("Salon");
            modelBuilder.Entity<Services.SmartHome>().ToTable("SmartHome");

        }
        public DbSet<UserRegistration_Model> User_registration { get; set; }
        public DbSet<Services.ACRepair> ACRepiar { get; set; }
        public DbSet<Services.Carpenter> Carpenter{ get; set; }
        public DbSet<Services.HouseCleaning> HouseCleaning { get; set; }
        public DbSet<Services.Painter> Painter { get; set; }
        public DbSet<Services.PestControl> PestControl { get; set; }
        public DbSet<Services.Plumber> Plumber { get; set; }
        public DbSet<Services.Salon> Salon { get; set; }   
        public DbSet<Services.SmartHome> SmartHome { get; set; }

    }
}
