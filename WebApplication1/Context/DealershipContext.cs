using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DealershipContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DealershipContext(DbContextOptions<DealershipContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DevPlaceConnection"));
        }

        public DbSet<UserModel> userModels { get; set; }
        public DbSet<VehicleModel> vehicleModels { get; set; }
    }
}
