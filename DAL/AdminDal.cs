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
    public class AdminDal
    {
        DB db = new DB();
        public DataTable ReadEVOwners()
        {
            string cmd = "SELECT dbo.Users.Id, dbo.Users.FullName AS [Full Name], dbo.Users.Username, dbo.Users.Email, dbo.Users.Phone, dbo.Banks.Account AS [Bank Account], dbo.Vehicles.Brand AS [EV Brand], dbo.Vehicles.Model AS [EV Model], \r\n                  dbo.Vehicles.Address, dbo.Plans.Title AS [Plan Type], dbo.Users.PurchasedDate AS [Purchased On], dbo.Plans.Price AS [Plan Price], dbo.Plans.Duration AS [Plan Duration], dbo.Users.RegDate AS [Registration Date]\r\nFROM     dbo.Banks INNER JOIN\r\n                  dbo.Users ON dbo.Banks.EVUser_Id = dbo.Users.Id INNER JOIN\r\n                  dbo.Vehicles ON dbo.Users.Id = dbo.Vehicles.EVUsers_Id INNER JOIN\r\n                  dbo.Plans ON dbo.Users.Plan_Id = dbo.Plans.Id\r\nWHERE  (dbo.Users.UserCategory = N'EVOwner') AND (dbo.Users.IsActive = 1)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MEVSDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable ReadCS()
        {
            string cmd = "SELECT dbo.Users.Id, dbo.Users.FullName AS [Full Name], dbo.Users.Username, dbo.Users.Email, dbo.Users.Phone, dbo.ChargingStations.StationID AS [Station ID], dbo.ChargingStations.EstabDate AS [Establishment Date], \r\n                  dbo.ChargingStations.State, dbo.ChargingStations.StationAddress, dbo.ChargingPoints.ChargerCategory AS [Charger Type], dbo.ChargingPoints.ChName AS [Charger Name], dbo.ChargingPoints.Amount AS [Charger Amounts], \r\n                  dbo.Users.RegDate AS [Registration Date], dbo.ChargingStations.Id AS RId\r\nFROM     dbo.Users INNER JOIN\r\n                  dbo.ChargingStations ON dbo.Users.Id = dbo.ChargingStations.User_Id INNER JOIN\r\n                  dbo.ChargingPoints ON dbo.ChargingStations.Id = dbo.ChargingPoints.ChargingStation_Id\r\nWHERE  (dbo.Users.UserCategory = N'ChargingStation') AND (dbo.ChargingStations.IsActive = 1)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MEVSDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable ReadSP()
        {
            string cmd = "SELECT dbo.Users.Id, dbo.Users.FullName AS [Full Name], dbo.Users.Username, dbo.Users.Email, dbo.Users.Phone, dbo.ServiceProviders.CompanyName AS [Service Provider], dbo.ServiceProviders.EstablishDate AS [Establishment Date], \r\n                  dbo.Plans.Title AS [Plan Type], dbo.Plans.Description, dbo.Plans.Price AS [Price (RM)], dbo.Plans.Duration AS [Plan Length (Month)], dbo.Users.RegDate AS [Registration Date], dbo.ServiceProviders.Id AS RId\r\nFROM     dbo.Users INNER JOIN\r\n                  dbo.ServiceProviders ON dbo.Users.Id = dbo.ServiceProviders.User_Id INNER JOIN\r\n                  dbo.Plans ON dbo.ServiceProviders.Id = dbo.Plans.ServiceProvider_Id\r\nWHERE  (dbo.Users.UserCategory = N'Service Provider') AND (dbo.ServiceProviders.IsActive = 1)";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MEVSDB;Integrated Security=true");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }

        public string UpdateEVO(int id)
        {
            var q = db.users.Where(i=> i.Id == id).FirstOrDefault();
            q.IsActive = false;
            db.SaveChanges();
            return "Selected EV Owner has been deactivated.";
        }

        public string UpdateCS(int id)
        {
            var q = db.chargingStations.Where(x=> x.Id == id).FirstOrDefault();
            q.IsActive =false;
            db.SaveChanges();
            return "Selected Charging Station has been deactivated.";
        }

        public string UpdateSP(int id)
        {
            var q = db.serviceProviders.Where(y => y.Id == id).FirstOrDefault();
            q.IsActive = false;
            db.SaveChanges();
            return "Selected Charging Station has been deactivated.";
        }
    }
}
