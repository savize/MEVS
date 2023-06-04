using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ChargingPoint
    {
        public int Id { get; set; }
        public string ChargerCategory { get; set; }
        public string ChName { get; set; }
        public int Amount { get; set; }

        public ChargingStation ChargingStation { get; set; }

        public string ListBox
        {
            get
            {
                return $"{ChargerCategory}, {ChName}, Nozzles: {Amount}";
            }
        }
    }
}
