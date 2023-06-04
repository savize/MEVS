using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class RegVehiBll
    {
        RegVehiDal regveh = new RegVehiDal();
        public void Create(Vehicle v, User u)
        {
            regveh.Create(v, u);
        }

    }
}
