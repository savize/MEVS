using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SPDal
    {
        DB db = new DB();
        public void Create(ServiceProvider sp, User u)
        {
            sp.User = db.users.Find(u.Id);
            db.serviceProviders.Add(sp);
            db.SaveChanges();
        }
    }
}
