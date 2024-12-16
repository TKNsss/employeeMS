using employeeMS.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeMS.DAO
{
    internal class SalaryDAO
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MRKIM08\SQLEXPRESS;Initial Catalog=employeeMS;Integrated Security=True;TrustServerCertificate=True");
        public int SalId { get; set; }
        public string EmId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float BaseSalary { get; set; }
        public float NetSalary { get; set; }
        public int WorkDay { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public float MonthSalary { get; set; }

        public List<SalaryDAO> GetMonthSalData()
        {
            List<SalaryDAO> salaries = new List<SalaryDAO>();           

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = @"SELECT sal.sal_id, sal.em_id, firstname, lastname,                             sal.work_day, sal.month, sal.year, 
                             sal.base_salary, sal.net_salary, sal.month_salary
                             FROM Salaries AS sal
                             JOIN Employees AS em ON sal.em_id = em.em_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {           
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SalaryDAO salaryDAO = new SalaryDAO();  
                            // Retrieve data from SqlDataReader
                            salaryDAO.SalId = (int)reader["sal_id"];
                            salaryDAO.EmId = reader["em_id"].ToString().Trim(); 
                            salaryDAO.FirstName = reader["firstname"].ToString();
                            salaryDAO.LastName = reader["lastname"].ToString();
                            salaryDAO.WorkDay = (int)reader["work_day"];
                            salaryDAO.Month = (int)reader["month"];
                            salaryDAO.Year = (int)reader["year"];
                            salaryDAO.BaseSalary = reader["base_salary"] != DBNull.Value ? Convert.ToSingle(reader["net_salary"]) : 0f;
                            salaryDAO.NetSalary = reader["net_salary"] != DBNull.Value ? Convert.ToSingle(reader["net_salary"]) : 0f;
                            salaryDAO.MonthSalary = reader["month_salary"] != DBNull.Value ? Convert.ToSingle(reader["month_salary"]) : 0f;

                            // Add to the list
                            salaries.Add(salaryDAO);
                        }
                    }   
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Error fetching employee's salary data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return salaries;
        }

        public void UpdateSalary(SalaryDAO sal, RoleDAO role)
        {
            // Check if the salary record exists
            if (!IsEmIDExists(sal.EmId))
            {
                InsertSalary(sal, role); // If it doesn't exist, insert a new record
                return;
            }          
            string query1 = "UPDATE Allowances SET al_level = @Allowance WHERE role_id = @RoleId";
            string query2 = "UPDATE Salaries SET base_salary = @BaseSalary, net_salary = @NetSalary WHERE em_id = @EmId AND month = @Month AND year = @Year";

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
                        // Update Allowances
                        using (SqlCommand cmd1 = new SqlCommand(query1, connect, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@Allowance", role.Allowance);
                            cmd1.Parameters.AddWithValue("@RoleId", role.RoleID);
                            cmd1.ExecuteNonQuery();
                        }

                        // Update Salaries
                        using (SqlCommand cmd2 = new SqlCommand(query2, connect, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@BaseSalary", sal.BaseSalary);
                            cmd2.Parameters.AddWithValue("@NetSalary", sal.NetSalary);
                            cmd2.Parameters.AddWithValue("@EmId", sal.EmId);
                            cmd2.Parameters.AddWithValue("@Month", sal.Month);
                            cmd2.Parameters.AddWithValue("@Year", sal.Year);
                            cmd2.ExecuteNonQuery();
                        }

                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Salary updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        MessageBox.Show($"Error updating Salary:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validator.PrintSQLExceptionError(ex);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error starting transaction:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void InsertSalary(SalaryDAO sal, RoleDAO role)
        {
            // Check if the salary record already exists
            if (IsSalaryRecordExists(sal.EmId, sal.Month, sal.Year))
            {
                MessageBox.Show($"Salary record for employee {sal.EmId} in {sal.Month}/{sal.Year} already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if the record already exists
            }
            string query1 = "INSERT INTO Allowances(al_level, role_id) VALUES (@Allowance, @RoleId)";
            string query2 = "INSERT INTO Salaries(em_id, base_salary, net_salary, work_day, month, year, month_salary) VALUES (@EmId, @BaseSalary, @NetSalary, @WorkDay, @Month, @Year, @MonthSalary)";

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
                        // Insert into Allowances table
                        using (SqlCommand cmd1 = new SqlCommand(query1, connect, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@Allowance", role.Allowance);
                            cmd1.Parameters.AddWithValue("@RoleId", role.RoleID);
                            cmd1.ExecuteNonQuery();
                        }

                        // Insert into Salaries table
                        using (SqlCommand cmd2 = new SqlCommand(query2, connect, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@EmId", sal.EmId);
                            cmd2.Parameters.AddWithValue("@BaseSalary", sal.BaseSalary);
                            cmd2.Parameters.AddWithValue("@NetSalary", sal.NetSalary);
                            cmd2.Parameters.AddWithValue("@WorkDay", sal.WorkDay);
                            cmd2.Parameters.AddWithValue("@Month", sal.Month);
                            cmd2.Parameters.AddWithValue("@Year", sal.Year);
                            cmd2.Parameters.AddWithValue("@MonthSalary", sal.MonthSalary);
                            cmd2.ExecuteNonQuery();
                        }
                        // Commit transaction
                        transaction.Commit();

                        MessageBox.Show("Salary inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Rollback transaction on error
                        transaction.Rollback();
                        MessageBox.Show($"Error inserting Salary:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Validator.PrintSQLExceptionError(ex);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error starting transaction:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public bool IsSalaryRecordExists(string emId, int month, int year)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) FROM Salaries WHERE em_id = @emId AND month = @month AND year = @year";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {         
                    cmd.Parameters.AddWithValue("@emId", emId);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
  
                    int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row
                    return count > 0; // If count > 0, a record exists
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error fetching month salary data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return false; // No record found
        }

        public bool IsEmIDExists(string emID)
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = "SELECT COUNT(*) FROM Salaries WHERE em_id = @emId";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {     
                    cmd.Parameters.AddWithValue("@emId", emID);
   
                    int count = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row
                    return count > 0; // If count > 0, the employee ID exists
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error fetching employee's data:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return false; // No record found
        }
    }
}
