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
    internal class RoleDAO
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MRKIM08\SQLEXPRESS;Initial Catalog=employeeMS;Integrated Security=True;TrustServerCertificate=True");
        public int RoleID { get; set; }
        public string EmID { get; set; }
        public string RoleName { get; set; }
        public float Allowance { get; set; }   

        public RoleDAO GetSingleRoleData(string emID)
        {
            RoleDAO role = null;

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string query = @"SELECT ro.role_id AS roleID, em_id, role_name, al_level
                                 FROM Roles AS ro
                                 LEFT JOIN Allowances AS al ON al.role_id = ro.role_id
                                 WHERE em_id = @emID";         

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {       
                    cmd.Parameters.AddWithValue("@emID", emID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new RoleDAO
                            {
                                RoleID = (int)reader["roleID"],
                                EmID = reader["em_id"].ToString(),
                                RoleName = reader["role_name"].ToString(),
                                Allowance = reader["al_level"] != DBNull.Value ? Convert.ToSingle(reader["al_level"]) : 0f
                            };
                        }
                    }
                }     
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error fetching employee's role data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validator.PrintSQLExceptionError(ex);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return role;
        }
    }
}
