using PMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Services
{
    public class MedicineChartServices
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        int count;
        public void LoadChart()
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT COUNT(mName) FROM Medicine WHERE eDate >= GETDATE()";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    count= Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

    }
}
