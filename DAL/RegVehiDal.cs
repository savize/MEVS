using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegVehiDal
    {
        DB db = new DB();
        public void Create(Vehicle v, User u)
        {
            v.EVUsers = db.users.Find(u.Id);
            db.vehicles.Add(v);
            db.SaveChanges();
        }
    }
}
