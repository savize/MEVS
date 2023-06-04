using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlanDal
    {
        DB db = new DB();
        public DataTable ReadPlans()
        {
            string cmd = "SELECT dbo.ServiceProviders.Id, dbo.Plans.Id AS [Item Id], dbo.ServiceProviders.CompanyName AS [Service Provider], dbo.Plans.Title AS [Plan Type], dbo.Plans.Duration AS [Duration (Months)], dbo.Plans.Description, dbo.Plans.Price AS [Price (RM)], \r\n                  dbo.Plans.ServiceProvider_Id\r\nFROM     dbo.Plans INNER JOIN\r\n                  dbo.ServiceProviders ON dbo.Plans.ServiceProvider_Id = dbo.ServiceProviders.Id\r\nWHERE  (dbo.ServiceProviders.IsActive = 1)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MEVSDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }

        public Plan ReadPlan(Plan p)
        {
            return db.plans.Include("ServiceProvider").Where(x => x.Id == p.Id).FirstOrDefault();
        }
        
    }
}
