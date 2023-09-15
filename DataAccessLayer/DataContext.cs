using CommonLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Box> Boxes { get; set; }

        public DbSet<Sensor> Sensors { get; set; }

        public DbSet<SensorData> SensorsData { get; set; }
    }
}