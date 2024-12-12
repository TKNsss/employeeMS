namespace employeeMS.UI
{
    partial class VerifyEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyEmailForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vfCodeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vfEmailTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cfCodeBtn = new System.Windows.Forms.Button();
            this.sendCodeBtn = new System.Windows.Forms.Button();
            this.backToLGFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 82);
            this.label3.TabIndex = 12;
            this.label3.Text = "Forgot \r\nPassword?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(51, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Easily find your credential";
            // 
            // vfCodeTB
            // 
            this.vfCodeTB.BackColor = System.Drawing.Color.LightGray;
            this.vfCodeTB.Enabled = false;
            this.vfCodeTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vfCodeTB.Location = new System.Drawing.Point(55, 406);
            this.vfCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.vfCodeTB.Multiline = true;
            this.vfCodeTB.Name = "vfCodeTB";
            this.vfCodeTB.Size = new System.Drawing.Size(329, 36);
            this.vfCodeTB.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label8.Location = new System.Drawing.Point(51, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Verify Code:";
            // 
            // vfEmailTB
            // 
            this.vfEmailTB.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vfEmailTB.Location = new System.Drawing.Point(55, 260);
            this.vfEmailTB.Margin = new System.Windows.Forms.Padding(4);
            this.vfEmailTB.Multiline = true;
            this.vfEmailTB.Name = "vfEmailTB";
            this.vfEmailTB.Size = new System.Drawing.Size(329, 36);
            this.vfEmailTB.TabIndex = 18;
            this.vfEmailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vfEmailTB_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(51, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter your email here:";
            // 
            // cfCodeBtn
            // 
            this.cfCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.cfCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cfCodeBtn.Enabled = false;
            this.cfCodeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.cfCodeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.cfCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cfCodeBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfCodeBtn.ForeColor = System.Drawing.Color.White;
            this.cfCodeBtn.Location = new System.Drawing.Point(163, 450);
            this.cfCodeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cfCodeBtn.Name = "cfCodeBtn";
            this.cfCodeBtn.Size = new System.Drawing.Size(109, 47);
            this.cfCodeBtn.TabIndex = 21;
            this.cfCodeBtn.Text = "Confirm";
            this.cfCodeBtn.UseVisualStyleBackColor = false;
            this.cfCodeBtn.Click += new System.EventHandler(this.cfCodeBtn_Click);
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.sendCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCodeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.sendCodeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.sendCodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendCodeBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCodeBtn.ForeColor = System.Drawing.Color.White;
            this.sendCodeBtn.Location = new System.Drawing.Point(163, 304);
            this.sendCodeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(109, 47);
            this.sendCodeBtn.TabIndex = 22;
            this.sendCodeBtn.Text = "Send";
            this.sendCodeBtn.UseVisualStyleBackColor = false;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // backToLGFormBtn
            // 
            this.backToLGFormBtn.BackColor = System.Drawing.Color.Transparent;
            this.backToLGFormBtn.FlatAppearance.BorderSize = 0;
            this.backToLGFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLGFormBtn.Image = ((System.Drawing.Image)(resources.GetObject("backToLGFormBtn.Image")));
            this.backToLGFormBtn.Location = new System.Drawing.Point(24, 25);
            this.backToLGFormBtn.Name = "backToLGFormBtn";
            this.backToLGFormBtn.Size = new System.Drawing.Size(31, 23);
            this.backToLGFormBtn.TabIndex = 28;
            this.backToLGFormBtn.UseVisualStyleBackColor = false;
            this.backToLGFormBtn.Click += new System.EventHandler(this.backToLGFormBtn_Click);
            // 
            // VerifyEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backToLGFormBtn);
            this.Controls.Add(this.sendCodeBtn);
            this.Controls.Add(this.cfCodeBtn);
            this.Controls.Add(this.vfCodeTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vfEmailTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "VerifyEmailForm";
            this.Size = new System.Drawing.Size(433, 517);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vfCodeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vfEmailTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cfCodeBtn;
        private System.Windows.Forms.Button sendCodeBtn;
        private System.Windows.Forms.Button backToLGFormBtn;
    }
}
