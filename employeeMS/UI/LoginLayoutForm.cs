using employeeMS.DAO;
using employeeMS.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace employeeMS
{
    public partial class LoginLayoutForm : UserControl
    {      
        public LoginLayoutForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Validator.CheckEmptyFields(usernameTB, sb, "Username can't be blank");
            Validator.CheckEmptyFields(passwordTB, sb, "Password can't be blank");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = usernameTB.Text.Trim();
            string password = passwordTB.Text;

            try
            {
                AdminDAO adDAO = new AdminDAO();
                adDAO = adDAO.GetAdminByCredentials(username);

                if (adDAO == null || !BCrypt.Net.BCrypt.Verify(password, adDAO.AdminPassword))
                {
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
                MessageBox.Show("Login successful! Welcome " + adDAO.AdminName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // open mainform
                LoginForm lf = (LoginForm)this.FindForm();
                lf.Visible = false;
                MainForm mf = new MainForm(adDAO.AdminName)
                {
                    Visible = true
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchToRegBtn_MouseEnter(object sender, EventArgs e)
        {
            switchToRegBtn.ForeColor = Color.FromArgb(1, 37, 61, 144);
        }

        private void switchToRegBtn_MouseLeave(object sender, EventArgs e)
        {
            switchToRegBtn.ForeColor = Color.FromArgb(1, 150, 150, 150);
        }

        private void showPassCb_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = showPassCb.Checked ? '\0' : '*';
        }

        private void switchToRegBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.FindForm();
            lf.regForm.Visible = true;
            this.Visible = false;
        }

        private void passwordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }

        private void forgotPwBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.FindForm();
            lf.vfForm.Visible = true;
            lf.regForm.Visible = false;
            this.Visible = false;
        }

        private void forgotPwBtn_MouseEnter(object sender, EventArgs e)
        {
            forgotPwBtn.ForeColor = Color.FromArgb(1, 37, 61, 144);
        }

        private void forgotPwBtn_MouseLeave(object sender, EventArgs e)
        {
            forgotPwBtn.ForeColor = Color.FromArgb(1, 150, 150, 150);
        }
    }
}
