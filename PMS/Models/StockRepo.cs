using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Models
{

    public class StockRepo
    {
        private string connectionString = DbConfig.ConnectionString;

        // View all stock
        public DataTable GetAllStockView()
        {
            DataTable dt = new DataTable();

            string query = @"
            SELECT 
                m.mName AS Medicine,
                s.quantity AS Quantity,
                s.reorderLevel AS ReorderLevel
            FROM Stock s
            JOIN Medicine m ON s.mId = m.mId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // Low stock
        public DataTable GetLowStockView()
        {
            DataTable dt = new DataTable();

            string query = @"
            SELECT 
                m.mName AS Medicine,
                s.quantity AS Quantity,
                s.reorderLevel AS ReorderLevel
            FROM Stock s
            JOIN Medicine m ON s.mId = m.mId
            WHERE s.quantity <= s.reorderLevel";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // Out of stock
        public DataTable GetOutOfStockView()
        {
            DataTable dt = new DataTable();

            string query = @"
            SELECT 
                m.mName AS Medicine,
                s.quantity AS Quantity
            FROM Stock s
            JOIN Medicine m ON s.mId = m.mId
            WHERE s.quantity = 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public void InsertStock(Stock stock)
        {
            string query = @"INSERT INTO Stock (mId, quantity, reorderLevel)
                         VALUES (@mId, @quantity, @reorderLevel)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@mId", stock.MedicineId);
                cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                cmd.Parameters.AddWithValue("@reorderLevel", stock.ReorderLevel);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 3️⃣ Update stock quantity
        public void UpdateStockQuantity(int medicineId, int quantity)
        {
            string query = @"UPDATE Stock
                         SET quantity = @quantity
                         WHERE mId = @mId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@mId", medicineId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteStock(int stockId)
        {
            string query = "DELETE FROM Stock WHERE stockId = @stockId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@stockId", stockId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetStockForManagement()
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            s.stockId,
            s.mId,
            m.mName AS Medicine,
            s.quantity,
            s.reorderLevel
        FROM Stock s
        JOIN Medicine m ON s.mId = m.mId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public int GetTotalMedicineCount()
        {
            string query = "SELECT COUNT(*) FROM Stock";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetLowStockCount()
        {
            string query = @"
        SELECT COUNT(*) 
        FROM Stock
        WHERE quantity <= reorderLevel AND quantity > 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public int GetOutOfStockCount()
        {
            string query = "SELECT COUNT(*) FROM Stock WHERE quantity = 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

    }

}
