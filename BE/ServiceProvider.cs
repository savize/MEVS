using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime EstablishDate { get; set; }
        public bool IsActive { get; set; }

        public ServiceProvider()
        {
            IsActive = true;
        }
        public List<Plan> plans { get; set; } = new List<Plan>();
        public User User { get; set; }
    }
}
