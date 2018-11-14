namespace WF_iDental.UserControls
{
    partial class UC_Appointment
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
            this.palTop = new System.Windows.Forms.Panel();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labOption = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAppointment = new System.Windows.Forms.TextBox();
            this.dtpDateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbDoctor = new System.Windows.Forms.ComboBox();
            this.palTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
            this.palControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // palTop
            // 
            this.palTop.Controls.Add(this.dgvLichHen);
            this.palTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTop.Location = new System.Drawing.Point(0, 0);
            this.palTop.Name = "palTop";
            this.palTop.Size = new System.Drawing.Size(1000, 409);
            this.palTop.TabIndex = 0;
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.EmployeeName,
            this.Date,
            this.EmployeeID});
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(0, 0);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.Size = new System.Drawing.Size(1000, 409);
            this.dgvLichHen.TabIndex = 0;
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "Mã Lịch Hẹn";
            this.AppointmentID.Name = "AppointmentID";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Tên Bác Sĩ";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày Hẹn";
            this.Date.Name = "Date";
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Mã Bác Sĩ";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // palControl
            // 
            this.palControl.Controls.Add(this.cbbDoctor);
            this.palControl.Controls.Add(this.panel1);
            this.palControl.Controls.Add(this.dtpDateAppointment);
            this.palControl.Controls.Add(this.label2);
            this.palControl.Controls.Add(this.label1);
            this.palControl.Controls.Add(this.labSearch);
            this.palControl.Controls.Add(this.txtDoctorID);
            this.palControl.Controls.Add(this.btnSearch);
            this.palControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palControl.Location = new System.Drawing.Point(0, 409);
            this.palControl.Name = "palControl";
            this.palControl.Size = new System.Drawing.Size(1000, 160);
            this.palControl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labOption);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtAppointment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(625, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 160);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(276, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã :";
            // 
            // labOption
            // 
            this.labOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOption.AutoSize = true;
            this.labOption.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labOption.Location = new System.Drawing.Point(11, 12);
            this.labOption.Name = "labOption";
            this.labOption.Size = new System.Drawing.Size(100, 21);
            this.labOption.TabIndex = 3;
            this.labOption.Text = "Tùy Chọn:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 160);
            this.panel2.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(264, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.Location = new System.Drawing.Point(147, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 31);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(18, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAppointment
            // 
            this.txtAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointment.Location = new System.Drawing.Point(315, 13);
            this.txtAppointment.Name = "txtAppointment";
            this.txtAppointment.ReadOnly = true;
            this.txtAppointment.Size = new System.Drawing.Size(45, 21);
            this.txtAppointment.TabIndex = 1;
            // 
            // dtpDateAppointment
            // 
            this.dtpDateAppointment.Location = new System.Drawing.Point(157, 77);
            this.dtpDateAppointment.Name = "dtpDateAppointment";
            this.dtpDateAppointment.Size = new System.Drawing.Size(206, 20);
            this.dtpDateAppointment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bác sĩ :";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labSearch.Location = new System.Drawing.Point(14, 12);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(102, 21);
            this.labSearch.TabIndex = 2;
            this.labSearch.Text = "Tìm Kiếm:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.txtDoctorID.Location = new System.Drawing.Point(157, 43);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(206, 21);
            this.txtDoctorID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnSearch.Location = new System.Drawing.Point(511, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 31);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "  Tìm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbbDoctor
            // 
            this.cbbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.cbbDoctor.FormattingEnabled = true;
            this.cbbDoctor.Location = new System.Drawing.Point(399, 43);
            this.cbbDoctor.Name = "cbbDoctor";
            this.cbbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbbDoctor.TabIndex = 7;
            // 
            // UC_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.palControl);
            this.Controls.Add(this.palTop);
            this.Name = "UC_Appointment";
            this.Size = new System.Drawing.Size(1000, 569);
            this.Load += new System.EventHandler(this.UC_Appointment_Load);
            this.palTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.palControl.ResumeLayout(false);
            this.palControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palTop;
        private System.Windows.Forms.DataGridView dgvLichHen;
        private System.Windows.Forms.Panel palControl;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDateAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labOption;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.TextBox txtAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDoctor;
    }
}
