namespace employeeMS
{
    partial class LoginLayoutForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.switchToRegBtn = new System.Windows.Forms.Button();
            this.showPassCb = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPwBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchToRegBtn
            // 
            this.switchToRegBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchToRegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchToRegBtn.FlatAppearance.BorderSize = 0;
            this.switchToRegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.switchToRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchToRegBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchToRegBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.switchToRegBtn.Location = new System.Drawing.Point(56, 453);
            this.switchToRegBtn.Name = "switchToRegBtn";
            this.switchToRegBtn.Size = new System.Drawing.Size(331, 32);
            this.switchToRegBtn.TabIndex = 19;
            this.switchToRegBtn.Text = "Don\'t have an account? Sign up now.";
            this.switchToRegBtn.UseVisualStyleBackColor = false;
            this.switchToRegBtn.Click += new System.EventHandler(this.switchToRegBtn_Click);
            this.switchToRegBtn.MouseEnter += new System.EventHandler(this.switchToRegBtn_MouseEnter);
            this.switchToRegBtn.MouseLeave += new System.EventHandler(this.switchToRegBtn_MouseLeave);
            // 
            // showPassCb
            // 
            this.showPassCb.AutoSize = true;
            this.showPassCb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.showPassCb.Location = new System.Drawing.Point(231, 342);
            this.showPassCb.Margin = new System.Windows.Forms.Padding(4);
            this.showPassCb.Name = "showPassCb";
            this.showPassCb.Size = new System.Drawing.Size(148, 25);
            this.showPassCb.TabIndex = 18;
            this.showPassCb.Text = "Show password";
            this.showPassCb.UseVisualStyleBackColor = true;
            this.showPassCb.CheckedChanged += new System.EventHandler(this.showPassCb_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(56, 399);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(331, 47);
            this.loginBtn.TabIndex = 17;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(56, 298);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(329, 36);
            this.passwordTB.TabIndex = 16;
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTB_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(52, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(56, 203);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTB.Multiline = true;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(329, 36);
            this.usernameTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(52, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(52, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Login to your account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // forgotPwBtn
            // 
            this.forgotPwBtn.BackColor = System.Drawing.Color.Transparent;
            this.forgotPwBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPwBtn.FlatAppearance.BorderSize = 0;
            this.forgotPwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.forgotPwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPwBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPwBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.forgotPwBtn.Location = new System.Drawing.Point(44, 337);
            this.forgotPwBtn.Name = "forgotPwBtn";
            this.forgotPwBtn.Size = new System.Drawing.Size(170, 32);
            this.forgotPwBtn.TabIndex = 19;
            this.forgotPwBtn.Text = "Forgot Password?";
            this.forgotPwBtn.UseVisualStyleBackColor = false;
            this.forgotPwBtn.Click += new System.EventHandler(this.forgotPwBtn_Click);
            this.forgotPwBtn.MouseEnter += new System.EventHandler(this.forgotPwBtn_MouseEnter);
            this.forgotPwBtn.MouseLeave += new System.EventHandler(this.forgotPwBtn_MouseLeave);
            // 
            // LoginLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.forgotPwBtn);
            this.Controls.Add(this.switchToRegBtn);
            this.Controls.Add(this.showPassCb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "LoginLayoutForm";
            this.Size = new System.Drawing.Size(433, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button switchToRegBtn;
        private System.Windows.Forms.CheckBox showPassCb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button forgotPwBtn;
    }
}
