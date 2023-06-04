using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaintainBll
    {
        MaintainDll mdll = new MaintainDll();

        public string Backup(string path)
        {
            return mdll.Backup(path);
        }

        public string Restore(string path)
        {
            return mdll.Restore(path);
        }
    }
}
