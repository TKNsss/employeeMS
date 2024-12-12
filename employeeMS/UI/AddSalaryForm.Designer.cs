namespace employeeMS.UI
{
    partial class AddSalaryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSalaryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateSalBtn = new System.Windows.Forms.Button();
            this.clearSalBtn = new System.Windows.Forms.Button();
            this.calculateMonthSalBtn = new System.Windows.Forms.Button();
            this.calculateBaseNetSalBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emSalMonthTB = new System.Windows.Forms.TextBox();
            this.emSalNetTB = new System.Windows.Forms.TextBox();
            this.emSalBaseTB = new System.Windows.Forms.TextBox();
            this.emSalAllowanceTB = new System.Windows.Forms.TextBox();
            this.emSalCoefTB = new System.Windows.Forms.TextBox();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.monthTB = new System.Windows.Forms.TextBox();
            this.workDayTB = new System.Windows.Forms.TextBox();
            this.emSalLastnameTB = new System.Windows.Forms.TextBox();
            this.emSalFirstnameTB = new System.Windows.Forms.TextBox();
            this.emSalRoleIdTB = new System.Windows.Forms.TextBox();
            this.emSalIdTB = new System.Windows.Forms.TextBox();
            this.searchSalTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthSalaryDGV = new System.Windows.Forms.DataGridView();
            this.salaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDGV = new System.Windows.Forms.DataGridView();
            this.em_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportSalBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthSalaryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.exportSalBtn);
            this.panel1.Controls.Add(this.updateSalBtn);
            this.panel1.Controls.Add(this.clearSalBtn);
            this.panel1.Controls.Add(this.calculateMonthSalBtn);
            this.panel1.Controls.Add(this.calculateBaseNetSalBtn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.emSalMonthTB);
            this.panel1.Controls.Add(this.emSalNetTB);
            this.panel1.Controls.Add(this.emSalBaseTB);
            this.panel1.Controls.Add(this.emSalAllowanceTB);
            this.panel1.Controls.Add(this.emSalCoefTB);
            this.panel1.Controls.Add(this.yearTB);
            this.panel1.Controls.Add(this.monthTB);
            this.panel1.Controls.Add(this.workDayTB);
            this.panel1.Controls.Add(this.emSalLastnameTB);
            this.panel1.Controls.Add(this.emSalFirstnameTB);
            this.panel1.Controls.Add(this.emSalRoleIdTB);
            this.panel1.Controls.Add(this.emSalIdTB);
            this.panel1.Controls.Add(this.searchSalTB);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 735);
            this.panel1.TabIndex = 0;
            // 
            // updateSalBtn
            // 
            this.updateSalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.updateSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSalBtn.Enabled = false;
            this.updateSalBtn.FlatAppearance.BorderSize = 0;
            this.updateSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateSalBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSalBtn.ForeColor = System.Drawing.Color.White;
            this.updateSalBtn.Location = new System.Drawing.Point(143, 648);
            this.updateSalBtn.Name = "updateSalBtn";
            this.updateSalBtn.Size = new System.Drawing.Size(116, 44);
            this.updateSalBtn.TabIndex = 8;
            this.updateSalBtn.Text = "Update";
            this.updateSalBtn.UseVisualStyleBackColor = false;
            this.updateSalBtn.Click += new System.EventHandler(this.updateSalBtn_Click);
            // 
            // clearSalBtn
            // 
            this.clearSalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.clearSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSalBtn.FlatAppearance.BorderSize = 0;
            this.clearSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSalBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSalBtn.ForeColor = System.Drawing.Color.White;
            this.clearSalBtn.Location = new System.Drawing.Point(29, 648);
            this.clearSalBtn.Name = "clearSalBtn";
            this.clearSalBtn.Size = new System.Drawing.Size(98, 44);
            this.clearSalBtn.TabIndex = 8;
            this.clearSalBtn.Text = "Clear";
            this.clearSalBtn.UseVisualStyleBackColor = false;
            this.clearSalBtn.Click += new System.EventHandler(this.clearSalBtn_Click);
            // 
            // calculateMonthSalBtn
            // 
            this.calculateMonthSalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.calculateMonthSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateMonthSalBtn.FlatAppearance.BorderSize = 0;
            this.calculateMonthSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateMonthSalBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateMonthSalBtn.ForeColor = System.Drawing.Color.White;
            this.calculateMonthSalBtn.Location = new System.Drawing.Point(199, 448);
            this.calculateMonthSalBtn.Name = "calculateMonthSalBtn";
            this.calculateMonthSalBtn.Size = new System.Drawing.Size(128, 44);
            this.calculateMonthSalBtn.TabIndex = 7;
            this.calculateMonthSalBtn.Text = "Month $";
            this.calculateMonthSalBtn.UseVisualStyleBackColor = false;
            this.calculateMonthSalBtn.Click += new System.EventHandler(this.calculateMonthSalBtn_Click);
            // 
            // calculateBaseNetSalBtn
            // 
            this.calculateBaseNetSalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.calculateBaseNetSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBaseNetSalBtn.FlatAppearance.BorderSize = 0;
            this.calculateBaseNetSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBaseNetSalBtn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBaseNetSalBtn.ForeColor = System.Drawing.Color.White;
            this.calculateBaseNetSalBtn.Location = new System.Drawing.Point(21, 448);
            this.calculateBaseNetSalBtn.Name = "calculateBaseNetSalBtn";
            this.calculateBaseNetSalBtn.Size = new System.Drawing.Size(153, 44);
            this.calculateBaseNetSalBtn.TabIndex = 7;
            this.calculateBaseNetSalBtn.Text = "Base + Net $";
            this.calculateBaseNetSalBtn.UseVisualStyleBackColor = false;
            this.calculateBaseNetSalBtn.Click += new System.EventHandler(this.calculateBaseNetSalBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 592);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Month $:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 551);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "NET $:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "BASE $:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Allowance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Coef:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Month:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Work day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::employeeMS.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(37, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // emSalMonthTB
            // 
            this.emSalMonthTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalMonthTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalMonthTB.Location = new System.Drawing.Point(117, 592);
            this.emSalMonthTB.Multiline = true;
            this.emSalMonthTB.Name = "emSalMonthTB";
            this.emSalMonthTB.ReadOnly = true;
            this.emSalMonthTB.Size = new System.Drawing.Size(219, 35);
            this.emSalMonthTB.TabIndex = 0;
            // 
            // emSalNetTB
            // 
            this.emSalNetTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalNetTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalNetTB.Location = new System.Drawing.Point(117, 551);
            this.emSalNetTB.Multiline = true;
            this.emSalNetTB.Name = "emSalNetTB";
            this.emSalNetTB.ReadOnly = true;
            this.emSalNetTB.Size = new System.Drawing.Size(219, 35);
            this.emSalNetTB.TabIndex = 0;
            // 
            // emSalBaseTB
            // 
            this.emSalBaseTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalBaseTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalBaseTB.Location = new System.Drawing.Point(117, 510);
            this.emSalBaseTB.Multiline = true;
            this.emSalBaseTB.Name = "emSalBaseTB";
            this.emSalBaseTB.ReadOnly = true;
            this.emSalBaseTB.Size = new System.Drawing.Size(219, 35);
            this.emSalBaseTB.TabIndex = 0;
            // 
            // emSalAllowanceTB
            // 
            this.emSalAllowanceTB.BackColor = System.Drawing.Color.White;
            this.emSalAllowanceTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalAllowanceTB.Location = new System.Drawing.Point(117, 398);
            this.emSalAllowanceTB.Multiline = true;
            this.emSalAllowanceTB.Name = "emSalAllowanceTB";
            this.emSalAllowanceTB.Size = new System.Drawing.Size(219, 35);
            this.emSalAllowanceTB.TabIndex = 0;
            // 
            // emSalCoefTB
            // 
            this.emSalCoefTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalCoefTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalCoefTB.Location = new System.Drawing.Point(117, 357);
            this.emSalCoefTB.Multiline = true;
            this.emSalCoefTB.Name = "emSalCoefTB";
            this.emSalCoefTB.ReadOnly = true;
            this.emSalCoefTB.Size = new System.Drawing.Size(219, 35);
            this.emSalCoefTB.TabIndex = 0;
            // 
            // yearTB
            // 
            this.yearTB.BackColor = System.Drawing.Color.White;
            this.yearTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTB.Location = new System.Drawing.Point(117, 316);
            this.yearTB.Multiline = true;
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(219, 35);
            this.yearTB.TabIndex = 0;
            // 
            // monthTB
            // 
            this.monthTB.BackColor = System.Drawing.Color.White;
            this.monthTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTB.Location = new System.Drawing.Point(117, 275);
            this.monthTB.Multiline = true;
            this.monthTB.Name = "monthTB";
            this.monthTB.Size = new System.Drawing.Size(219, 35);
            this.monthTB.TabIndex = 0;
            // 
            // workDayTB
            // 
            this.workDayTB.BackColor = System.Drawing.Color.White;
            this.workDayTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workDayTB.Location = new System.Drawing.Point(117, 234);
            this.workDayTB.Multiline = true;
            this.workDayTB.Name = "workDayTB";
            this.workDayTB.Size = new System.Drawing.Size(219, 35);
            this.workDayTB.TabIndex = 0;
            // 
            // emSalLastnameTB
            // 
            this.emSalLastnameTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalLastnameTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalLastnameTB.Location = new System.Drawing.Point(117, 190);
            this.emSalLastnameTB.Multiline = true;
            this.emSalLastnameTB.Name = "emSalLastnameTB";
            this.emSalLastnameTB.ReadOnly = true;
            this.emSalLastnameTB.Size = new System.Drawing.Size(219, 35);
            this.emSalLastnameTB.TabIndex = 0;
            // 
            // emSalFirstnameTB
            // 
            this.emSalFirstnameTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalFirstnameTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalFirstnameTB.Location = new System.Drawing.Point(117, 149);
            this.emSalFirstnameTB.Multiline = true;
            this.emSalFirstnameTB.Name = "emSalFirstnameTB";
            this.emSalFirstnameTB.ReadOnly = true;
            this.emSalFirstnameTB.Size = new System.Drawing.Size(219, 35);
            this.emSalFirstnameTB.TabIndex = 0;
            // 
            // emSalRoleIdTB
            // 
            this.emSalRoleIdTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalRoleIdTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalRoleIdTB.Location = new System.Drawing.Point(117, 108);
            this.emSalRoleIdTB.Multiline = true;
            this.emSalRoleIdTB.Name = "emSalRoleIdTB";
            this.emSalRoleIdTB.ReadOnly = true;
            this.emSalRoleIdTB.Size = new System.Drawing.Size(219, 35);
            this.emSalRoleIdTB.TabIndex = 0;
            // 
            // emSalIdTB
            // 
            this.emSalIdTB.BackColor = System.Drawing.Color.LightGray;
            this.emSalIdTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emSalIdTB.Location = new System.Drawing.Point(117, 67);
            this.emSalIdTB.Multiline = true;
            this.emSalIdTB.Name = "emSalIdTB";
            this.emSalIdTB.ReadOnly = true;
            this.emSalIdTB.Size = new System.Drawing.Size(219, 35);
            this.emSalIdTB.TabIndex = 0;
            // 
            // searchSalTB
            // 
            this.searchSalTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSalTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchSalTB.Location = new System.Drawing.Point(99, 16);
            this.searchSalTB.Multiline = true;
            this.searchSalTB.Name = "searchSalTB";
            this.searchSalTB.Size = new System.Drawing.Size(219, 30);
            this.searchSalTB.TabIndex = 0;
            this.searchSalTB.Text = "Search";
            this.searchSalTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchSalTB_KeyDown);
            this.searchSalTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchSalTB_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.monthSalaryDGV);
            this.panel2.Controls.Add(this.salaryDGV);
            this.panel2.Location = new System.Drawing.Point(381, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 735);
            this.panel2.TabIndex = 1;
            // 
            // monthSalaryDGV
            // 
            this.monthSalaryDGV.AllowUserToAddRows = false;
            this.monthSalaryDGV.AllowUserToDeleteRows = false;
            this.monthSalaryDGV.AllowUserToResizeRows = false;
            this.monthSalaryDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.monthSalaryDGV.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monthSalaryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.monthSalaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthSalaryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryId,
            this.employeeId,
            this.firstnameSal,
            this.lastnameSal,
            this.workDay,
            this.monthSal,
            this.month,
            this.year});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.monthSalaryDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.monthSalaryDGV.EnableHeadersVisualStyles = false;
            this.monthSalaryDGV.Location = new System.Drawing.Point(13, 382);
            this.monthSalaryDGV.Name = "monthSalaryDGV";
            this.monthSalaryDGV.ReadOnly = true;
            this.monthSalaryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.monthSalaryDGV.RowHeadersVisible = false;
            this.monthSalaryDGV.RowHeadersWidth = 51;
            this.monthSalaryDGV.RowTemplate.Height = 24;
            this.monthSalaryDGV.Size = new System.Drawing.Size(671, 337);
            this.monthSalaryDGV.TabIndex = 1;
            // 
            // salaryId
            // 
            this.salaryId.HeaderText = "SalaryID";
            this.salaryId.MinimumWidth = 6;
            this.salaryId.Name = "salaryId";
            this.salaryId.ReadOnly = true;
            this.salaryId.Width = 90;
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "EmployeeID";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            this.employeeId.Width = 110;
            // 
            // firstnameSal
            // 
            this.firstnameSal.HeaderText = "Firstname";
            this.firstnameSal.MinimumWidth = 6;
            this.firstnameSal.Name = "firstnameSal";
            this.firstnameSal.ReadOnly = true;
            this.firstnameSal.Width = 125;
            // 
            // lastnameSal
            // 
            this.lastnameSal.HeaderText = "Lastname";
            this.lastnameSal.MinimumWidth = 6;
            this.lastnameSal.Name = "lastnameSal";
            this.lastnameSal.ReadOnly = true;
            this.lastnameSal.Width = 125;
            // 
            // workDay
            // 
            this.workDay.HeaderText = "WorkDay";
            this.workDay.MinimumWidth = 6;
            this.workDay.Name = "workDay";
            this.workDay.ReadOnly = true;
            this.workDay.Width = 90;
            // 
            // monthSal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.monthSal.DefaultCellStyle = dataGridViewCellStyle2;
            this.monthSal.HeaderText = "MonthSalary";
            this.monthSal.MinimumWidth = 6;
            this.monthSal.Name = "monthSal";
            this.monthSal.ReadOnly = true;
            this.monthSal.Width = 125;
            // 
            // month
            // 
            this.month.HeaderText = "Month";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 70;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 70;
            // 
            // salaryDGV
            // 
            this.salaryDGV.AllowUserToAddRows = false;
            this.salaryDGV.AllowUserToDeleteRows = false;
            this.salaryDGV.AllowUserToResizeRows = false;
            this.salaryDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.salaryDGV.CausesValidation = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.salaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.em_id,
            this.role_id,
            this.firstname,
            this.lastname,
            this.coef,
            this.allowance,
            this.baseSalary,
            this.netSalary});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryDGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.salaryDGV.EnableHeadersVisualStyles = false;
            this.salaryDGV.Location = new System.Drawing.Point(13, 16);
            this.salaryDGV.Name = "salaryDGV";
            this.salaryDGV.ReadOnly = true;
            this.salaryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.salaryDGV.RowHeadersVisible = false;
            this.salaryDGV.RowHeadersWidth = 51;
            this.salaryDGV.RowTemplate.Height = 24;
            this.salaryDGV.Size = new System.Drawing.Size(671, 346);
            this.salaryDGV.TabIndex = 1;
            this.salaryDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryDGV_CellClick);
            // 
            // em_id
            // 
            this.em_id.HeaderText = "EmployeeID";
            this.em_id.MinimumWidth = 6;
            this.em_id.Name = "em_id";
            this.em_id.ReadOnly = true;
            this.em_id.Width = 125;
            // 
            // role_id
            // 
            this.role_id.HeaderText = "RoleID";
            this.role_id.MinimumWidth = 6;
            this.role_id.Name = "role_id";
            this.role_id.ReadOnly = true;
            this.role_id.Width = 65;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Firstname";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            this.firstname.Width = 125;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Lastname";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            this.lastname.Width = 125;
            // 
            // coef
            // 
            this.coef.HeaderText = "Coef";
            this.coef.MinimumWidth = 6;
            this.coef.Name = "coef";
            this.coef.ReadOnly = true;
            this.coef.Width = 60;
            // 
            // allowance
            // 
            this.allowance.HeaderText = "Allowance";
            this.allowance.MinimumWidth = 6;
            this.allowance.Name = "allowance";
            this.allowance.ReadOnly = true;
            this.allowance.Width = 90;
            // 
            // baseSalary
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.baseSalary.DefaultCellStyle = dataGridViewCellStyle5;
            this.baseSalary.HeaderText = "BaseSalary";
            this.baseSalary.MinimumWidth = 6;
            this.baseSalary.Name = "baseSalary";
            this.baseSalary.ReadOnly = true;
            this.baseSalary.Width = 125;
            // 
            // netSalary
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.netSalary.DefaultCellStyle = dataGridViewCellStyle6;
            this.netSalary.HeaderText = "NetSalary";
            this.netSalary.MinimumWidth = 6;
            this.netSalary.Name = "netSalary";
            this.netSalary.ReadOnly = true;
            this.netSalary.Width = 125;
            // 
            // exportSalBtn
            // 
            this.exportSalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.exportSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportSalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.exportSalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.exportSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportSalBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportSalBtn.ForeColor = System.Drawing.Color.White;
            this.exportSalBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportSalBtn.Image")));
            this.exportSalBtn.Location = new System.Drawing.Point(278, 650);
            this.exportSalBtn.Name = "exportSalBtn";
            this.exportSalBtn.Size = new System.Drawing.Size(57, 38);
            this.exportSalBtn.TabIndex = 10;
            this.exportSalBtn.UseVisualStyleBackColor = false;
            this.exportSalBtn.Click += new System.EventHandler(this.exportSalBtn_Click);
            // 
            // AddSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSalaryForm";
            this.Size = new System.Drawing.Size(1100, 763);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthSalaryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchSalTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workDayTB;
        private System.Windows.Forms.TextBox emSalLastnameTB;
        private System.Windows.Forms.TextBox emSalFirstnameTB;
        private System.Windows.Forms.TextBox emSalRoleIdTB;
        private System.Windows.Forms.TextBox emSalIdTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emSalNetTB;
        private System.Windows.Forms.TextBox emSalBaseTB;
        private System.Windows.Forms.TextBox emSalAllowanceTB;
        private System.Windows.Forms.TextBox emSalCoefTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.TextBox monthTB;
        private System.Windows.Forms.Button calculateBaseNetSalBtn;
        private System.Windows.Forms.Button calculateMonthSalBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox emSalMonthTB;
        private System.Windows.Forms.Button updateSalBtn;
        private System.Windows.Forms.Button clearSalBtn;
        private System.Windows.Forms.DataGridView monthSalaryDGV;
        private System.Windows.Forms.DataGridView salaryDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn em_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn coef;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.Button exportSalBtn;
    }
}
