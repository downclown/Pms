using PMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Services
{
    public class CartServices
    {
        

        public int getRevenue()
        {
            //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
            string s = DbConfig.ConnectionString;
            int rev;
       
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT SUM(totalAmount) FROM Sale;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        
    }


    }
}
