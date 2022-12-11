using Electricity.Db.Entities;

namespace Electricity.Api
{
    public class DashboardResponse
    {
        public IEnumerable<ElectricitySwitchRecord> ElectricitySwitchRecords { get; set; }
    }
}