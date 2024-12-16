using employeeMS.DAO;
using employeeMS.Utils;
using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace employeeMS
{
    public partial class AddEmployeeForm : UserControl
    { 
        public AddEmployeeForm()
        {
            InitializeComponent();
            DisplayEmployeeData();

            searchTB.GotFocus += (sender, e) => Validator.RemoveText(searchTB, sender, e);
            searchTB.LostFocus += (sender, e) => Validator.AddText(searchTB, sender, e);
        }     

        private void DisplayEmployeeData()
        {
            try
            {
                EmployeeDAO emDAO = new EmployeeDAO();
                List<EmployeeDAO> emList = emDAO.GetEmployeeData();

                // Clear existing rows in DataGridView
                emGridData.Rows.Clear();

                foreach (EmployeeDAO em in emList)
                {
                    object[] rowData = {
                        em.ID,
                        em.Firstname,
                        em.Lastname,
                        em.Phone,
                        em.Gender,
                        em.DateOB,
                        em.Address,
                        em.Role,
                        em.Position
                    };
                    emGridData.Rows.Add(rowData);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView 
            int selectedRow = emGridData.CurrentRow?.Index ?? -1;

            if (selectedRow >= 0)
            {
                // Confirm before deletion
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Get the employee ID from the selected row
                    string emID = emGridData.Rows[selectedRow].Cells[0].Value.ToString().Trim();

                    try
                    {
                        // Retrieve role data
                        RoleDAO roleDAO = new RoleDAO();
                        RoleDAO role = roleDAO.GetSingleRoleData(emID);

                        if (role == null)
                        {
                            MessageBox.Show("No role data found for the given Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        int roleID = role.RoleID;

                        // Delete the record from the database
                        EmployeeDAO emDAO = new EmployeeDAO();
                        emDAO.DeleteEmployee(emID, roleID); // Call the delete method

                        // Refresh data in the table
                        DisplayEmployeeData();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Validate inputs using the Validator class
                Validator.CheckSpecialCharacters(emIdTB, sb, "Employee ID cannot be blank!");
                Validator.CheckSpecialCharacters(firstnameTB, sb, "First name cannot be blank!");
                Validator.CheckSpecialCharacters(lastnameTB, sb, "Last name cannot be blank!");
                Validator.CheckEmptyComboBoxes(genderCB, sb, "Gender cannot be blank!");
                Validator.CheckEmptyComboBoxes(roleCB, sb, "Role cannot be blank!");
                Validator.CheckValidPhone(phoneTB, sb);
                Validator.CheckValidDOB(dobDTP, sb);
                Validator.CheckEmptyComboBoxes(addressCB, sb, "Address cannot be blank!");
                Validator.CheckEmptyComboBoxes(positionCB, sb, "Position cannot be blank!");

                // Show validation errors if any
                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string emId = emIdTB.Text.Trim();

                // Check the length of Employee ID
                if (emId.Length > 6)
                {
                    MessageBox.Show("Employee ID can't contain more than 6 characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string firstName = firstnameTB.Text.Trim();
                string lastName = lastnameTB.Text.Trim();
                string gender = genderCB.SelectedItem.ToString().Trim();
                string role = roleCB.SelectedItem.ToString().Trim();
                string phone = phoneTB.Text.Trim();
                DateTime? date = dobDTP.Value;
                string address = addressCB.SelectedItem.ToString().Trim();

                string position = positionCB.SelectedItem.ToString().Trim();

                EmployeeDAO emDAO = new EmployeeDAO();
                int posID = emDAO.GetPositionIDByName(position);

                // Create new Employee instance
                EmployeeDAO newEm = new EmployeeDAO
                {
                    ID = emId,
                    Firstname = firstName,
                    Lastname = lastName,
                    Phone = phone,
                    Gender = gender,
                    DateOB = dobDTP.Checked ? (DateTime?)dobDTP.Value : null,
                    Address = address,
                    Role = role,
                    PositionID = posID
                };

                // create new Role instance
                RoleDAO newRole = new RoleDAO
                {
                    EmID = emId,
                    RoleName = role
                };

                // Add employee data
                emDAO.AddEmployeeData(newEm, newRole);
                // Refresh data in employee table
                DisplayEmployeeData();             

                // Clear input fields
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emGridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) 
            {
                DataGridViewRow row = emGridData.Rows[e.RowIndex];

                emIdTB.Text = row.Cells[0].Value.ToString();
                emIdTB.ReadOnly = true;
                emIdTB.BackColor = ColorTranslator.FromHtml("#D3D3D3");
                firstnameTB.Text = row.Cells[1].Value.ToString();
                lastnameTB.Text = row.Cells[2].Value.ToString();
                phoneTB.Text = row.Cells[3].Value.ToString();
                genderCB.Text = row.Cells[4].Value.ToString();

                string dateStr = row.Cells[5].Value.ToString();

                if (DateTime.TryParse(dateStr, out DateTime dob))
                {
                    dobDTP.Value = dob;
                }
                else
                {
                    MessageBox.Show("Invalid or null date in the selected row.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                addressCB.Text = row.Cells[6].Value.ToString();
                roleCB.Text = row.Cells[7].Value.ToString();
                positionCB.Text = row.Cells[8].Value.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            emIdTB.Text = "";
            emIdTB.ReadOnly= false;
            emIdTB.BackColor = Color.White;
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            phoneTB.Text = "";
            genderCB.SelectedIndex = -1;
            dobDTP.Value = DateTime.Today;
            addressCB.SelectedIndex = -1;
            roleCB.SelectedIndex = -1;
            positionCB.SelectedIndex = -1;

            emGridData.ClearSelection();
            emGridData.CurrentCell = null; // Ensures no row is marked as "current"
        }

        private void ClearFields()
        {
            emIdTB.Text = "";
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            phoneTB.Text = "";
            genderCB.SelectedIndex = -1;
            dobDTP.Value = DateTime.Today;
            addressCB.SelectedIndex = -1;
            roleCB.SelectedIndex = -1;
            positionCB.SelectedIndex = -1;

            emGridData.ClearSelection();
            emGridData.CurrentCell = null; // Ensures no row is marked as "current"
        }  

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Validate input fields
                Validator.CheckSpecialCharacters(emIdTB, sb, "Employee ID cannot be blank!");
                Validator.CheckSpecialCharacters(firstnameTB, sb, "First name cannot be blank!");
                Validator.CheckSpecialCharacters(lastnameTB, sb, "Last name cannot be blank!");
                Validator.CheckEmptyComboBoxes(genderCB, sb, "Gender cannot be blank!");
                Validator.CheckEmptyComboBoxes(roleCB, sb, "Status cannot be blank!");
                Validator.CheckValidPhone(phoneTB, sb);
                Validator.CheckValidDOB(dobDTP, sb);
                Validator.CheckEmptyComboBoxes(addressCB, sb, "Address cannot be blank!");
                Validator.CheckEmptyComboBoxes(positionCB, sb, "Position cannot be blank!");

                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Retrieve data from input fields
                string emId = emIdTB.Text.Trim();
                string firstName = firstnameTB.Text.Trim();
                string lastName = lastnameTB.Text.Trim();
                string gender = genderCB.SelectedItem.ToString().Trim();
                string role = roleCB.SelectedItem.ToString().Trim();
                string phone = phoneTB.Text.Trim();
                DateTime? date = dobDTP.Value.Date;
                string address = addressCB.SelectedItem.ToString().Trim();
                string position = positionCB.SelectedItem.ToString().Trim();

                EmployeeDAO emDAO = new EmployeeDAO();
                int posID = emDAO.GetPositionIDByName(position); // Adjust as per your data access class

                // Update the database
                EmployeeDAO employee = new EmployeeDAO
                {
                    ID = emId,
                    Firstname = firstName,
                    Lastname = lastName,
                    Phone = phone,
                    Gender = gender,
                    DateOB = date.HasValue ? date.Value : (DateTime?)null,
                    Address = address,
                    PositionID = posID
                };

                RoleDAO newRole = new RoleDAO
                {
                    EmID = emId,
                    RoleName = role
                };
                emDAO.UpdateEmployeeData(employee, newRole);
                DisplayEmployeeData(); // Update the employee table
                //LoadDataIntoSalaryTable(); // Update the salary table

                // Clear input fields
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                string searchInput = searchTB.Text.Trim(); // Get input from the search field

                // Check input validity
                if (string.IsNullOrWhiteSpace(searchInput) || searchInput == "Search")
                {
                    MessageBox.Show("Please enter a valid ID or name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Call the search method
                Validator.SearchByInput(searchInput, emGridData, "employee");

                e.Handled = true; // // Stops further processing of this event.
                e.SuppressKeyPress = true; // Prevents the 'Enter' key from adding a newline.
            }
        }

        private void searchTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTB.Text))
            {
                DisplayEmployeeData();
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select an Excel File"
            };

            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofDialog.FileName;

                try
                {
                    // Load data from the Excel file
                    DataTable dataTable = LoadExcelData(filePath);

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        EmployeeDAO emDAO = new EmployeeDAO();
                        // Insert data into SQL Server
                        emDAO.SaveEmDataToDB(dataTable);
                        MessageBox.Show("Importing employee's data successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No data found in the Excel file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing the file: The file must be in the correct format!\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataTable LoadExcelData(string filePath)
        {
            // Opens the Excel file at the specified filePath for reading.
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                // Selects the correct reader based on the Excel file format.
                IExcelDataReader reader = filePath.EndsWith(".xls")
                    ? ExcelReaderFactory.CreateBinaryReader(stream) // For .xls
                    : ExcelReaderFactory.CreateOpenXmlReader(stream); // For .xlsx

                //R eads the Excel file and converts it into a DataSet.
                var result = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true // Use the first row as column headers
                    }
                });
                reader.Close();

                // Return the first sheet as a DataTable
                return result.Tables[0];
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
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
                        for (int col = 0; col < emGridData.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = emGridData.Columns[col].HeaderText;
                        }

                        // Write rows of data starting from row 2
                        for (int row = 0; row < emGridData.Rows.Count; row++)
                        {
                            if (emGridData.Rows[row].IsNewRow) continue; // Skip the new empty row
                            for (int col = 0; col < emGridData.Columns.Count; col++)
                            {
                                var cellValue = emGridData.Rows[row].Cells[col].Value;
                                if (cellValue != null)
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = cellValue.ToString(); // Write data
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
