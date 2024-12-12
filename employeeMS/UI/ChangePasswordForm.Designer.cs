namespace employeeMS.UI
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.updateNewPwBtn = new System.Windows.Forms.Button();
            this.cfNewPwTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newPwTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showNewPassCb = new System.Windows.Forms.CheckBox();
            this.backToVfFormBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateNewPwBtn
            // 
            this.updateNewPwBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.updateNewPwBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateNewPwBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.updateNewPwBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.updateNewPwBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateNewPwBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNewPwBtn.ForeColor = System.Drawing.Color.White;
            this.updateNewPwBtn.Location = new System.Drawing.Point(55, 456);
            this.updateNewPwBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateNewPwBtn.Name = "updateNewPwBtn";
            this.updateNewPwBtn.Size = new System.Drawing.Size(331, 47);
            this.updateNewPwBtn.TabIndex = 24;
            this.updateNewPwBtn.Text = "Update";
            this.updateNewPwBtn.UseVisualStyleBackColor = false;
            this.updateNewPwBtn.Click += new System.EventHandler(this.updateNewPwBtn_Click);
            // 
            // cfNewPwTB
            // 
            this.cfNewPwTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfNewPwTB.Location = new System.Drawing.Point(57, 357);
            this.cfNewPwTB.Margin = new System.Windows.Forms.Padding(4);
            this.cfNewPwTB.Multiline = true;
            this.cfNewPwTB.Name = "cfNewPwTB";
            this.cfNewPwTB.PasswordChar = '*';
            this.cfNewPwTB.Size = new System.Drawing.Size(329, 36);
            this.cfNewPwTB.TabIndex = 23;
            this.cfNewPwTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cfNewPwTB_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(53, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Confirm New Password:";
            // 
            // newPwTB
            // 
            this.newPwTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPwTB.Location = new System.Drawing.Point(57, 280);
            this.newPwTB.Margin = new System.Windows.Forms.Padding(4);
            this.newPwTB.Multiline = true;
            this.newPwTB.Name = "newPwTB";
            this.newPwTB.PasswordChar = '*';
            this.newPwTB.Size = new System.Drawing.Size(329, 36);
            this.newPwTB.TabIndex = 21;
            this.newPwTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newPwTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(53, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(82, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "Your identity has been verified!\r\n      Set your new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(88, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 82);
            this.label3.TabIndex = 18;
            this.label3.Text = "        NEW \r\nCREDENTIALS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 73);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // showNewPassCb
            // 
            this.showNewPassCb.AutoSize = true;
            this.showNewPassCb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNewPassCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.showNewPassCb.Location = new System.Drawing.Point(238, 401);
            this.showNewPassCb.Margin = new System.Windows.Forms.Padding(4);
            this.showNewPassCb.Name = "showNewPassCb";
            this.showNewPassCb.Size = new System.Drawing.Size(148, 25);
            this.showNewPassCb.TabIndex = 26;
            this.showNewPassCb.Text = "Show password";
            this.showNewPassCb.UseVisualStyleBackColor = true;
            this.showNewPassCb.CheckedChanged += new System.EventHandler(this.showNewPassCb_CheckedChanged);
            // 
            // backToVfFormBtn
            // 
            this.backToVfFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.backToVfFormBtn.FlatAppearance.BorderSize = 0;
            this.backToVfFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToVfFormBtn.Image = ((System.Drawing.Image)(resources.GetObject("backToVfFormBtn.Image")));
            this.backToVfFormBtn.Location = new System.Drawing.Point(20, 22);
            this.backToVfFormBtn.Name = "backToVfFormBtn";
            this.backToVfFormBtn.Size = new System.Drawing.Size(31, 23);
            this.backToVfFormBtn.TabIndex = 27;
            this.backToVfFormBtn.UseVisualStyleBackColor = false;
            this.backToVfFormBtn.Click += new System.EventHandler(this.backToVfFormBtn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backToVfFormBtn);
            this.Controls.Add(this.showNewPassCb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateNewPwBtn);
            this.Controls.Add(this.cfNewPwTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newPwTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ChangePasswordForm";
            this.Size = new System.Drawing.Size(433, 517);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateNewPwBtn;
        private System.Windows.Forms.TextBox cfNewPwTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newPwTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox showNewPassCb;
        private System.Windows.Forms.Button backToVfFormBtn;
    }
}
