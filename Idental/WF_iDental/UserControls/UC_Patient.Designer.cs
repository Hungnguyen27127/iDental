namespace WF_iDental.UserControls
{
    partial class UC_Patient
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
            this.palLett = new System.Windows.Forms.Panel();
            this.panelXLeft = new System.Windows.Forms.Panel();
            this.palRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labTimKiem = new System.Windows.Forms.Label();
            this.palLett.SuspendLayout();
            this.palRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panelRecord.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // palLett
            // 
            this.palLett.Controls.Add(this.labTimKiem);
            this.palLett.Controls.Add(this.panelXLeft);
            this.palLett.Dock = System.Windows.Forms.DockStyle.Left;
            this.palLett.Location = new System.Drawing.Point(0, 0);
            this.palLett.Name = "palLett";
            this.palLett.Size = new System.Drawing.Size(252, 569);
            this.palLett.TabIndex = 0;
            // 
            // panelXLeft
            // 
            this.panelXLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelXLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelXLeft.Location = new System.Drawing.Point(247, 0);
            this.panelXLeft.Name = "panelXLeft";
            this.panelXLeft.Size = new System.Drawing.Size(5, 569);
            this.panelXLeft.TabIndex = 1;
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.panel3);
            this.palRight.Controls.Add(this.panel2);
            this.palRight.Controls.Add(this.panelRecord);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palRight.Location = new System.Drawing.Point(252, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(748, 569);
            this.palRight.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 411);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(743, 158);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPatients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 411);
            this.panel2.TabIndex = 4;
            // 
            // dgvPatients
            // 
            this.dgvPatients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.DateOfBirth,
            this.Gender,
            this.PhoneNumber,
            this.Address,
            this.Image});
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(0, 0);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(743, 411);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Mã";
            this.PatientID.Name = "PatientID";
            this.PatientID.Width = 47;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Tên Bệnh Nhân";
            this.PatientName.Name = "PatientName";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Ngày Sinh";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 108;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            this.Gender.Width = 70;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 108;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.Width = 109;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Hình Ảnh";
            this.Image.Name = "Image";
            this.Image.Width = 70;
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.Color.MediumBlue;
            this.panelRecord.Controls.Add(this.panelBottom);
            this.panelRecord.Controls.Add(this.panelTop);
            this.panelRecord.Controls.Add(this.panel1);
            this.panelRecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRecord.Location = new System.Drawing.Point(743, 0);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(5, 569);
            this.panelRecord.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.button2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 417);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(0, 152);
            this.panelBottom.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button2.Location = new System.Drawing.Point(100, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Test_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dataGridView1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(0, 417);
            this.panelTop.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(0, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 569);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAdd.Location = new System.Drawing.Point(67, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm Bệnh Nhân";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Test_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnEdit.Location = new System.Drawing.Point(275, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa Bệnh Nhân";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Test_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnDelete.Location = new System.Drawing.Point(479, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa Bệnh Nhân";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Test_Click);
            // 
            // labTimKiem
            // 
            this.labTimKiem.AutoSize = true;
            this.labTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labTimKiem.Location = new System.Drawing.Point(31, 30);
            this.labTimKiem.Name = "labTimKiem";
            this.labTimKiem.Size = new System.Drawing.Size(48, 20);
            this.labTimKiem.TabIndex = 2;
            this.labTimKiem.Text = "Mã : ";
            // 
            // UC_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.palRight);
            this.Controls.Add(this.palLett);
            this.Name = "UC_Patient";
            this.Size = new System.Drawing.Size(1000, 569);
            this.Load += new System.EventHandler(this.UC_Patient_Load);
            this.palLett.ResumeLayout(false);
            this.palLett.PerformLayout();
            this.palRight.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panelRecord.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palLett;
        private System.Windows.Forms.Panel panelXLeft;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labTimKiem;
    }
}
