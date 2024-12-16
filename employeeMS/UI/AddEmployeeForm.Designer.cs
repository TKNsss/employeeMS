namespace employeeMS
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.emGridData = new System.Windows.Forms.DataGridView();
            this.EmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dobDTP = new System.Windows.Forms.DateTimePicker();
            this.positionCB = new System.Windows.Forms.ComboBox();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.addressCB = new System.Windows.Forms.ComboBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.emIdTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emGridData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchTB);
            this.panel1.Controls.Add(this.emGridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 339);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.ForeColor = System.Drawing.Color.Silver;
            this.searchTB.Location = new System.Drawing.Point(344, 17);
            this.searchTB.Multiline = true;
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(208, 30);
            this.searchTB.TabIndex = 2;
            this.searchTB.Text = "Search";
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyDown);
            this.searchTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTB_KeyUp);
            // 
            // emGridData
            // 
            this.emGridData.AllowUserToAddRows = false;
            this.emGridData.AllowUserToDeleteRows = false;
            this.emGridData.AllowUserToResizeRows = false;
            this.emGridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.emGridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.emGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmID,
            this.Firstname,
            this.Lastname,
            this.Phone,
            this.Gender,
            this.DateOfBirth,
            this.Address,
            this.Role,
            this.Position});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emGridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.emGridData.EnableHeadersVisualStyles = false;
            this.emGridData.Location = new System.Drawing.Point(16, 59);
            this.emGridData.Name = "emGridData";
            this.emGridData.ReadOnly = true;
            this.emGridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.emGridData.RowHeadersVisible = false;
            this.emGridData.RowHeadersWidth = 51;
            this.emGridData.RowTemplate.Height = 24;
            this.emGridData.Size = new System.Drawing.Size(1042, 265);
            this.emGridData.TabIndex = 1;
            this.emGridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emGridData_CellClick);
            // 
            // EmID
            // 
            this.EmID.HeaderText = "EmID";
            this.EmID.MinimumWidth = 6;
            this.EmID.Name = "EmID";
            this.EmID.ReadOnly = true;
            this.EmID.Width = 125;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.MinimumWidth = 6;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Width = 125;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.MinimumWidth = 6;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone#";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // DateOfBirth
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DateOfBirth.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.dobDTP);
            this.panel2.Controls.Add(this.positionCB);
            this.panel2.Controls.Add(this.roleCB);
            this.panel2.Controls.Add(this.addressCB);
            this.panel2.Controls.Add(this.genderCB);
            this.panel2.Controls.Add(this.phoneTB);
            this.panel2.Controls.Add(this.lastnameTB);
            this.panel2.Controls.Add(this.firstnameTB);
            this.panel2.Controls.Add(this.emIdTB);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 382);
            this.panel2.TabIndex = 1;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.exportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportBtn.Location = new System.Drawing.Point(768, 313);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(154, 38);
            this.exportBtn.TabIndex = 8;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Image = ((System.Drawing.Image)(resources.GetObject("importBtn.Image")));
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.Location = new System.Drawing.Point(589, 313);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(154, 38);
            this.importBtn.TabIndex = 7;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(884, 245);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 44);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Black;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(765, 245);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 44);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(638, 245);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 44);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(134)))), ((int)(((byte)(30)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(526, 245);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 44);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dobDTP
            // 
            this.dobDTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDTP.Location = new System.Drawing.Point(492, 94);
            this.dobDTP.Name = "dobDTP";
            this.dobDTP.Size = new System.Drawing.Size(209, 32);
            this.dobDTP.TabIndex = 4;
            // 
            // positionCB
            // 
            this.positionCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionCB.FormattingEnabled = true;
            this.positionCB.Items.AddRange(new object[] {
            "Frontend Developer",
            "Backend Developer",
            "Full-Stack Developer",
            "Mobile Developer",
            "Tester",
            "Data Engineer"});
            this.positionCB.Location = new System.Drawing.Point(840, 91);
            this.positionCB.Name = "positionCB";
            this.positionCB.Size = new System.Drawing.Size(208, 32);
            this.positionCB.TabIndex = 2;
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "Staff",
            "Leader"});
            this.roleCB.Location = new System.Drawing.Point(840, 26);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(208, 32);
            this.roleCB.TabIndex = 2;
            // 
            // addressCB
            // 
            this.addressCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressCB.FormattingEnabled = true;
            this.addressCB.Items.AddRange(new object[] {
            "An Giang",
            "Ba Ria - Vung Tau",
            "Bac Lieu",
            "Bac Giang",
            "Bac Kan",
            "Bac Ninh",
            "Ben Tre",
            "Binh Duong",
            "Binh Dinh",
            "Binh Phuoc",
            "Binh Thuan",
            "Ca Mau",
            "Cao Bang",
            "Can Tho",
            "Da Nang",
            "Dak Lak",
            "Dak Nong",
            "Dien Bien",
            "Dong Nai",
            "Dong Thap",
            "Gia Lai",
            "Ha Giang",
            "Ha Nam",
            "Ha Noi",
            "Ha Tinh",
            "Hai Duong",
            "Hai Phong",
            "Hau Giang",
            "Hoa Binh",
            "Hung Yen",
            "Khanh Hoa",
            "Kien Giang",
            "Kon Tum",
            "Lai Chau",
            "Lang Son",
            "Lao Cai",
            "Lam Dong",
            "Long An",
            "Nam Dinh",
            "Nghe An",
            "Ninh Binh",
            "Ninh Thuan",
            "Phu Tho",
            "Phu Yen",
            "Quang Binh",
            "Quang Nam",
            "Quang Ngai",
            "Quang Ninh",
            "Quang Tri",
            "Soc Trang",
            "Son La",
            "Tay Ninh",
            "Thai Binh",
            "Thai Nguyen",
            "Thanh Hoa",
            "Thua Thien Hue",
            "Tien Giang",
            "TP Ho Chi Minh",
            "Tra Vinh",
            "Tuyen Quang",
            "Vinh Long",
            "Vinh Phuc",
            "Yen Bai"});
            this.addressCB.Location = new System.Drawing.Point(491, 163);
            this.addressCB.Name = "addressCB";
            this.addressCB.Size = new System.Drawing.Size(208, 32);
            this.addressCB.TabIndex = 2;
            // 
            // genderCB
            // 
            this.genderCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderCB.Location = new System.Drawing.Point(492, 26);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(208, 32);
            this.genderCB.TabIndex = 2;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(157, 234);
            this.phoneTB.Multiline = true;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(208, 35);
            this.phoneTB.TabIndex = 1;
            // 
            // lastnameTB
            // 
            this.lastnameTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTB.Location = new System.Drawing.Point(157, 163);
            this.lastnameTB.Multiline = true;
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(208, 35);
            this.lastnameTB.TabIndex = 1;
            // 
            // firstnameTB
            // 
            this.firstnameTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTB.Location = new System.Drawing.Point(157, 91);
            this.firstnameTB.Multiline = true;
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(208, 35);
            this.firstnameTB.TabIndex = 1;
            // 
            // emIdTB
            // 
            this.emIdTB.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emIdTB.Location = new System.Drawing.Point(158, 26);
            this.emIdTB.Multiline = true;
            this.emIdTB.Name = "emIdTB";
            this.emIdTB.Size = new System.Drawing.Size(208, 35);
            this.emIdTB.TabIndex = 1;
            this.emIdTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emIdTB_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(735, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dob:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee ID:";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployeeForm";
            this.Size = new System.Drawing.Size(1100, 763);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emGridData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView emGridData;
        private System.Windows.Forms.TextBox emIdTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dobDTP;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox positionCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox addressCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
    }
}