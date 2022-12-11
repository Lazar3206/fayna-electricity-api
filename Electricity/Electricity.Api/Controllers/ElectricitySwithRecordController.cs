using Microsoft.AspNetCore.Mvc;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricitySwithRecordController : ControllerBase
    {
        private readonly ILogger<ElectricitySwithRecordController> _logger;

        public ElectricitySwithRecordController(ILogger<ElectricitySwithRecordController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Guid Post()
        {
            return Guid.Empty;
        }
    }
}