using employeeMS.DAO;
using employeeMS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace employeeMS.UI
{
    public partial class ChangePasswordForm : UserControl
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void showNewPassCb_CheckedChanged(object sender, EventArgs e)
        {
            newPwTB.PasswordChar = showNewPassCb.Checked ? '\0' : '*';
            cfNewPwTB.PasswordChar = showNewPassCb.Checked ? '\0' : '*';
        }

        private void backToVfFormBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.FindForm();
            lf.vfForm.Visible = true;
            this.Visible = false;
        }

        private void updateNewPwBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Validator.CheckEmptyFields(newPwTB, sb, "New password can't be blank!");
            Validator.CheckEmptyFields(cfNewPwTB, sb, "New confirmed password can't be blank!");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newPw = newPwTB.Text;
            string newCfPw = cfNewPwTB.Text;

            if (newPw.Length < 8)
            {
                MessageBox.Show("Password must contain at least 8 characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!newPw.Equals(newCfPw))
            {
                MessageBox.Show("Confirmed password did not match with password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                LoginForm lf = (LoginForm)this.FindForm();
                string cPwEmail = lf.vfForm.vEmail;

                AdminDAO adDAO = new AdminDAO();
                adDAO = adDAO.GetAdminByCredentials(cPwEmail, "email");

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPw);

                adDAO.UpdatePassword(hashedPassword, cPwEmail);
                MessageBox.Show(adDAO.AdminName + "'s password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                newPwTB.Text = "";
                cfNewPwTB.Text = "";

                // open login layout                     
                lf.logForm.Visible = true;
                this.Visible = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newPwTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }

        private void cfNewPwTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }
    }
}
