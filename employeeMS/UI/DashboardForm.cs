using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace employeeMS
{
    public partial class DashboardForm : UserControl
    {
        private int currentPanelIndex = 0; // 0: Panel biểu đồ cột, 1: Panel biểu đồ đường

        // Chuỗi kết nối đến SQL Server
        private string connectionString = @"Data Source=HE-HE-HE;Initial Catalog=EmployeeMS;Integrated Security=True;TrustServerCertificate=True";
        private EmployeeDAO emDAO = new EmployeeDAO();

        public DashboardForm()
        {
            InitializeComponent();

            LoadEmployeeIDs(); // Tải danh sách ID nhân viên vào ComboBox
            LoadEmployeeIDsLine();
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();
        }

        private void LoadEmployeeIDs() // Lấy em_id từ cơ sở dữ liệu và đưa vào ComboBox
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
                    MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
                }
            }
        }

        private void LoadEmployeeIDsLine() // Lấy em_id từ cơ sở dữ liệu và đưa vào ComboBox cho Biểu Đồ Đường
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

                    cmbEmployeeIDLine.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        cmbEmployeeIDLine.Items.Add(row["em_id"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message);
                }
            }
        }

        private void LoadSalaryChart(string employeeID) // Hiển thị biểu đồ lương của nhân viên
        {
            DataTable salaryData = GetSalaryData(employeeID);

            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Tháng/Năm", Interval = 1 },
                AxisY = { Title = "Lương (VND)" }
            };
            chart1.ChartAreas.Add(chartArea);

            Series series = new Series($"Lương của NV - {employeeID}")
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
            chart1.Titles.Add($"Lương tháng của nhân viên ID: {employeeID}");
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
                    MessageBox.Show("Lỗi khi tải dữ liệu lương: " + ex.Message);
                }
            }

            return dataTable;
        }

        private void LoadLineChart(string employeeID) // Hiển thị biểu đồ ngày công
        {
            DataTable data = GetAttendanceData(employeeID);

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea
            {
                AxisX = { Title = "Tháng/Năm", Interval = 1 },
                AxisY = { Title = "Số Ngày Công", Minimum = 0 }
            };
            chart2.ChartAreas.Add(chartArea);

            Series series = new Series($"Ngày công của NV - {employeeID}")
            {
                ChartType = SeriesChartType.Line, // Biểu đồ đường
                BorderWidth = 2, // Độ dày đường kẻ
                Color = System.Drawing.Color.Blue, // Màu sắc
                IsValueShownAsLabel = true // Hiển thị giá trị
            };

            foreach (DataRow row in data.Rows)
            {
                string monthYear = row["MonthYear"].ToString();
                int totalWorkDays = Convert.ToInt32(row["WorkDays"]);
                series.Points.AddXY(monthYear, totalWorkDays);
            }

            chart2.Series.Add(series);
            chart2.Titles.Clear();
            chart2.Titles.Add($"Biểu Đồ Đường: Ngày Công của NV - {employeeID}");
        }

        private DataTable GetAttendanceData(string employeeID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
            SELECT 
                CONCAT([month], '/', [year]) AS MonthYear,
                work_day AS WorkDays
            FROM 
                Salaries
            WHERE 
                em_id = @EmployeeID
            ORDER BY 
                [year] DESC, [month] DESC"; // Sắp xếp theo năm tháng giảm dần

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu ngày công: " + ex.Message);
                }
            }

            return dataTable;
        }


        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedItem != null)
            {
                string selectedID = cmbEmployeeID.SelectedItem.ToString();
                LoadSalaryChart(selectedID); // Hiển thị biểu đồ lương
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chuyển panel khi nhấn nút "Tiến"
        private void buttonNext_Click(object sender, EventArgs e)
        {
            panelLineChart.Visible = true;
            ReloadData();
        }

        // Chuyển panel khi nhấn nút "Lùi"
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            panelColumnChart.Visible=true;
            ReloadData();
            panelLineChart.Visible = false;
        }


        // Reload Data và cập nhật các biểu đồ
        public void ReloadData()
        {
            totalEm.Text = emDAO.DisplayTotalEmployee().ToString();
            totalStaff.Text = emDAO.DisplayTotalRoleMember("Staff").ToString();
            totalLeader.Text = emDAO.DisplayTotalRoleMember("Leader").ToString();

            if (cmbEmployeeID.SelectedItem != null)
            {
                string selectedID = cmbEmployeeID.SelectedItem.ToString();
                if (currentPanelIndex == 0)  // Hiển thị lại biểu đồ lương
                {
                    LoadSalaryChart(selectedID);
                }
                else if (currentPanelIndex == 1)  // Hiển thị lại biểu đồ ngày công
                {
                    LoadLineChart(selectedID);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadLineChart_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeIDLine.SelectedItem != null)
            {
                string selectedID = cmbEmployeeIDLine.SelectedItem.ToString();
                LoadLineChart(selectedID); // Tải biểu đồ đường cho nhân viên đã chọn
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
