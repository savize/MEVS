using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        public int Id { get; set; }
        public string UserCategory { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public List<Nullable<int>> ChargedTimes { get; set; }
        public List<Nullable<int>> Paid { get; set; }

        public DateTime RegDate { get; set; }
        public Nullable<DateTime> PurchasedDate { get; set; }

        public bool IsActive { get; set; }

        public User() 
        { 
            IsActive = true;
        }
        public List<ChargingStation> CSs { get; set; } = new List<ChargingStation>();      
        public Plan Plan { get; set; }

    }
}
