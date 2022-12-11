using Electricity.Db;
using Microsoft.AspNetCore.Mvc;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<ElectricitySwithRecordController> _logger;
        private readonly ElectricityDbContext electricityDbContext;

        public DashboardController(
            ILogger<ElectricitySwithRecordController> logger,
            ElectricityDbContext electricityDbContext)
        {
            _logger = logger;
            this.electricityDbContext = electricityDbContext;
        }

        [HttpGet]
        public DashBoardResponse Get()
        {
            Microsoft.EntityFrameworkCore.DbSet<Db.Entities.ElectricitySwitchRecord> res = electricityDbContext.ElectricitySwitchRecord;
            var lst = res.ToList();
            return new DashBoardResponse
            {
                ElectricitySwithRecords = res
            };
        }
    }
}
