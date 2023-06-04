using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegGenUserBll
    {
        RegGenUserDal regudal = new RegGenUserDal();

        public string Create(User u)
        {
            return regudal.Create(u); 
        }

        public User Login(string Username, string Pass)
        {
            return regudal.Login(Username, Pass);
        }

        public Vehicle ReadUVeh(User u)
        {
            return regudal.ReadUVeh(u);
        }

        public Bank ReadUBank(User u)
        {
            return regudal.ReadUBank(u);
        }

        public Plan ReadPlan(int id)
        {
            return regudal.ReadPlan(id);
        }
       
        public string UpPlan(User u, Plan p)
        {
            return regudal.UpPlan(u, p);
        }

        public User ReadUser(string s)
        {
            return regudal.ReadUser(s);
        }

        public Plan readSubsU(User u)
        {
            return regudal.readSubsU(u);
        }

        public string UpdateU(User u, Bank b, Vehicle v)
        {
            return regudal.UpdateU(u, b, v);
        }

        public static bool InputCheck(string FName, string Lname, string phone, string Email, string Username, string Pass)
        {
            bool ok = true;
            if (FName == "" || Lname == "" || phone == "" || Email == "" || Username == "" || Pass == "")
            {
                ok = false;
            }
            else
            {
                ok = true;
            }
            return ok;
        }
    }
}
