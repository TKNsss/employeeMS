using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using employeeMS.Utils;
using employeeMS.DAO;

namespace employeeMS.UI
{
    public partial class VerifyEmailForm : UserControl
    {
        private int vCode;
        public string vEmail;
        public VerifyEmailForm()
        {
            InitializeComponent();
        }

        private void backToLGFormBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.FindForm();
            lf.logForm.Visible = true;  
            this.Visible = false;
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();  

            string to = vfEmailTB.Text; // recipient
            Validator.IsValidEmail(vfEmailTB, sb, "Email can't be blank!", to);

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string from = "nguyenkimto2004@gmail.com"; // your email goes here (sender)

            // generate random code (1000-9999) for verification
            Random rnd = new Random();
            vCode = rnd.Next(1000, 10000);

            string mail = vCode.ToString();

            // OS environment variable
            string pw = Environment.GetEnvironmentVariable("EMAIL_APP_PASSWORD"); // your app password goes here
            MailMessage msg = new MailMessage();    
            msg.To.Add(to); // directly send message to email typed in the input
            msg.From = new MailAddress(from); // create sender
            msg.Subject = "EMS - Verification Code"; // email subject
            msg.IsBodyHtml = true; // Enable HTML formatting
            msg.Body = "Your verification code is *__<b>" + mail + "</b>__*";

            // create smtp protocol
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pw);

            try
            {
                AdminDAO adDAO = new AdminDAO();

                if (!adDAO.IsEmailExists(to))
                {
                    MessageBox.Show("This email is not the one you registered!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                // send message
                smtp.Send(msg);
                vEmail = to;
                MessageBox.Show("Verification code sent successful! Find it in your gmail.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vfCodeTB.Enabled = true;
                vfCodeTB.BackColor = Color.White;   
                cfCodeBtn.Enabled = true;   
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cfCodeBtn_Click(object sender, EventArgs e)
        {
            if (vfCodeTB.Text.Trim() == vCode.ToString())
            {
                MessageBox.Show("The Verification Code is valid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // clear inputs
                vfEmailTB.Text = "";
                vfCodeTB.Text = "";
                vfCodeTB.Enabled = false;
                cfCodeBtn.Enabled = false;

                // open password changing form
                LoginForm lf = (LoginForm)this.FindForm();
                lf.cPwForm.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Verification Code!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void vfEmailTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.CheckContentSpaces(e);
        }
    }
}
