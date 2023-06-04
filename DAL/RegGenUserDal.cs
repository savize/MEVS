using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegGenUserDal
    {
        DB db = new DB();
        public string Create(User u)
        {
            db.users.Add(u);
            db.SaveChanges();
            return "Registration is done.";
        }

        public User Login(string Username, string Pass)
        {
            return db.users.Where(i => i.Username == Username && i.Password == Pass).FirstOrDefault();
        }

        public Vehicle ReadUVeh(User u)
        {
            return db.vehicles.Include("EVUsers").Where(q => q.EVUsers.Id == u.Id).FirstOrDefault();
        }

        public Bank ReadUBank(User u)
        {
            return db.banks.Include("EVUser").Where(b => b.EVUser.Id == u.Id).FirstOrDefault();
        }

        public Plan ReadPlan(int id)
        {
            return db.plans.Where(a => a.Id == id).FirstOrDefault();
        }

        public string UpPlan(User u, Plan p)
        {
            var q = db.users.Where(s => s.Id == u.Id).FirstOrDefault();
            q.Plan = db.plans.Find(p.Id);
            q.PurchasedDate = DateTime.Now.Date;

            db.SaveChanges();
            return "Your plan is updated.";
        }

        public User ReadUser(string s)
        {
            return db.users.Where(f => f.FullName == s).FirstOrDefault();
        }


        public Plan readSubsU(User u)
        {
            User q = db.users.Include("Plan").Where(i => i.Id == u.Id).FirstOrDefault();
            return q.Plan;
        }

        public string UpdateU(User u, Bank b, Vehicle v)
        {
            var q = db.users.Where(n => n.Id == u.Id).FirstOrDefault();
            var t = db.banks.Include("EVUser").Where(e => e.EVUser.Id == u.Id).FirstOrDefault();
            var w = db.vehicles.Include("EVUsers").Where(r => r.EVUsers.Id == u.Id).FirstOrDefault();

            try
            {
                if (q != null && t != null && w != null)
                {
                    q.Username = u.Username;
                    q.Password = u.Password;
                    q.FullName = u.FullName;
                    q.Email = u.Email;
                    q.Phone = u.Phone;
                    t.Account = b.Account;
                    w.Address = v.Address;
                    w.Brand = v.Brand;
                    w.Model = v.Model;
                    db.SaveChanges();
                    return "Data updated successfully.";
                }
                else
                {
                    return "User is not exist.";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
