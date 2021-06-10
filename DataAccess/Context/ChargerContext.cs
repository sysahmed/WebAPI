using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class ChargerContext:DbContext
    {
        public ChargerContext()
        {

        }
        public ChargerContext(DbContextOptions<ChargerContext> options):base(options)
        {

        }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<ChargePoint> ChargePoints { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = Ahmed ; Initial catalog = Charger; User Id = User; Password=Password");
            }
        }

    }
}
