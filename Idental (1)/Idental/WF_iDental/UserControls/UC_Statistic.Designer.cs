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
            DevComponents.DotNetBar.Charts.Style.Background background33 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background34 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background35 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background36 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background37 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background38 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background39 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background40 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background41 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background42 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background43 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background44 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background45 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background46 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background47 = new DevComponents.DotNetBar.Charts.Style.Background();
            DevComponents.DotNetBar.Charts.Style.Background background48 = new DevComponents.DotNetBar.Charts.Style.Background();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labControlName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labTimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevComponents.DotNetBar.Charts.ChartControl();
            this.chartControl2 = new DevComponents.DotNetBar.Charts.ChartControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSearch = new System.Windows.Forms.Button();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labControlName
            // 
            this.labControlName.AutoSize = true;
            this.labControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labControlName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labControlName.Location = new System.Drawing.Point(39, 25);
            this.labControlName.Name = "labControlName";
            this.labControlName.Size = new System.Drawing.Size(85, 20);
            this.labControlName.TabIndex = 3;
            this.labControlName.Text = "Thống Kê";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thống kê theo khoảng thời gian",
            "Thống kê số bệnh nhân của từng bác sĩ",
            "Thống kê các dịch vụ và số người sử dụng"});
            this.comboBox1.Location = new System.Drawing.Point(143, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labTimKiem
            // 
            this.labTimKiem.AutoSize = true;
            this.labTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labTimKiem.Location = new System.Drawing.Point(3, 112);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(98, 18);
            this.labTimKiem.TabIndex = 8;
            this.labTimKiem.Text = "Kiểu thống kê";
            this.labTimKiem.Click += new System.EventHandler(this.labTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(257, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.ChartPanel.Legend.Visible = false;
            this.chartControl1.ChartPanel.Name = "PrimaryPanel";
            background33.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background33;
            background34.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background34;
            background35.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background35;
            background36.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background36;
            background37.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background37;
            background38.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background38;
            background39.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background39;
            background40.Color1 = System.Drawing.Color.White;
            this.chartControl1.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background40;
            this.chartControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.chartControl1.Location = new System.Drawing.Point(73, 257);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.TabIndex = 12;
            this.chartControl1.Text = "chartControl1";
            // 
            // chartControl2
            // 
            this.chartControl2.ChartPanel.Legend.Visible = false;
            this.chartControl2.ChartPanel.Name = "PrimaryPanel";
            background41.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ArrowBackground = background41;
            background42.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.MouseOver.ThumbBackground = background42;
            background43.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background43;
            background44.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.HScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background44;
            background45.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ArrowBackground = background45;
            background46.Color1 = System.Drawing.Color.AliceBlue;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.MouseOver.ThumbBackground = background46;
            background47.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ArrowBackground = background47;
            background48.Color1 = System.Drawing.Color.White;
            this.chartControl2.DefaultVisualStyles.VScrollBarVisualStyles.SelectedMouseOver.ThumbBackground = background48;
            this.chartControl2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.chartControl2.Location = new System.Drawing.Point(219, 290);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.TabIndex = 13;
            this.chartControl2.Text = "chartControl2";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-15, 179);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Bệnh nhân";
            series5.YValuesPerPoint = 2;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Dịch vụ";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1012, 346);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearch.Location = new System.Drawing.Point(522, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Thống kê";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // date1
            // 
            this.date1.CustomFormat = "MM/dd/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(143, 69);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(96, 20);
            this.date1.TabIndex = 17;
            // 
            // date2
            // 
            this.date2.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.date2.Cursor = System.Windows.Forms.Cursors.Default;
            this.date2.CustomFormat = "MM/dd/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(310, 69);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(109, 20);
            this.date2.TabIndex = 19;
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labTimKiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labControlName);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1000, 569);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labControlName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Charts.ChartControl chartControl1;
        private DevComponents.DotNetBar.Charts.ChartControl chartControl2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
    }
}
