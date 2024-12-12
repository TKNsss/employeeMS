using employeeMS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeMS
{
    public partial class LoginForm : Form
    {
        public RegisterLayoutForm regForm
        {
            get { return registerLayoutForm2; }
        }

        public LoginLayoutForm logForm
        {
            get { return loginLayoutForm2; }
        }

        public VerifyEmailForm vfForm
        {
            get { return verifyEmailForm1; }
        }

        public ChangePasswordForm cPwForm
        {
            get { return changePasswordForm1; } 
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(185, 37, 61, 144);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
