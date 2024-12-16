namespace employeeMS
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalLeader = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalStaff = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalEm = new System.Windows.Forms.Label();
            this.panelColumnChart = new System.Windows.Forms.Panel();
            this.panelLineChart = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmployeeIDLine = new System.Windows.Forms.ComboBox();
            this.btnLoadLineChart = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelColumnChart.SuspendLayout();
            this.panelLineChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 254);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.totalLeader);
            this.panel5.Location = new System.Drawing.Point(725, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 210);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::employeeMS.Properties.Resources.group_leader;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 139);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Leader";
            // 
            // totalLeader
            // 
            this.totalLeader.AutoSize = true;
            this.totalLeader.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLeader.ForeColor = System.Drawing.Color.White;
            this.totalLeader.Location = new System.Drawing.Point(224, 23);
            this.totalLeader.Name = "totalLeader";
            this.totalLeader.Size = new System.Drawing.Size(49, 52);
            this.totalLeader.TabIndex = 1;
            this.totalLeader.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(61)))), ((int)(((byte)(144)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.totalStaff);
            this.panel4.Location = new System.Drawing.Point(379, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 210);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::employeeMS.Properties.Resources.manager;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 145);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff";
            // 
            // totalStaff
            // 
            this.totalStaff.AutoSize = true;
            this.totalStaff.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStaff.ForeColor = System.Drawing.Color.White;
            this.totalStaff.Location = new System.Drawing.Point(224, 23);
            this.totalStaff.Name = "totalStaff";
            this.totalStaff.Size = new System.Drawing.Size(49, 52);
            this.totalStaff.TabIndex = 1;
            this.totalStaff.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.totalEm);
            this.panel3.Location = new System.Drawing.Point(24, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 210);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::employeeMS.Properties.Resources.em_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 119);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // totalEm
            // 
            this.totalEm.AutoSize = true;
            this.totalEm.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalEm.Location = new System.Drawing.Point(242, 23);
            this.totalEm.Name = "totalEm";
            this.totalEm.Size = new System.Drawing.Size(49, 52);
            this.totalEm.TabIndex = 1;
            this.totalEm.Text = "0";
            // 
            // panelColumnChart
            // 
            this.panelColumnChart.BackColor = System.Drawing.Color.White;
            this.panelColumnChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColumnChart.Controls.Add(this.panelLineChart);
            this.panelColumnChart.Controls.Add(this.label2);
            this.panelColumnChart.Controls.Add(this.cmbEmployeeID);
            this.panelColumnChart.Controls.Add(this.btnLoadChart);
            this.panelColumnChart.Controls.Add(this.chart1);
            this.panelColumnChart.Location = new System.Drawing.Point(13, 297);
            this.panelColumnChart.Name = "panelColumnChart";
            this.panelColumnChart.Size = new System.Drawing.Size(1070, 442);
            this.panelColumnChart.TabIndex = 0;
            // 
            // panelLineChart
            // 
            this.panelLineChart.Controls.Add(this.label4);
            this.panelLineChart.Controls.Add(this.cmbEmployeeIDLine);
            this.panelLineChart.Controls.Add(this.btnLoadLineChart);
            this.panelLineChart.Controls.Add(this.chart2);
            this.panelLineChart.Location = new System.Drawing.Point(-1, -1);
            this.panelLineChart.Name = "panelLineChart";
            this.panelLineChart.Size = new System.Drawing.Size(1070, 442);
            this.panelLineChart.TabIndex = 4;
            this.panelLineChart.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(942, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select employee id:";
            // 
            // cmbEmployeeIDLine
            // 
            this.cmbEmployeeIDLine.FormattingEnabled = true;
            this.cmbEmployeeIDLine.Location = new System.Drawing.Point(945, 194);
            this.cmbEmployeeIDLine.Name = "cmbEmployeeIDLine";
            this.cmbEmployeeIDLine.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployeeIDLine.TabIndex = 5;
            // 
            // btnLoadLineChart
            // 
            this.btnLoadLineChart.Location = new System.Drawing.Point(974, 224);
            this.btnLoadLineChart.Name = "btnLoadLineChart";
            this.btnLoadLineChart.Size = new System.Drawing.Size(92, 23);
            this.btnLoadLineChart.TabIndex = 4;
            this.btnLoadLineChart.Text = "Load Chart";
            this.btnLoadLineChart.UseVisualStyleBackColor = true;
            this.btnLoadLineChart.Click += new System.EventHandler(this.btnLoadLineChart_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(4, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "WorkDay";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(1062, 435);
            this.chart2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(943, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select employee id:";
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(946, 168);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployeeID.TabIndex = 2;
            // 
            // btnLoadChart
            // 
            this.btnLoadChart.Location = new System.Drawing.Point(975, 198);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(92, 23);
            this.btnLoadChart.TabIndex = 1;
            this.btnLoadChart.Text = "Load Chart";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Salary";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1062, 438);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1006, 272);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "-->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(926, 272);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<--";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelColumnChart);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(1100, 763);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelColumnChart.ResumeLayout(false);
            this.panelColumnChart.PerformLayout();
            this.panelLineChart.ResumeLayout(false);
            this.panelLineChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelColumnChart;
        private System.Windows.Forms.Label totalEm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalLeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Panel panelLineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmployeeIDLine;
        private System.Windows.Forms.Button btnLoadLineChart;
    }
}
