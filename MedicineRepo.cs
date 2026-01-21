using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PMS.Models
{
    public class MedicineRepo
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM Medicine";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Medicine m = new Medicine
                        {
                            MId = Convert.ToInt32(reader["MId"]),
                            MName = reader["MName"].ToString(),
                            MCompanyName = reader["MCompanyName"].ToString(),
                            MDate = reader["MDate"].ToString(),
                            EDate = reader["EDate"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PricePerUnit = Convert.ToDecimal(reader["PricePerUnit"])
                        };
                        medicines.Add(m);
                    }
                    con.Close();
                }
            }
            return medicines;
        }

        public void AddMedicine(Medicine m)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string insertQuery = "INSERT INTO Medicine ( MId,MName, MCompanyName, MDate, EDate, Quantity, PricePerUnit) VALUES (@MId, @MName, @MCompanyName,  @MDate, @EDate, @Quantity, @PricePerUnit)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MId", m.MId);
                        cmd.Parameters.AddWithValue("@MName", m.MName);
                        cmd.Parameters.AddWithValue("@MCompanyName", m.MCompanyName);
                        cmd.Parameters.AddWithValue("@MDate", m.MDate);
                        cmd.Parameters.AddWithValue("@EDate", m.EDate);
                        cmd.Parameters.AddWithValue("@Quantity", m.Quantity);
                        cmd.Parameters.AddWithValue("@PricePerUnit", m.PricePerUnit);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new ApplicationException("An error occurred while adding the medicine.", ex);
            }
        }

        public void UpdateMedicine(Medicine m)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string updateQuery = "UPDATE Medicine SET MName=@MName, MCompanyName=@MCompanyName,  MDate=@MDate, EDate=@EDate, Quantity=@Quantity, PricePerUnit=@PricePerUnit WHERE MId=@MId";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MId", m.MId);
                        cmd.Parameters.AddWithValue("@MName", m.MName);
                        cmd.Parameters.AddWithValue("@MCompanyName", m.MCompanyName);
                        cmd.Parameters.AddWithValue("@MDate", m.MDate);
                        cmd.Parameters.AddWithValue("@EDate", m.EDate);
                        cmd.Parameters.AddWithValue("@Quantity", m.Quantity);
                        cmd.Parameters.AddWithValue("@PricePerUnit", m.PricePerUnit);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new ApplicationException("An error occurred while updating the medicine.", ex);
            }
        }

        public void DeleteMedicine(int mId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM Medicine WHERE MId=@MId";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MId", mId);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw new ApplicationException("An error occurred while deleting the medicine.", ex);
            }

        }

        public Medicine GetMedicineById(int mId)
        {
            Medicine medicine = null;
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM Medicine WHERE MId=@MId";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MId", mId);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        medicine = new Medicine
                        {
                            MId = Convert.ToInt32(reader["MId"]),
                            MName = reader["MName"].ToString(),
                            MCompanyName = reader["MCompanyName"].ToString(),
                            MDate = reader["MDate"].ToString(),
                            EDate = reader["EDate"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PricePerUnit = Convert.ToDecimal(reader["PricePerUnit"])
                        };
                    }
                    con.Close();
                }
            }
            return medicine;
        }

        public Medicine GetMedicineByName(string name)
        {
            Medicine medicine = null;
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM Medicine WHERE MName=@mname";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@mname", name);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        medicine = new Medicine
                        {
                            MId = Convert.ToInt32(reader["MId"]),
                            MName = reader["MName"].ToString(),
                            MCompanyName = reader["MCompanyName"].ToString(),
                            MDate = reader["MDate"].ToString(),
                            EDate = reader["EDate"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PricePerUnit = Convert.ToDecimal(reader["PricePerUnit"])
                        };
                    }
                    con.Close();
                }
            }
            return medicine;
        }

        // update medicine code
        public void UpdateQuantity(int mId, long quantity)
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "UPDATE Medicine SET quantity=@q WHERE mId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@q", quantity);
                cmd.Parameters.AddWithValue("@id", mId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        // search medicine by name code (partially)
        public List<Medicine> GetMedicinesByName(string name)
        {
            List<Medicine> medicines = new List<Medicine>();

            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM Medicine WHERE MName LIKE @name";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%"); // partial match
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Medicine m = new Medicine
                        {
                            MId = Convert.ToInt32(reader["MId"]),
                            MName = reader["MName"].ToString(),
                            MCompanyName = reader["MCompanyName"].ToString(),
                            MDate = reader["MDate"].ToString(),
                            EDate = reader["EDate"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            PricePerUnit = Convert.ToDecimal(reader["PricePerUnit"])
                        };
                        medicines.Add(m);
                    }
                    con.Close();
                }
            }

            return medicines;
        }


    }
}
