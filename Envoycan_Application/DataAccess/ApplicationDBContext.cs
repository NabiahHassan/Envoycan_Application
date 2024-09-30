using Envoycan_Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Envoycan_Application.DataAccess
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer("@Server=LPT-NABIAHHASSA;Database=Envoycan_database;ConnectRetryCount=0"));
            services.AddControllersWithViews();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<UserRegistration_Model> User_registration { get; set; }

    }
}
