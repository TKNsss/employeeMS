using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using employeeMS.Utils;
using System.Windows.Forms;
using employeeMS.DAO;

namespace employeeMS
{
    internal class EmployeeDAO
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MRKIM08\SQLEXPRESS;Initial Catalog=employeeMS;Integrated Security=True;TrustServerCertificate=True");

        public string ID { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Phone { set; get; }
        public string Gender { set; get; }
        public DateTime? DateOB { set; get; }
        public string Address { set; get; }
        public string Role { set; get; }
        public string Position { set; get; }
        public float BaseSalary { set; get; }
        public float NetSalary { set; get; }
        public float AllowanceLevel { set; get; }
        public float CoefLevel { set; get; }
        public int PositionID { set; get; }
        public EmployeeDAO() {}

        public int DisplayTotalEmployee()
        {
            int totalCount = 0;

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) AS totalEmployees FROM Employees";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalCount = (int)reader["totalEmployees"];
                        }
                    }
                }             
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching total amount of employee:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return totalCount;
        }

        public int DisplayTotalRoleMember(string roleName)
        {
            int totalCount = 0;

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) AS totalRoleMember FROM Roles WHERE role_name = @roleName";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@roleName", roleName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalCount = (int)reader["totalRoleMember"];
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching total amount of staff:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return totalCount;
        }

        public List<EmployeeDAO> GetEmployeeData()
        {
            List<EmployeeDAO> listData = new List<EmployeeDAO>();
      
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT DISTINCT em.em_id AS eID, firstname, lastname, phone, gender, dob, address, base_salary, net_salary, title, sal_col_level, role_name, al_level "
                                + "FROM Employees AS em "
                                + "LEFT JOIN Positions AS pos ON em.pos_id = pos.pos_id "
                                + "LEFT JOIN Salaries AS sal ON sal.em_id = em.em_id "
                                + "LEFT JOIN Roles AS ro ON em.em_id = ro.em_id "
                                + "LEFT JOIN Allowances AS al ON ro.role_id = al.role_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeDAO addED = new EmployeeDAO();

                        addED.ID = reader["eID"].ToString();
                        addED.Firstname = reader["firstname"].ToString();
                        addED.Lastname = reader["lastname"].ToString();
                        addED.Phone = reader["phone"].ToString();
                        addED.Gender = reader["gender"].ToString();

                        // Check if the dob column is DBNull (null in the database)
                        if (reader.IsDBNull(reader.GetOrdinal("dob")))
                        {
                            addED.DateOB = null;  // If it's DBNull, set to null
                        }
                        else
                        {
                            addED.DateOB = reader.GetDateTime(reader.GetOrdinal("dob"));  
                        }
                        addED.Address = reader["address"].ToString();
                        addED.Role = reader["role_name"].ToString();
                        addED.Position = reader["title"].ToString();
                        addED.BaseSalary = reader["base_salary"] != DBNull.Value ? Convert.ToSingle(reader["base_salary"]) : 0f;
                        addED.NetSalary = reader["net_salary"] != DBNull.Value ? Convert.ToSingle(reader["net_salary"]) : 0f;
                        addED.AllowanceLevel = reader["al_level"] != DBNull.Value ? Convert.ToSingle(reader["al_level"]) : 0f;
                        addED.CoefLevel = reader["sal_col_level"] != DBNull.Value ? Convert.ToSingle(reader["sal_col_level"]) : 0f;

                        listData.Add(addED);
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching employee's data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }           
            return listData;
        }

        public event Action EmployeeDataChanged;

        public void AddEmployeeData(EmployeeDAO em, RoleDAO RoleObj)
        {     
            if (IsPhoneExists(em.Phone, null) || IsIDExists(em.ID))
            {
                MessageBox.Show("Phone number/ID has existed, please choose another one!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query1 = "INSERT INTO Employees(em_id, firstname, lastname, phone, gender, dob, address, pos_id) VALUES (@ID, @FirstName, @LastName, @Phone, @Gender, @DOB, @Address, @PositionID)";
            string query2 = "INSERT INTO Roles(em_id, role_name) VALUES(@EmID, @Role)";

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                // Begin a transaction
                using (SqlTransaction transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Insert into Employees
                        using (SqlCommand cmd1 = new SqlCommand(query1, connect, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@ID", em.ID);
                            cmd1.Parameters.AddWithValue("@FirstName", em.Firstname);
                            cmd1.Parameters.AddWithValue("@LastName", em.Lastname);
                            cmd1.Parameters.AddWithValue("@Phone", em.Phone);
                            cmd1.Parameters.AddWithValue("@Gender", em.Gender);
                            cmd1.Parameters.AddWithValue("@DOB", em.DateOB);
                            cmd1.Parameters.AddWithValue("@Address", em.Address);
                            cmd1.Parameters.AddWithValue("@PositionID", em.PositionID);

                            cmd1.ExecuteNonQuery();
                        }

                        // Insert into Roles
                        using (SqlCommand cmd2 = new SqlCommand(query2, connect, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@EmID", RoleObj.EmID);
                            cmd2.Parameters.AddWithValue("@Role", RoleObj.RoleName);

                            cmd2.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeDataChanged?.Invoke();
                    }
                    catch (SqlException ex)
                    {
                        // Roll back the transaction in case of error
                        transaction.Rollback();
                        MessageBox.Show($"Error adding Employee:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validator.PrintSQLExceptionError(ex);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database connection error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void UpdateEmployeeData(EmployeeDAO em, RoleDAO roleObj)
        {
            if (IsPhoneExists(em.Phone, em.ID))
            {
                MessageBox.Show("Phone number has existed, please choose another one!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query1 = "UPDATE Employees SET firstname = @firstname, lastname = @lastname, phone = @phone, gender = @gender, dob = @dob, address = @address, pos_id = @pos_id WHERE em_id = @em_id";
            string query2 = "UPDATE Roles SET role_name = @role_name WHERE em_id = @em_id";

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                // Begin a transaction
                using (SqlTransaction transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Insert into Employees
                        using (SqlCommand cmd1 = new SqlCommand(query1, connect, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@firstname", em.Firstname);
                            cmd1.Parameters.AddWithValue("@lastname", em.Lastname);
                            cmd1.Parameters.AddWithValue("@phone", em.Phone);
                            cmd1.Parameters.AddWithValue("@gender", em.Gender);

                            // Convert DOB to SQL Date
                            if (em.DateOB != null)
                            {
                                cmd1.Parameters.AddWithValue("@dob", em.DateOB);
                            }
                            else
                            {
                                MessageBox.Show("Date of birth cannot be null.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                transaction.Rollback();
                                return;
                            }
                            cmd1.Parameters.AddWithValue("@address", em.Address);
                            cmd1.Parameters.AddWithValue("@pos_id", em.PositionID);
                            cmd1.Parameters.AddWithValue("@em_id", em.ID);

                            cmd1.ExecuteNonQuery();
                        }

                        // Insert into Roles
                        using (SqlCommand cmd2 = new SqlCommand(query2, connect, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@role_name", roleObj.RoleName);
                            cmd2.Parameters.AddWithValue("@em_id", roleObj.EmID);

                            cmd2.ExecuteNonQuery();
                        }
                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Roll back the transaction in case of error
                        transaction.Rollback();
                        MessageBox.Show($"Error updating Employee:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validator.PrintSQLExceptionError(ex);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database connection error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void DeleteEmployee(string emID, int roleID)
        {
            // SQL queries to delete related data in dependent tables
            string deleteAllowancesQuery = "DELETE FROM Allowances WHERE role_id IN (SELECT role_id FROM Roles WHERE em_id = @emID)";
            string deleteRolesQuery = "DELETE FROM Roles WHERE em_id = @emID";
            string deleteSalariesQuery = "DELETE FROM Salaries WHERE em_id = @emID";
            string deleteEmployeeQuery = "DELETE FROM Employees WHERE em_id = @emID";

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                using (SqlTransaction transaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Delete data from Allowances
                        using (SqlCommand cmd = new SqlCommand(deleteAllowancesQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@emID", emID);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete data from Roles
                        using (SqlCommand cmd = new SqlCommand(deleteRolesQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@emID", emID);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete data from Salaries
                        using (SqlCommand cmd = new SqlCommand(deleteSalariesQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@emID", emID);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete data from Employees
                        using (SqlCommand cmd = new SqlCommand(deleteEmployeeQuery, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@emID", emID);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows == 0)
                            {
                                throw new Exception($"No employee found with ID: {emID}");
                            }
                        }
                        // Commit transaction if everything succeeds
                        transaction.Commit();
                        MessageBox.Show("Employee and related data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeDataChanged?.Invoke();
                    }
                    catch (SqlException ex)
                    {
                        // Rollback transaction if an error occurs
                        transaction.Rollback();
                        MessageBox.Show($"Error deleting employee:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validator.PrintSQLExceptionError(ex);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database connection error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public int GetPositionIDByName(string position)
        {
            string query = "SELECT pos_id FROM Positions WHERE title = @position";

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@position", position);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader["pos_id"];
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching position ID:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return -1;
        }

        public bool IsPhoneExists(string phone, string emID)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) AS count FROM Employees WHERE phone = @phone";

                if (!string.IsNullOrEmpty(emID))
                {
                    query += " AND em_id != @emID";
                }

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);

                    if (!string.IsNullOrEmpty(emID))
                    {
                        cmd.Parameters.AddWithValue("@emID", emID);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader["count"] > 0;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error checking phone number existence:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex); 
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return false;
        }

        public bool IsIDExists(string id)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) AS count FROM Employees WHERE em_id = @emID";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@emID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader["count"] > 0;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error checking ID existence:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return false;
        }

        public void SaveEmDataToDB(DataTable dataTable)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();           
                }

                // insert each row in excel file 
                foreach (DataRow row in dataTable.Rows)
                {
                    string emID = row["em_id"].ToString();

                    if (emID.Length > 6)
                    {
                        MessageBox.Show($"Invalid em_id detected: {emID}. Skipping this record.", "Invalid Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Skip the current row and move to the next one
                    }

                    // Check for duplicate em_id
                    if (IsIDExists(emID))
                    {
                        MessageBox.Show($"Duplicate em_id detected: {emID}. Skipping this record.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Skip the current row and move to the next one
                    }
                    string phone = row["phone"].ToString();

                    // Check for duplicate phone
                    if (IsPhoneExists(phone, emID))
                    {
                        MessageBox.Show($"Duplicate phone number detected: {phone}. Skipping this record.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Skip the current row and move to the next one
                    }
                    // reopen after checking existing ID || phone
                    connect.Open();

                    RoleDAO newRole = new RoleDAO
                    {
                        EmID = emID,
                        RoleName = row["role_name"].ToString()
                    };

                    // Insert queries
                    string query1 = @"INSERT INTO Employees 
                        (em_id, firstname, lastname, phone, gender, dob, address, pos_id)
                        VALUES (@em_id, @firstname, @lastname, @phone, @gender, @dob, @address, @pos_id)";
                    string query2 = "INSERT INTO Roles(em_id, role_name) VALUES(@emID, @role)";

                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try
                        {
                            // Insert into Employees
                            using (SqlCommand cmd1 = new SqlCommand(query1, connect, transaction))
                            {
                                // Add parameters to prevent SQL injection
                                cmd1.Parameters.AddWithValue("@em_id", emID);
                                cmd1.Parameters.AddWithValue("@firstname", row["firstname"]);
                                cmd1.Parameters.AddWithValue("@lastname", row["lastname"]);
                                cmd1.Parameters.AddWithValue("@phone", phone);
                                cmd1.Parameters.AddWithValue("@gender", row["gender"]);
                                cmd1.Parameters.AddWithValue("@dob", row["dob"]);
                                cmd1.Parameters.AddWithValue("@address", row["address"]);
                                cmd1.Parameters.AddWithValue("@pos_id", row["pos_id"]);

                                // Execute the insert command
                                cmd1.ExecuteNonQuery();
                            }

                            // Insert into Roles
                            using (SqlCommand cmd2 = new SqlCommand(query2, connect, transaction))
                            {
                                cmd2.Parameters.AddWithValue("@emID", newRole.EmID);
                                cmd2.Parameters.AddWithValue("@role", newRole.RoleName);

                                cmd2.ExecuteNonQuery();
                            }

                            // Commit the transaction
                            transaction.Commit();                       
                        }
                        catch (SqlException ex)
                        {
                            // Roll back the transaction in case of error
                            transaction.Rollback();
                            MessageBox.Show($"Error inserting row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Validator.PrintSQLExceptionError(ex);
                        }
                    }
                }     
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database connection error:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }
    }
}
