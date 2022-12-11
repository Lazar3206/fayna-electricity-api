using Electricity.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Electricity.Db
{
    public class ElectricityDbContext : DbContext
    {
        public ElectricityDbContext()
        {

        }
        public ElectricityDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=Electricity;Integrated Security=True;Trust Server Certificate=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //}

        public DbSet<ElectricitySwitchRecord> ElectricitySwitchRecords { get; set; }
    }
}