using employeeMS.DAO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Windows.Forms;
using employeeMS.Utils;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;

namespace employeeMS.UI
{
    public partial class AddSalaryForm : UserControl
    {
        public AddSalaryForm()
        {
            InitializeComponent();      
            DisplaySalaryData();
            DisplayMonthSalaryData();

            searchSalTB.GotFocus += (sender, e) => Validator.RemoveText(searchSalTB, sender, e);
            searchSalTB.LostFocus += (sender, e) => Validator.AddText(searchSalTB, sender, e);
        }

        public void ReloadData()
        {
            DisplaySalaryData();
            DisplayMonthSalaryData();
        }

        private void DisplaySalaryData()
        {
            try
            {
                EmployeeDAO emDAO = new EmployeeDAO();    
                // Fetch the list of employees
                List<EmployeeDAO> employees = emDAO.GetEmployeeData();

                // clear rows in salary DGV              
                salaryDGV.Rows.Clear();

                // Create a dictionary to ensure unique employees by ID
                var uniqueEmployees = new Dictionary<string, EmployeeDAO>();

                foreach (var employee in employees)
                {
                    // Ensure unique employee by ID
                    if (!uniqueEmployees.ContainsKey(employee.ID))
                    {
                        uniqueEmployees.Add(employee.ID, employee);
                    }
                }

                // Add the data to the DataGridView (or DataTable used as the DataSource)
                foreach (var employee in uniqueEmployees.Values)
                {
                    RoleDAO roleDAO = new RoleDAO();
                    RoleDAO role = roleDAO.GetSingleRoleData(employee.ID); // Get role data for the employee

                    object[] rowData = {
                        employee.ID,
                        role.RoleID,
                        employee.Firstname,
                        employee.Lastname,
                        employee.CoefLevel,
                        employee.AllowanceLevel,
                        employee.BaseSalary,
                        employee.NetSalary
                    };                  
                    salaryDGV.Rows.Add(rowData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayMonthSalaryData()
        {
            try
            {
                SalaryDAO salaryDAO = new SalaryDAO();  
                List<SalaryDAO> salaries = salaryDAO.GetMonthSalData(); // Replace with your method to fetch salary data
               
                monthSalaryDGV.Rows.Clear();

                // Add rows to the DataTable
                foreach (var sal in salaries)
                {
                    object[] rowData = {
                        sal.SalId,
                        sal.EmId,
                        sal.FirstName,
                        sal.LastName,
                        sal.WorkDay,
                        sal.MonthSalary,
                        sal.Month,
                        sal.Year
                    };
                    monthSalaryDGV.Rows.Add(rowData);
                }              
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void salaryDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = salaryDGV.Rows[e.RowIndex];

                emSalIdTB.Text = row.Cells[0].Value.ToString();
                emSalRoleIdTB.Text = row.Cells[1].Value.ToString();
                emSalFirstnameTB.Text = row.Cells[2].Value.ToString();
                emSalLastnameTB.Text = row.Cells[3].Value.ToString();
                emSalCoefTB.Text = row.Cells[4].Value.ToString();
                emSalAllowanceTB.Text = row.Cells[5].Value.ToString();

                // Get and format float values for baseSalary and netSalary
                float baseSalary = Convert.ToSingle(row.Cells[6].Value);  // Access the correct row directly
                float netSalary = Convert.ToSingle(row.Cells[7].Value);

                // Use String.Format() for consistent formatting
                string baseSalaryFormatted = baseSalary.ToString("#,0.00");
                string netSalaryFormatted = netSalary.ToString("#,0.00");

                // Set the formatted values in the corresponding TextBoxes
                emSalBaseTB.Text = baseSalaryFormatted;  // Use formatted value
                emSalNetTB.Text = netSalaryFormatted;    // Use formatted value
            }
        }

        private void searchSalTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                string searchInput = searchSalTB.Text.Trim(); // Get input from the search field

                // Check input validity
                if (string.IsNullOrWhiteSpace(searchInput) || searchInput == "Search")
                {
                    MessageBox.Show("Please enter a valid ID or name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Call the search method
                Validator.SearchByInput(searchInput, salaryDGV, "salary");             

                e.Handled = true; // // Stops further processing of this event.
                e.SuppressKeyPress = true; // Prevents the 'Enter' key from adding a newline.
            }
        }

        private void searchSalTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchSalTB.Text))
            {
                DisplaySalaryData();
            }
        }

        private void calculateBaseNetSalBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
       
            Validator.CheckNumericFields(emSalCoefTB, sb);
            Validator.CheckNumericFields(emSalAllowanceTB, sb);

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (float.Parse(emSalAllowanceTB.Text) <= 0 || float.Parse(emSalCoefTB.Text) <= 0)
            {
                MessageBox.Show("Please enter value greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ColorTranslator.FromHtml("#D3D3D3");
                updateSalBtn.Enabled = false;
                return;
            }
            // Parse allowance and coef values
            float allowance = float.Parse(emSalAllowanceTB.Text);
            float coef = float.Parse(emSalCoefTB.Text);

            // Calculate salaries
            float baseSalary = 2340000 * coef;
            float netSalary = baseSalary + (baseSalary * allowance);

            // Format the salaries with 2 decimal places
            string baseSalaryFormatted = baseSalary.ToString("#,0.00");
            string netSalaryFormatted = netSalary.ToString("#,0.00");

            // Set formatted values to the corresponding text boxes
            emSalBaseTB.Text = baseSalaryFormatted;
            emSalNetTB.Text = netSalaryFormatted;
            updateSalBtn.Enabled = true;
        }

        private void clearSalBtn_Click(object sender, EventArgs e)
        {
            emSalIdTB.Text = "";
            emSalRoleIdTB.Text = "";
            emSalFirstnameTB.Text = "";
            emSalLastnameTB.Text = "";
            workDayTB.Text = "";
            monthTB.Text = "";
            yearTB.Text = "";
            emSalCoefTB.Text = "";
            emSalAllowanceTB.Text = "";
            emSalBaseTB.Text = "";
            emSalNetTB.Text = "";
            emSalMonthTB.Text = "";
            updateSalBtn.Enabled = false;
        }

        private void calculateMonthSalBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
  
            Validator.CheckNumericFields(emSalCoefTB, sb);
            Validator.CheckNumericFields(emSalAllowanceTB, sb);
            Validator.CheckValidRange(workDayTB, sb, 0, 26);
            Validator.CheckValidRange(monthTB, sb, 1, 12);
            Validator.CheckValidRange(yearTB, sb, 2023, DateTime.Now.Year);
     
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (float.Parse(emSalAllowanceTB.Text) <= 0 || float.Parse(emSalCoefTB.Text) <= 0)
            {
                MessageBox.Show("Please enter values greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emSalCoefTB.BackColor = ColorTranslator.FromHtml("#D3D3D3");
                return;
            }
            float allowance = float.Parse(emSalAllowanceTB.Text);
            float coef = float.Parse(emSalCoefTB.Text);
            int workday = int.Parse(workDayTB.Text);

            float baseSalary = 2340000 * coef;
            float netSalary = baseSalary + baseSalary * allowance;
            float monthSal = (netSalary / 26) * workday;
     
            string monthSalFormatted = monthSal.ToString("#,0.00");

            // Set the formatted value to the textbox
            emSalMonthTB.Text = monthSalFormatted;

            // Enable the update button
            updateSalBtn.Enabled = true;
        }

        private void updateSalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Validate numeric fields
                Validator.CheckNumericFields(emSalAllowanceTB, sb);
                Validator.CheckEmptyFields(emSalBaseTB, sb, "Do not leave Base salary blank!");
                Validator.CheckEmptyFields(emSalNetTB, sb, "Do not leave Net salary blank!");
                Validator.CheckEmptyFields(emSalMonthTB, sb, "Do not leave Month salary blank!");

                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string emID = emSalIdTB.Text;
                double allowance = double.Parse(emSalAllowanceTB.Text.Trim());

                // Parse back to float values
                float baseSalary = float.Parse(emSalBaseTB.Text);
                float netSalary = float.Parse(emSalNetTB.Text);
                float monSalary = float.Parse(emSalMonthTB.Text);

                int workday = int.Parse(workDayTB.Text);
                int month = int.Parse(monthTB.Text);
                int year = int.Parse(yearTB.Text);

                // Get specific employee's role data
                RoleDAO roleDAO = new RoleDAO();    
                RoleDAO role = roleDAO.GetSingleRoleData(emID);

                if (role == null)
                {
                    MessageBox.Show("No role data found for the given Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                  
                    return;
                }

                if (role.RoleName.Equals("Staff") && (allowance < 0.1 || allowance > 0.8))
                {
                    MessageBox.Show("Staff salary coef number must be in range of [0.1, 0.8]", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emSalBaseTB.Text = "";
                    emSalNetTB.Text = "";
                    return;
                }

                if (role.RoleName.Equals("Leader") && (allowance < 0.9 || allowance > 1.5))
                {
                    MessageBox.Show("Leader salary coef number must be in range of [0.9, 1.5]", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emSalBaseTB.Text = "";
                    emSalNetTB.Text = "";
                    return;
                }

                // Update allowance
                role.Allowance = (float)allowance;

                // Create Salary object
                SalaryDAO salary = new SalaryDAO
                {
                    EmId = emID,
                    BaseSalary = baseSalary,
                    NetSalary = netSalary,
                    WorkDay = workday,
                    MonthSalary = monSalary,
                    Month = month,
                    Year = year
                };

                try
                {
                    SalaryDAO salaryDAO = new SalaryDAO();
                    // Perform database operations
                    salaryDAO.InsertSalary(salary, role);  // Insert salary data
                    salaryDAO.UpdateSalary(salary, role); // Update salary data

                    // Refresh salary table in UI
                    DisplaySalaryData();
                    DisplayMonthSalaryData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }

                // Clear fields after updating
                emSalIdTB.Text = "";
                emSalRoleIdTB.Text = "";
                emSalFirstnameTB.Text = "";
                emSalLastnameTB.Text = "";
                workDayTB.Text = "";
                monthTB.Text = "";
                emSalCoefTB.Text = "";
                emSalAllowanceTB.Text = "";
                emSalBaseTB.Text = "";
                emSalNetTB.Text = "";
                emSalMonthTB.Text = "";
                updateSalBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void exportSalBtn_Click(object sender, EventArgs e)
        {
            // Create a FolderBrowserDialog instance to select folder
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderDialog.SelectedPath;

                // Create a SaveFileDialog instance to allow user to specify the Excel file name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls";  // Allow both .xlsx and .xls files
                saveFileDialog.InitialDirectory = selectedPath;  // Set the initial directory to the selected folder
                saveFileDialog.FileName = "exported_data.xlsx";  // Set default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fullFilePath = saveFileDialog.FileName; // User's selected file path

                    // Ensure the file has the selected extension if not already provided
                    if (!fullFilePath.ToLower().EndsWith(".xls") && !fullFilePath.ToLower().EndsWith(".xlsx"))
                    {
                        fullFilePath += ".xlsx"; // Default to .xlsx if no extension is specified
                    }
                    // Set the license context before using EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    // Create a new Excel package
                    using (var package = new ExcelPackage(new FileInfo(fullFilePath)))
                    {
                        // Add a new worksheet to the workbook
                        var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                        // Write column headers to the first row
                        for (int col = 0; col < salaryDGV.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = salaryDGV.Columns[col].HeaderText;
                        }

                        // Write rows of data starting from row 2
                        for (int row = 0; row < salaryDGV.Rows.Count; row++)
                        {
                            if (salaryDGV.Rows[row].IsNewRow) continue; // Skip the new empty row
                            
                            for (int col = 0; col < salaryDGV.Columns.Count; col++)
                            {
                                var cellValue = salaryDGV.Rows[row].Cells[col].Value;
                                
                                if (cellValue != null)
                                {
                                    // Check if the value is a float or double and apply formatting
                                    if (cellValue is float || cellValue is double)
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = cellValue; // Write data
                                        worksheet.Cells[row + 2, col + 1].Style.Numberformat.Format = "#,0.00"; // Adjust the format (e.g., 2 decimal places)
                                    }
                                    else
                                    {
                                        worksheet.Cells[row + 2, col + 1].Value = cellValue.ToString(); // Write data for other types
                                    }
                                }
                            }
                        }

                        // Save the Excel file
                        package.Save();
                    }
                    MessageBox.Show("Data exported successfully as Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }  
    }
}
