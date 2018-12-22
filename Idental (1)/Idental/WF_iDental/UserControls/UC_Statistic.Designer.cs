namespace WF_iDental.UserControls
{
    partial class UC_Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DevComponents.DotNetBar.Charts.Style.Background background17 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background18 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background19 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background20 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background21 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background22 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background23 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background24 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background25 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background26 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background27 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background28 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background29 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background30 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background31 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background32 = new DevComponents.DotNetBar.Charts.Style.Background();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartControl2 = new DevComponents.DotNetBar.Charts.ChartControl();
            this.chartControl1 = new DevComponents.DotNetBar.Charts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labTimKiem = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labControlName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date2);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labTimKiem);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labControlName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 569);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // date2
            // 
            this.date2.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.date2.Cursor = System.Windows.Forms.Cursors.Default;
            this.date2.CustomFormat = "MM/dd/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(319, 78);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(109, 20);
            this.date2.TabIndex = 28;
            // 
            // date1
            // 
            this.date1.CustomFormat = "MM/dd/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(152, 78);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(96, 20);
            this.date1.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearch.Location = new System.Drawing.Point(531, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 30);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Thống kê";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-6, 188);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Bệnh nhân";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Dịch vụ";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1012, 346);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // chartControl2
            // 
            this.chartControl2.ChartPanel.Legend.Visible = false;
            this.chartControl2.ChartPanel.Name = "PrimaryPanel";
            background17.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background17;
            background18.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background18;
            background19.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background19;
            background20.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background20;
            background21.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background21;
            background22.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background22;
            background23.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background23;
            background24.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background24;
            this.chartControl2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.chartControl2.Location = new System.Drawing.Point(219, 290);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.TabIndex = 13;
            this.chartControl2.Text = "chartControl2";
            // 
            // chartControl1
            // 
            this.chartControl1.ChartPanel.Legend.Visible = false;
            this.chartControl1.ChartPanel.Name = "PrimaryPanel";
            background25.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background25;
            background26.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background26;
            background27.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background27;
            background28.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background28;
            background29.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background29;
            background30.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background30;
            background31.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background31;
            background32.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background32;
            this.chartControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.chartControl1.Location = new System.Drawing.Point(73, 257);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.TabIndex = 12;
            this.chartControl1.Text = "chartControl1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(266, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Thời gian";
            // 
            // labTimKiem
            // 
            this.labTimKiem.AutoSize = true;
            this.labTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labTimKiem.Location = new System.Drawing.Point(12, 121);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(98, 18);
            this.labTimKiem.TabIndex = 22;
            this.labTimKiem.Text = "Kiểu thống kê";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thống kê theo khoảng thời gian",
            "Thống kê số bệnh nhân của từng bác sĩ",
            "Thống kê các dịch vụ và số người sử dụng"});
            this.comboBox1.Location = new System.Drawing.Point(152, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // labControlName
            // 
            this.labControlName.AutoSize = true;
            this.labControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labControlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labControlName.Location = new System.Drawing.Point(48, 34);
            this.labControlName.Name = "labControlName";
            this.labControlName.Size = new System.Drawing.Size(85, 20);
            this.labControlName.TabIndex = 20;
            this.labControlName.Text = "Thống Kê";
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1000, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTimKiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labControlName;
        private DevComponents.DotNetBar.Charts.ChartControl chartControl2;
        private DevComponents.DotNetBar.Charts.ChartControl chartControl1;
    }
}
