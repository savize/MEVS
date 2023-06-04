using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MaintainDll
    {
        public string Backup(string path)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MEVSDB;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"backup database MEVSDB to disk = '" + path + @"MEVSBackup.bak'";
                cmd.ExecuteNonQuery();
                con.Close();
                return "Backup done successfully";
            }
            catch (Exception e)
            {

                return e.Message;
            }
         
        }

        public string Restore(string path)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"restore database MEVSDB from disk = '" + path + @"' with replace";
                cmd.ExecuteNonQuery();
                con.Close();
                return "System data recovered successfully";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
