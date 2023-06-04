using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BankDll
    {
        DB db = new DB();

        public void Create(Bank b, User u)
        {
            b.EVUser = db.users.Find(u.Id);
            db.banks.Add(b);
            db.SaveChanges();
        }
    }
}
