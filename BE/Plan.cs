using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Plan
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }

        public string ShowList
        {
            get
            {
                return $"{Title}, RM {Price}, {Duration} months";
            }  
        }

        public ServiceProvider ServiceProvider { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
