using Electricity.Db;
using Electricity.Db.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricitySwitchRecordController : ControllerBase
    {
        private readonly ILogger<ElectricitySwitchRecordController> _logger;
        private readonly ElectricityDbContext electricityDbContext;

        public ElectricitySwitchRecordController(
            ILogger<ElectricitySwitchRecordController> logger,
            ElectricityDbContext electricityDbContext)
        {
            _logger = logger;
            this.electricityDbContext = electricityDbContext;
        }

        [HttpPost]
        public Guid Post([FromBody] ElectricitySwitchRecord electricitySwitchRecord)
        {
            electricitySwitchRecord.ElectricitySwithRecordKey = Guid.NewGuid();
            electricityDbContext.Add(electricitySwitchRecord);
            electricityDbContext.SaveChanges();
            return electricitySwitchRecord.ElectricitySwithRecordKey;
        }
    }
}