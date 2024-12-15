using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace employeeMS
{
    public partial class DashboardForm : UserControl
    {
        // Chuỗi kết nối đến SQL Server
        private string connectionString = @"Data Source=HE-HE-HE;Initial Catalog=EmployeeMS;Integrated Security=True;TrustServerCertificate=True";

        private EmployeeDAO emDAO = new EmployeeDAO();
        public DashboardForm()
        {
            InitializeComponent();
            LoadEmployeeIDs(); // Tải danh sách ID nhân viên vào ComboBox
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();
        }

        private void LoadEmployeeIDs() // lấy em_id từ cơ sở dữ liệu và đưa vào ComboBox
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT em_id FROM Salaries ORDER BY em_id";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    cmbEmployeeID.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cmbEmployeeID.Items.Add(row["em_id"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee list: " + ex.Message);
                }
            }
        }

        private void LoadSalaryChart(string employeeID) // Hiển thị dữ liệu lương nv lên biểu đồ
        {
            DataTable salaryData = GetSalaryData(employeeID);

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Month/Year", Interval = 1 },
                AxisY = { Title = "Salary (VND)" }
            };
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series($"Employee salary - {employeeID}")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "#,##0 VND"
            };

            foreach (DataRow row in salaryData.Rows)
            {
                string monthYear = row["Month"].ToString() + "/" + row["Year"].ToString();
                decimal totalSalary = Convert.ToDecimal(row["TotalSalary"]);
                series.Points.AddXY(monthYear, totalSalary);
            }

            chart1.Series.Add(series);

            chart1.Titles.Clear();
            chart1.Titles.Add($"Monthly Salary of Employee with ID: {employeeID}");
        }


        private DataTable GetSalaryData(string employeeID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    [month] AS Month, 
                    [year] AS Year, 
                    month_salary AS TotalSalary
                FROM 
                    Salaries
                WHERE 
                    em_id = @EmployeeID
                ORDER BY 
                    [year], [month]";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when retrieving salary data: " + ex.Message);
                }
            }

            return dataTable;
        }

        private void btnLoadChart_Click(object sender, EventArgs e) // sự kiện cho nút btnLoadChart, khi click
        {
                if (cmbEmployeeID.SelectedItem != null)
                {
                    string selectedID = cmbEmployeeID.SelectedItem.ToString();
                    LoadSalaryChart(selectedID); // Hiển thị lương của nhân viên trên biểu đồ
                }
                else
                {
                    MessageBox.Show("Please select employee ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        public void ReloadData()
        {
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();
            if (cmbEmployeeID.SelectedItem != null)
            {
                string selectedID = cmbEmployeeID.SelectedItem.ToString();
                LoadSalaryChart(selectedID); // Tải lại biểu đồ lương của nhân viên theo ID
            }
            else
            {
                MessageBox.Show("Please select employee ID!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
