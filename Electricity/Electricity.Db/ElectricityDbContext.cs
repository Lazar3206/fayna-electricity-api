using Electricity.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Electricity.Db
{
    public class ElectricityDbContext : DbContext
    {
        public DbSet<ElectricitySwithRecord> ElectricitySwithRecords { get; set; }
    }
}