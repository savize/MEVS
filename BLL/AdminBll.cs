using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class AdminBll
    {
        AdminDal ADal = new AdminDal();
        public DataTable ReadEVOwners()
        {
          return ADal.ReadEVOwners();
        }

        public DataTable ReadCS()
        {
            return ADal.ReadCS();
        }

        public DataTable ReadSP() { return ADal.ReadSP(); }

        public string UpdateEVO(int id)
        {
            return ADal.UpdateEVO(id);
        }

        public string UpdateCS(int id)
        {
            return ADal.UpdateCS(id);
        }

        public string UpdateSP(int id)
        {
            return ADal.UpdateSP(id);
        }

    }
}
