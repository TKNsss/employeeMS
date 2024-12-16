using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using employeeMS.DAO;
using System.Net.Mail;

namespace employeeMS.Utils
{
    internal class Validator
    {
        public static bool CheckEmptyFields(TextBox tb, StringBuilder sb, string msg) 
        {
            if (tb.Text.Trim() == "") 
            {
                sb.Append(msg + "\n");
                tb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            tb.BackColor = Color.White;
            return true;
        }

        public static bool CheckSpecialCharacters(TextBox tb, StringBuilder sb, string msg)
        {
            string specialCharactersReg = "[$&+,:;=?@#|'<>.^*()%!\\[\\]-]";

            if (!CheckEmptyFields(tb, sb, msg)) 
            {
                return false;
            }

            if (Regex.IsMatch(tb.Text, specialCharactersReg)) 
            {
                string errMsg = "No special characters within username/password, please!\n";

                if (!sb.ToString().Contains(errMsg))
                {
                    sb.Append(errMsg);
                }
                tb.BackColor = tb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            tb.BackColor = Color.White;   
            return true;
        }

        public static bool IsValidEmail(TextBox tb, StringBuilder sb, string msg, string email)
        {
            if (!CheckEmptyFields(tb, sb, msg))
            {
                return false;
            }

            try
            {
                MailAddress m = new MailAddress(email);
                tb.BackColor = Color.White;
                return true;
            }
            catch (FormatException)
            {
                sb.Append("Incorrect email format!\n");
                tb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
        }

        public static bool CheckEmptyComboBoxes(ComboBox cb, StringBuilder sb, string msg)
        {
            if (cb.SelectedIndex == -1)
            {
                sb.Append(msg).Append("\n");
                cb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            cb.BackColor = Color.White; 
            return true;
        }

        public static void CheckContentSpaces(KeyPressEventArgs e)
        {
            // Check if the pressed key is a space
            if (e.KeyChar == ' ')
            {
                MessageBox.Show("Spaces are not allowed within the password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consume the event to prevent the space from being typed
                e.Handled = true;
            }
        }

        public static bool CheckValidPhone(TextBox tb, StringBuilder sb)
        {
            if (!CheckEmptyFields(tb, sb, "Do not leave Phone Number blank."))
            {
                return false;
            }
            string phoneNumber = tb.Text.Trim();

            if (phoneNumber.Length != 10 && !Regex.IsMatch(phoneNumber, "^\\+\\d{1,3}[- ]?\\d{10}$"))
            {
                sb.Append("Phone number must be 10 digits long or in the format +[country code]-XXXXXXXXXX!\n");
                tb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            tb.BackColor = Color.White;
            return true;
        }

        public static bool CheckValidDOB(DateTimePicker dp, StringBuilder sb)
        {
            DateTime? selectedDate = dp.Value;

            if (!selectedDate.HasValue)
            {
                sb.Append("Please select date of birth!\n");
                dp.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            // Calculate age
            DateTime birthDate = selectedDate.Value;
            DateTime today = DateTime.Now;
            int age = today.Year - birthDate.Year;

            // Check if the birthday has already occurred this year
            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }

            // Check age range
            if (age < 18 || age > 55)
            {
                sb.Append("Age must be within range 18 - 55\n");
                dp.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }
            dp.BackColor = Color.White; 
            return true;
        }

        public static bool CheckNumericFields(TextBox tb, StringBuilder sb)
        {
            // Check if the field is empty
            if (!CheckEmptyFields(tb, sb, "Do not leave fields blank!"))
            {
                return false;
            }

            try
            {
                string input = tb.Text.Trim();

                // Try parsing as an integer
                try
                {
                    int.Parse(input);
                }
                catch (FormatException)
                {
                    // If not an integer, try parsing as a double
                    double.Parse(input);
                }
            }
            catch (FormatException)
            {
                sb.Append("Those fields must be numeric (integer or decimal)!\n");
                tb.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }

            if (tb.Name == "emSalCoefTB")
            {
                tb.BackColor = ColorTranslator.FromHtml("#D3D3D3");       
            } else
            {
                tb.BackColor = Color.White; 
            }
            return true;
        }

        public static bool CheckValidRange(TextBox tf, StringBuilder sb, int min, int max)
        {  
            if (!CheckNumericFields(tf, sb))
            {
                return false;
            }
            int value = int.Parse(tf.Text.Trim());

            // Check if the value is within the valid range
            if (value < min || value > max)
            {
                sb.Append($"The input value must be within the range {min} - {max}.\n");
                tf.BackColor = ColorTranslator.FromHtml("#FFCDD2");
                return false;
            }     
            tf.BackColor = Color.White;
            return true; 
        }

        public static void PrintSQLExceptionError(SqlException e)
        {
            string errorMessage = $"SQL Exception occurred:\n" +
                                  $"Message: {e.Message}\n" +
                                  $"Error Code: {e.Number}\n" +
                                  $"SQL State: {e.State}\n" +
                                  $"Stack Trace:\n{e.StackTrace}";
            MessageBox.Show(errorMessage, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void RemoveText(TextBox tb, object sender, EventArgs e)
        {
            if (tb.Text == "Search")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public static void AddText(TextBox tb, object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Search";
                tb.ForeColor = Color.Silver;
            }
        }

        public static void SearchByInput(string input, DataGridView dgv, string tableType)
        {
            // Clear current table rows
            dgv.Rows.Clear();

            try
            {
                bool found = false;

                if (tableType.Equals("employee"))
                {
                    EmployeeDAO emDAO = new EmployeeDAO();
                    var emList = emDAO.GetEmployeeData(); // Fetch employee list

                    foreach (var employee in emList)
                    {
                        // Check if the input matches the ID or is contained in the name
                        if (employee.ID.ToLower().Contains(input.ToLower()) ||
                            employee.Firstname.ToLower().Contains(input.ToLower()) ||
                            employee.Lastname.ToLower().Contains(input.ToLower()))
                        {
                            // Add matching employee to the table
                            dgv.Rows.Add(
                                employee.ID,
                                employee.Firstname,
                                employee.Lastname,
                                employee.Phone,
                                employee.Gender,
                                employee.DateOB.HasValue ? employee.DateOB.Value.ToString("dd/MM/yyyy") : "N/A",
                                employee.Address,
                                employee.Role,
                                employee.Position
                            );
                            found = true;    
                        }
                    }
                }
                else if (tableType.Equals("salary"))
                {
                    EmployeeDAO emDAO = new EmployeeDAO(); 
                    var salList = emDAO.GetEmployeeData(); // Fetch salary list

                    foreach (var employee in salList)
                    {
                        // Check if the input matches the ID or is contained in the employee name
                        if (employee.ID.ToLower().Contains(input.ToLower()) ||
                            employee.Firstname.ToLower().Contains(input.ToLower()) ||
                            employee.Lastname.ToLower().Contains(input.ToLower()))
                        {
                            RoleDAO roleDAO = new RoleDAO();
                            var role = roleDAO.GetSingleRoleData(employee.ID);

                            // Add matching salary details to the table
                            dgv.Rows.Add(
                                employee.ID,
                                role.RoleID,
                                employee.Firstname,
                                employee.Lastname,
                                employee.CoefLevel,
                                employee.AllowanceLevel,
                                employee.BaseSalary,
                                employee.NetSalary
                            );
                            found = true;
                        }
                    }
                }

                // Show message if no matches found
                if (!found)
                {
                    MessageBox.Show($"No records found for: {input}", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
