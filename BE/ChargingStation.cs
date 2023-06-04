using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ChargingStation
    {
        public int Id { get; set; }
        public string StationID { get; set; }
        public string State { get; set; }
        public string StationAddress { get; set; }
        public DateTime EstabDate { get; set; }
        public bool IsActive { get; set; }
        
        public ChargingStation() { IsActive = true; }


        public User User { get; set; }
        public List<ChargingPoint> ChargingPoints { get; set; } = new List<ChargingPoint>();
    }
}
