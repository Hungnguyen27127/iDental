namespace WF_iDental
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.palTop = new System.Windows.Forms.Panel();
            this.palContain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedicalRecordID = new System.Windows.Forms.TextBox();
            this.btnBillCancle = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.MedicalRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.palBillBottom = new System.Windows.Forms.Panel();
            this.palBillTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.palTop.SuspendLayout();
            this.palContain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.palBillTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // palTop
            // 
            this.palTop.Controls.Add(this.palContain);
            this.palTop.Controls.Add(this.panel1);
            this.palTop.Controls.Add(this.palBillBottom);
            this.palTop.Controls.Add(this.palBillTop);
            this.palTop.Controls.Add(this.panel2);
            this.palTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTop.Location = new System.Drawing.Point(0, 0);
            this.palTop.Name = "palTop";
            this.palTop.Size = new System.Drawing.Size(894, 494);
            this.palTop.TabIndex = 0;
            // 
            // palContain
            // 
            this.palContain.Controls.Add(this.label3);
            this.palContain.Controls.Add(this.txtTotalBill);
            this.palContain.Controls.Add(this.label2);
            this.palContain.Controls.Add(this.txtName);
            this.palContain.Controls.Add(this.label1);
            this.palContain.Controls.Add(this.label7);
            this.palContain.Controls.Add(this.txtMedicalRecordID);
            this.palContain.Controls.Add(this.btnBillCancle);
            this.palContain.Controls.Add(this.btnDone);
            this.palContain.Controls.Add(this.panel3);
            this.palContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palContain.Location = new System.Drawing.Point(4, 57);
            this.palContain.Name = "palContain";
            this.palContain.Size = new System.Drawing.Size(886, 427);
            this.palContain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(301, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "VNĐ";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(156, 386);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.ReadOnly = true;
            this.txtTotalBill.Size = new System.Drawing.Size(116, 27);
            this.txtTotalBill.TabIndex = 9;
            this.txtTotalBill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTotalBill_MouseClick);
            this.txtTotalBill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(8, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng Tiền :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 310);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(227, 27);
            this.txtName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(8, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Bệnh Nhân : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(8, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã:";
            // 
            // txtMedicalRecordID
            // 
            this.txtMedicalRecordID.Location = new System.Drawing.Point(156, 348);
            this.txtMedicalRecordID.Name = "txtMedicalRecordID";
            this.txtMedicalRecordID.ReadOnly = true;
            this.txtMedicalRecordID.Size = new System.Drawing.Size(116, 27);
            this.txtMedicalRecordID.TabIndex = 4;
            // 
            // btnBillCancle
            // 
            this.btnBillCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillCancle.FlatAppearance.BorderSize = 0;
            this.btnBillCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillCancle.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBillCancle.Location = new System.Drawing.Point(746, 364);
            this.btnBillCancle.Name = "btnBillCancle";
            this.btnBillCancle.Size = new System.Drawing.Size(115, 49);
            this.btnBillCancle.TabIndex = 0;
            this.btnBillCancle.Text = "Hủy";
            this.btnBillCancle.UseVisualStyleBackColor = true;
            this.btnBillCancle.Click += new System.EventHandler(this.btnBillCancle_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Location = new System.Drawing.Point(603, 364);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(115, 49);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Thanh Toán";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 293);
            this.panel3.TabIndex = 3;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicalRecordID,
            this.BillID,
            this.ServiceID,
            this.ServiceName,
            this.UnitPrice});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.Size = new System.Drawing.Size(886, 293);
            this.dgvBill.TabIndex = 1;
            // 
            // MedicalRecordID
            // 
            this.MedicalRecordID.DataPropertyName = "MedicalRecordID";
            this.MedicalRecordID.HeaderText = "Mã Bệnh Án";
            this.MedicalRecordID.Name = "MedicalRecordID";
            this.MedicalRecordID.ReadOnly = true;
            this.MedicalRecordID.Width = 125;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "Mã Hóa Đơn";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            this.BillID.Width = 125;
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "Mã Dịch Vụ";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Width = 125;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Tên Dịch Vụ";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 340;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn Giá";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(890, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 427);
            this.panel1.TabIndex = 1;
            // 
            // palBillBottom
            // 
            this.palBillBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.palBillBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palBillBottom.Location = new System.Drawing.Point(4, 484);
            this.palBillBottom.Name = "palBillBottom";
            this.palBillBottom.Size = new System.Drawing.Size(890, 10);
            this.palBillBottom.TabIndex = 0;
            // 
            // palBillTop
            // 
            this.palBillTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.palBillTop.Controls.Add(this.pictureBox1);
            this.palBillTop.Controls.Add(this.labBill);
            this.palBillTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.palBillTop.Location = new System.Drawing.Point(4, 0);
            this.palBillTop.Name = "palBillTop";
            this.palBillTop.Size = new System.Drawing.Size(890, 57);
            this.palBillTop.TabIndex = 0;
            this.palBillTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.palBillTop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labBill
            // 
            this.labBill.AutoSize = true;
            this.labBill.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBill.ForeColor = System.Drawing.Color.White;
            this.labBill.Location = new System.Drawing.Point(91, 11);
            this.labBill.Name = "labBill";
            this.labBill.Size = new System.Drawing.Size(142, 28);
            this.labBill.TabIndex = 0;
            this.labBill.Text = "Thanh Toán";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 494);
            this.panel2.TabIndex = 0;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 494);
            this.Controls.Add(this.palTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.palTop.ResumeLayout(false);
            this.palContain.ResumeLayout(false);
            this.palContain.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.palBillTop.ResumeLayout(false);
            this.palBillTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palTop;
        private System.Windows.Forms.Panel palContain;
        private System.Windows.Forms.Button btnBillCancle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel palBillBottom;
        private System.Windows.Forms.Panel palBillTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TextBox txtMedicalRecordID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}