using Electricity.Db;
using Electricity.Db.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<ElectricitySwitchRecordController> _logger;
        private readonly ElectricityDbContext electricityDbContext;

        public DashboardController(
            ILogger<ElectricitySwitchRecordController> logger,
            ElectricityDbContext electricityDbContext)
        {
            _logger = logger;
            this.electricityDbContext = electricityDbContext;
        }

        [HttpGet]
        public DashboardResponse Get()
        {
            Microsoft.EntityFrameworkCore.DbSet<Db.Entities.ElectricitySwitchRecord> res = electricityDbContext.ElectricitySwitchRecord;
            var lst = res.ToList();
            return new DashboardResponse
            {
                ElectricitySwitchRecords = res.OrderBy(e => e.DateTime)
            };
        }
    }
}
