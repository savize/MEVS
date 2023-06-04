using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB : DbContext
    {
        public DB() : base("ConnStr") { }
        public DbSet<User> users { get; set; }
        public DbSet<Vehicle> vehicles { get; set;}
        public DbSet<Bank> banks { get; set; }
        public DbSet<ChargingStation> chargingStations { get; set; }
        public DbSet<ChargingPoint> chargingPoints { get; set; }
        public DbSet<ServiceProvider> serviceProviders { get; set; }
        public DbSet<Plan> plans { get; set; }
    }
}
