using Electricity.Db.Entities;

namespace Electricity.Api
{
    public class DashBoardResponse
    {
        public IEnumerable<ElectricitySwithRecord> ElectricitySwithRecords { get; set; }
    }
}