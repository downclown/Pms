using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace PMS.Models
{
    public class SaleDetailsRepo
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;
        // Insert a SaleDetails record
        public void Insert(SaleDetails saleDetail)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();

                    string query = @"INSERT INTO SaleDetails (saleId, mId, quantity, pricePerUnit) 
                                     VALUES (@saleId, @mId,  @quantity, @pricePerUnit)";



                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@saleId", saleDetail.SaleId);
                        cmd.Parameters.AddWithValue("@mId", saleDetail.MId);
                      //  cmd.Parameters.AddWithValue("@mName", saleDetail.MName);
                        cmd.Parameters.AddWithValue("@quantity", saleDetail.Quantity);
                        cmd.Parameters.AddWithValue("@pricePerUnit", saleDetail.PricePerUnit);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inserting sale detail: " + ex.Message, ex);
            }
        }

        // Optional: Get all sale details for a specific sale
        public System.Data.DataTable GetBySaleId(int saleId)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string query = @"SELECT * FROM SaleDetails WHERE saleId = @saleId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@saleId", saleId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error retrieving sale details: " + ex.Message, ex);
            }

            return dt;
        }
    }
}
