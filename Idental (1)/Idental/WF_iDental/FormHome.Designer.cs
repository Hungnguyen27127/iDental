namespace WF_iDental
{
    partial class formHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.palTop2 = new System.Windows.Forms.Panel();
            this.labEmployeeID = new System.Windows.Forms.Label();
            this.labPosition = new System.Windows.Forms.Label();
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.palTop = new System.Windows.Forms.Panel();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.btnautosize = new System.Windows.Forms.Button();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labName = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.palMenuLeft = new System.Windows.Forms.Panel();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.palMove = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnMeterials = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnKhamChua = new System.Windows.Forms.Button();
            this.btnLichHen = new System.Windows.Forms.Button();
            this.palContain = new System.Windows.Forms.Panel();
            this.palUC = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.palTop2.SuspendLayout();
            this.palTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.palMenuLeft.SuspendLayout();
            this.palContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // palTop2
            // 
            this.palTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.palTop2.Controls.Add(this.labEmployeeID);
            this.palTop2.Controls.Add(this.labPosition);
            this.palTop2.Controls.Add(this.label1);
            this.palTop2.Controls.Add(this.labEmployeeName);
            this.palTop2.Controls.Add(this.labTime);
            this.palTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTop2.Location = new System.Drawing.Point(250, 52);
            this.palTop2.Name = "palTop2";
            this.palTop2.Size = new System.Drawing.Size(1000, 99);
            this.palTop2.TabIndex = 6;
            // 
            // labEmployeeID
            // 
            this.labEmployeeID.AutoSize = true;
            this.labEmployeeID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.labEmployeeID.ForeColor = System.Drawing.Color.White;
            this.labEmployeeID.Location = new System.Drawing.Point(163, 53);
            this.labEmployeeID.Name = "labEmployeeID";
            this.labEmployeeID.Size = new System.Drawing.Size(40, 22);
            this.labEmployeeID.TabIndex = 7;
            this.labEmployeeID.Text = "- 4";
            // 
            // labPosition
            // 
            this.labPosition.AutoSize = true;
            this.labPosition.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPosition.ForeColor = System.Drawing.Color.White;
            this.labPosition.Location = new System.Drawing.Point(17, 53);
            this.labPosition.Name = "labPosition";
            this.labPosition.Size = new System.Drawing.Size(140, 22);
            this.labPosition.TabIndex = 6;
            this.labPosition.Text = "Quyền : Admin";
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeName.ForeColor = System.Drawing.Color.White;
            this.labEmployeeName.Location = new System.Drawing.Point(143, 18);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(150, 22);
            this.labEmployeeName.TabIndex = 5;
            this.labEmployeeName.Text = "Dương Hải Quân";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.ForeColor = System.Drawing.Color.White;
            this.labTime.Location = new System.Drawing.Point(843, 34);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(90, 22);
            this.labTime.TabIndex = 4;
            this.labTime.Text = "HH:MM:SS";
            // 
            // palTop
            // 
            this.palTop.BackColor = System.Drawing.Color.White;
            this.palTop.Controls.Add(this.picMin);
            this.palTop.Controls.Add(this.picMax);
            this.palTop.Controls.Add(this.btnautosize);
            this.palTop.Controls.Add(this.picExit);
            this.palTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTop.Location = new System.Drawing.Point(250, 0);
            this.palTop.Name = "palTop";
            this.palTop.Size = new System.Drawing.Size(1000, 52);
            this.palTop.TabIndex = 5;
            this.palTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palTop_MouseDown);
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(855, 5);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(43, 43);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 10;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picMax
            // 
            this.picMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMax.Image = ((System.Drawing.Image)(resources.GetObject("picMax.Image")));
            this.picMax.Location = new System.Drawing.Point(904, 4);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(43, 43);
            this.picMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMax.TabIndex = 9;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnautosize
            // 
            this.btnautosize.FlatAppearance.BorderSize = 0;
            this.btnautosize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnautosize.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautosize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnautosize.Image = ((System.Drawing.Image)(resources.GetObject("btnautosize.Image")));
            this.btnautosize.Location = new System.Drawing.Point(0, 3);
            this.btnautosize.Name = "btnautosize";
            this.btnautosize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnautosize.Size = new System.Drawing.Size(50, 46);
            this.btnautosize.TabIndex = 8;
            this.btnautosize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnautosize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnautosize.UseVisualStyleBackColor = true;
            this.btnautosize.Click += new System.EventHandler(this.btnautosize_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(953, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(44, 46);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labName);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 128);
            this.panel1.TabIndex = 4;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.SystemColors.Window;
            this.labName.Location = new System.Drawing.Point(72, 67);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(114, 31);
            this.labName.TabIndex = 5;
            this.labName.Text = "Idental";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(88, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(73, 64);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;
            // 
            // palMenuLeft
            // 
            this.palMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.palMenuLeft.Controls.Add(this.btnBenhNhan);
            this.palMenuLeft.Controls.Add(this.palMove);
            this.palMenuLeft.Controls.Add(this.btnHome);
            this.palMenuLeft.Controls.Add(this.panel1);
            this.palMenuLeft.Controls.Add(this.btnReport);
            this.palMenuLeft.Controls.Add(this.btnMeterials);
            this.palMenuLeft.Controls.Add(this.btnNhanVien);
            this.palMenuLeft.Controls.Add(this.btnDichVu);
            this.palMenuLeft.Controls.Add(this.btnKhamChua);
            this.palMenuLeft.Controls.Add(this.btnLichHen);
            this.palMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.palMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.palMenuLeft.Name = "palMenuLeft";
            this.palMenuLeft.Size = new System.Drawing.Size(250, 720);
            this.palMenuLeft.TabIndex = 4;
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.FlatAppearance.BorderSize = 0;
            this.btnBenhNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnBenhNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenhNhan.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnBenhNhan.Image")));
            this.btnBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBenhNhan.Location = new System.Drawing.Point(8, 222);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBenhNhan.Size = new System.Drawing.Size(240, 62);
            this.btnBenhNhan.TabIndex = 1;
            this.btnBenhNhan.Text = "   Bệnh Nhân";
            this.btnBenhNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBenhNhan.UseVisualStyleBackColor = false;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // palMove
            // 
            this.palMove.BackColor = System.Drawing.Color.White;
            this.palMove.Location = new System.Drawing.Point(0, 154);
            this.palMove.Name = "palMove";
            this.palMove.Size = new System.Drawing.Size(10, 62);
            this.palMove.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(9, 154);
            this.btnHome.Name = "btnHome";
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(240, 62);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "   Trang Chủ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(10, 630);
            this.btnReport.Name = "btnReport";
            this.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReport.Size = new System.Drawing.Size(240, 62);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "   Thống kê";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMeterials
            // 
            this.btnMeterials.FlatAppearance.BorderSize = 0;
            this.btnMeterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeterials.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeterials.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMeterials.Image = ((System.Drawing.Image)(resources.GetObject("btnMeterials.Image")));
            this.btnMeterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeterials.Location = new System.Drawing.Point(11, 562);
            this.btnMeterials.Name = "btnMeterials";
            this.btnMeterials.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMeterials.Size = new System.Drawing.Size(240, 62);
            this.btnMeterials.TabIndex = 6;
            this.btnMeterials.Text = "   Vật Liệu";
            this.btnMeterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMeterials.UseVisualStyleBackColor = true;
            this.btnMeterials.Click += new System.EventHandler(this.btnMeterials_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(10, 494);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNhanVien.Size = new System.Drawing.Size(240, 62);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "   Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(10, 426);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDichVu.Size = new System.Drawing.Size(240, 62);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = "   Dịch Vụ";
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnKhamChua
            // 
            this.btnKhamChua.FlatAppearance.BorderSize = 0;
            this.btnKhamChua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhamChua.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhamChua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhamChua.Image = ((System.Drawing.Image)(resources.GetObject("btnKhamChua.Image")));
            this.btnKhamChua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhamChua.Location = new System.Drawing.Point(10, 358);
            this.btnKhamChua.Name = "btnKhamChua";
            this.btnKhamChua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKhamChua.Size = new System.Drawing.Size(240, 62);
            this.btnKhamChua.TabIndex = 3;
            this.btnKhamChua.Text = "   Khám Chữa";
            this.btnKhamChua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhamChua.UseVisualStyleBackColor = true;
            this.btnKhamChua.Click += new System.EventHandler(this.btnKhamChua_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.FlatAppearance.BorderSize = 0;
            this.btnLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichHen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichHen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHen.Image")));
            this.btnLichHen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHen.Location = new System.Drawing.Point(9, 290);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLichHen.Size = new System.Drawing.Size(240, 62);
            this.btnLichHen.TabIndex = 2;
            this.btnLichHen.Text = "   Lịch Hẹn";
            this.btnLichHen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichHen.UseVisualStyleBackColor = true;
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // palContain
            // 
            this.palContain.Controls.Add(this.palUC);
            this.palContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palContain.Location = new System.Drawing.Point(250, 151);
            this.palContain.Name = "palContain";
            this.palContain.Size = new System.Drawing.Size(1000, 569);
            this.palContain.TabIndex = 7;
            // 
            // palUC
            // 
            this.palUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palUC.Location = new System.Drawing.Point(0, 0);
            this.palUC.Name = "palUC";
            this.palUC.Size = new System.Drawing.Size(1000, 569);
            this.palUC.TabIndex = 0;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xin Chào : ";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.palContain);
            this.Controls.Add(this.palTop2);
            this.Controls.Add(this.palTop);
            this.Controls.Add(this.palMenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.palTop2.ResumeLayout(false);
            this.palTop2.PerformLayout();
            this.palTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.palMenuLeft.ResumeLayout(false);
            this.palContain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palTop2;
        private System.Windows.Forms.Label labPosition;
        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Panel palTop;
        private System.Windows.Forms.Button btnautosize;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel palMenuLeft;
        private System.Windows.Forms.Panel palContain;
        private System.Windows.Forms.Panel palUC;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Panel palMove;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnMeterials;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnKhamChua;
        private System.Windows.Forms.Button btnLichHen;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.Label labEmployeeID;
        private System.Windows.Forms.Label label1;
    }
}