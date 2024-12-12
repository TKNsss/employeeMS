using employeeMS.DAO;
using employeeMS.Utils;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BCrypt.Net;

namespace employeeMS
{
    public partial class RegisterLayoutForm : UserControl
    {    
        public RegisterLayoutForm()
        {
            InitializeComponent();
        }

        private void switchToLogBtn_MouseEnter(object sender, EventArgs e)
        {
            switchToLogBtn.ForeColor = Color.FromArgb(1, 37, 61, 144);
        }

        private void switchToLogBtn_MouseLeave(object sender, EventArgs e)
        {
            switchToLogBtn.ForeColor = Color.FromArgb(1, 150, 150, 150);
        }

        private void switchToLogBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.FindForm();
            lf.logForm.Visible = true;
            this.Visible = false;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string email = emailTB.Text;

            // check empty fields and special characters
            Validator.CheckEmptyFields(regUsernameTB, sb, "Username can't be blank");
            Validator.IsValidEmail(emailTB, sb, "Email can't be blank!", email);
            Validator.CheckEmptyFields(regPasswordTB, sb, "Password can't be blank");
            Validator.CheckEmptyFields(regConPasswordTB, sb, "Please fill confirmed password too!");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = regUsernameTB.Text.Trim();
            string password = regPasswordTB.Text;    
            string confirmedPassword = regConPasswordTB.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("Password must contain at least 8 characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Equals(confirmedPassword))
            {
                MessageBox.Show("Confirmed password did not match with password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                AdminDAO adDAO = new AdminDAO();      

                if (adDAO.IsEmailExists(email) || adDAO.IsUsernameExists(username))
                {
                    MessageBox.Show("Email/Username has already existed. Please choose a different email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                adDAO.CreateAdminCredentials(username, hashedPassword, email);
                MessageBox.Show("Admin account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                regUsernameTB.Text = "";
                emailTB.Text = "";
                regPasswordTB.Text = "";
                regConPasswordTB.Text = "";

                // open login layout               
                LoginForm lf = (LoginForm)this.FindForm();
                lf.logForm.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void regShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            regPasswordTB.PasswordChar = regShowPassCb.Checked ? '\0' : '*';
            regConPasswordTB.PasswordChar = regShowPassCb.Checked ? '\0' : '*';
        }

        private void regPasswordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }

        private void regConPasswordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }

        private void emailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }
    }
}
