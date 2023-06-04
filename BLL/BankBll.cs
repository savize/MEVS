using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BankBll
    {
        BankDll bankD = new BankDll();

        public void Create(Bank b, User u)
        {
            bankD.Create(b,u);
        }
    }
}
