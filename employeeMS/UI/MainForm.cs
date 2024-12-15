using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeMS
{
    public partial class MainForm : Form
    {
        public MainForm(string username)
        {
            InitializeComponent();
            usernameLB.Text = username;
        }
        
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = true;
            dashboardForm2.ReloadData();
            dashboardForm2.Update();
            addEmployeeForm1.Visible = false;
            addSalaryForm1.Visible = false;
        }

        private void dashboardBtn_MouseEnter_1(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(255, 194, 14);
            dashboardBtn.ForeColor = Color.Black;
            dashboardBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\db_dark.png");
            dashboardBtn.FlatAppearance.BorderSize = 1;
            dashboardBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 194, 14);
        }

        private void dashboardBtn_MouseLeave_1(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.Transparent;
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\db_white.png");
            dashboardBtn.FlatAppearance.BorderSize = 1;
            dashboardBtn.FlatAppearance.BorderColor = Color.White;
        }

        private void addEmBtn_MouseEnter_1(object sender, EventArgs e)
        {
            addEmBtn.BackColor = Color.FromArgb(255, 194, 14);
            addEmBtn.ForeColor = Color.Black;
            addEmBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\em_dark.png");
            addEmBtn.FlatAppearance.BorderSize = 1;
            addEmBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 194, 14);
        }

        private void addEmBtn_MouseLeave_1(object sender, EventArgs e)
        {
            addEmBtn.BackColor = Color.Transparent;
            addEmBtn.ForeColor = Color.White;
            addEmBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\em_white.png");
            addEmBtn.FlatAppearance.BorderSize = 1;
            addEmBtn.FlatAppearance.BorderColor = Color.White;
        }

        private void salaryBtn_MouseEnter_1(object sender, EventArgs e)
        {
            salaryBtn.BackColor = Color.FromArgb(255, 194, 14);
            salaryBtn.ForeColor = Color.Black;
            salaryBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\salary_dark.png");
            salaryBtn.FlatAppearance.BorderSize = 1;
            salaryBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 194, 14);
        }

        private void salaryBtn_MouseLeave_1(object sender, EventArgs e)
        {
            salaryBtn.BackColor = Color.Transparent;
            salaryBtn.ForeColor = Color.White;
            salaryBtn.Image = Image.FromFile("C:\\Users\\ADMIN\\Desktop\\employeeMS\\employeeMS\\assets\\salary_white.png");
            salaryBtn.FlatAppearance.BorderSize = 1;
            salaryBtn.FlatAppearance.BorderColor = Color.White;
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void addEmBtn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = false;
            addEmployeeForm1.Visible = true;
            addEmployeeForm1.Update();
            addSalaryForm1.Visible = false;
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            dashboardForm2.Visible = false;
            addEmployeeForm1.Visible = false;
            addSalaryForm1.Visible = true;
            addSalaryForm1.ReloadData();
            addSalaryForm1.Update();
        }
    }
}
