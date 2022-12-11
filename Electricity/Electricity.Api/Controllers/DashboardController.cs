using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<ElectricitySwithRecordController> _logger;

        public DashboardController(ILogger<ElectricitySwithRecordController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public DashBoardResponse Get()
        {
            return new DashBoardResponse(); 
        }
    }
}
