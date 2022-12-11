using Electricity.Db.Entities;

namespace Electricity.Api
{
    public class DashBoardResponse
    {
        public IEnumerable<ElectricitySwitchRecord> ElectricitySwithRecords { get; set; }
    }
}