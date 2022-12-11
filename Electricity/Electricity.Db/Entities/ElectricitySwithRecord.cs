using Electricity.Db.Enums;

namespace Electricity.Db.Entities
{
    public class ElectricitySwithRecord
    {
        public int Id { get; set; }
        public Guid ElectricitySwithRecordKey { get; set; }
        public SwitchType SwitchType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
