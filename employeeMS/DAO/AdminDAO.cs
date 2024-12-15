using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using employeeMS.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace employeeMS.DAO
{
    internal class AdminDAO
    {
        const string connectionString = @"Data Source=HE-HE-HE;Initial Catalog=EmployeeMS;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connect = new SqlConnection(connectionString);
        public AdminDAO() { }
        public int ID { set; get; }
        public string AdminName { set; get; }
        public string Email { set; get; }
        public string AdminPassword { set; get; }

        public AdminDAO GetAdminByCredentials(string identifier, string identifierType)
        {
            try
            {
                connect.Open();

                // Determine the query based on the identifier type
                string query;

                if (identifierType.Equals("email"))
                {
                    query = "SELECT * FROM Admins WHERE email = @identifier";
                }
                else if (identifierType.Equals("username", StringComparison.OrdinalIgnoreCase))
                {
                    query = "SELECT * FROM Admins WHERE username = @identifier";
                }
                else
                {
                    throw new ArgumentException("Invalid identifier type. Use 'email' or 'username'.");
                }

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@identifier", identifier);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {    
                            return new AdminDAO
                            {
                                ID = Convert.ToInt32(reader["ad_id"]),
                                AdminName = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                AdminPassword = reader["password"].ToString()
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching user's data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
                return null;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool IsEmailExists(string email)
        {
            string query = "SELECT * FROM Admins WHERE email = @email";

            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Error fetching user's email data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
        
        public bool IsUsernameExists(string username)
        {
            string query = "SELECT * FROM Admins WHERE username = @username";

            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Error fetching username data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public void CreateAdminCredentials(string username, string password, string email)
        {
            string query = "INSERT INTO Admins(username, email, password) VALUES (@Username, @Email, @Password)";

            try
            {        
                connect.Open();

                // Create a command object
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    // Execute the query
                    cmd.ExecuteNonQuery();
                }      
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error creating user credentials:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                connect.Close();
            }
        }

        public void UpdatePassword(string password, string email)
        {
            string query = "UPDATE Admins SET password = @password WHERE email = @email";

            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {      
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating password:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
