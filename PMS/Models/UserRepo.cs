using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace PMS.Models
{
    public class UserRepo
    {
        //string s = @"Data Source=DESKTOP-L4K97ST\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=True";
        string s = DbConfig.ConnectionString;

        // Get or Retrieve all users
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM UserAccounts";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User u = new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Fullname = reader["Fullname"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Usertype = reader["Usertype"].ToString()
                        };
                        users.Add(u);
                    }
                    con.Close();
                }
            }

                    return users;
        }

        //Add Users
        public void AddUser(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(s))
                {
                    con.Open();
                    string insertQuery = "INSERT INTO UserAccounts (Fullname, Username, Password, PhoneNumber, Email, Usertype) VALUES (@Fullname, @Username, @Password, @PhoneNumber, @Email, @Usertype)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Fullname", u.Fullname);
                        cmd.Parameters.AddWithValue("@Username", u.Username);
                        cmd.Parameters.AddWithValue("@Password", u.Password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", u.Email);
                        cmd.Parameters.AddWithValue("@Usertype", u.Usertype);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {
                if(ex.Number == 2627 || ex.Number == 2601) // Unique constraint error number
                {
                    throw new Exception("A user with this username already exists.");
                }
                else
                {
                    throw; // Rethrow other SQL exceptions
                }
            }

        }

        //Delete Users
        public void DeleteUser(int id)
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string deleteQuery = "DELETE FROM UserAccounts WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Update Users
        public void UpdateUser(User u)
        {
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string updateQuery = "UPDATE UserAccounts SET Fullname = @Fullname, Password = @Password, PhoneNumber = @PhoneNumber, Email = @Email, Usertype = @Usertype WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Fullname", u.Fullname);
                    cmd.Parameters.AddWithValue("@Password", u.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", u.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", u.Email);
                    cmd.Parameters.AddWithValue("@Usertype", u.Usertype);
                    cmd.Parameters.AddWithValue("@Username", u.Username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Get User by Username 
        public User GetUserByUsername(string username)
        {
            User user = null;
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM UserAccounts WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Fullname = reader["Fullname"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Usertype = reader["Usertype"].ToString()
                        };
                    }
                    con.Close();
                }
            }
            return user;
        }

        public User GetUserByID(int id)
        {
            User user = null;
            using (SqlConnection con = new SqlConnection(s))
            {
                string query = "SELECT * FROM UserAccounts WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new User
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Fullname = reader["Fullname"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            Usertype = reader["Usertype"].ToString()
                        };
                    }
                    con.Close();
                }
            }
            return user;
        }

    }


}
