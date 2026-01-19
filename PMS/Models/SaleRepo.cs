using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PMS.Models
{
    public class SaleRepo
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        public int Insert(Sale sale)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(s))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO Sale (customerName, totalAmount, saleDate)
                        VALUES (@cusName, @tAmount, @date);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cusName", sale.CustomerName);
                        cmd.Parameters.AddWithValue("@tAmount", sale.TotalAmount);
                        cmd.Parameters.AddWithValue("@date", sale.Date);

                        // 🔑 return the EXACT saleId
                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while inserting the sale.", ex);
            }

        }

        public int GetSaleID(string name)
        {
            using (SqlConnection conn = new SqlConnection(s))
            {
                conn.Open();
                string query = "SELECT saleId FROM Sale WHERE customerName = @cName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cName", name);
                   

                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
        }

    }
}
