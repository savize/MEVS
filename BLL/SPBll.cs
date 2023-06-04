using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SPBll
    {
        SPDal SPDal = new SPDal();
        public void Create(ServiceProvider sp, User u)
        {
            SPDal.Create(sp, u);
        }

    }
}
