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
    public class PlanBll
    {
        PlanDal planDal = new PlanDal();
        public DataTable ReadPlans()
        {
           return planDal.ReadPlans();
        }

        public Plan ReadPlan(Plan p)
        {
            return planDal.ReadPlan(p);
        }

    }
}
