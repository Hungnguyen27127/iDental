namespace WF_iDental
{
    partial class CompleteRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.palLeft = new System.Windows.Forms.Panel();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dtkDateOfCreate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDateOfCreate = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labDateOfBirth = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.palRight = new System.Windows.Forms.Panel();
            this.palExtendBill = new System.Windows.Forms.Panel();
            this.dgvListBillExtend = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalRecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palServiceMedicine = new System.Windows.Forms.Panel();
            this.menutabServiceMedicin = new System.Windows.Forms.TabControl();
            this.tabService = new System.Windows.Forms.TabPage();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.cbbSeviceName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabKeDon = new System.Windows.Forms.TabPage();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.txtAmong = new System.Windows.Forms.TextBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.cbbMedicine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbCatelogy = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiagnostic = new System.Windows.Forms.TextBox();
            this.txtservice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labChonDichVu = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.palLeft.SuspendLayout();
            this.palRight.SuspendLayout();
            this.palExtendBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillExtend)).BeginInit();
            this.palServiceMedicine.SuspendLayout();
            this.menutabServiceMedicin.SuspendLayout();
            this.tabService.SuspendLayout();
            this.tabKeDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(86)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 5);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(86)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 53);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khám chữa bệnh";
            // 
            // palLeft
            // 
            this.palLeft.Controls.Add(this.txtPatientID);
            this.palLeft.Controls.Add(this.textBox3);
            this.palLeft.Controls.Add(this.dtkDateOfCreate);
            this.palLeft.Controls.Add(this.label4);
            this.palLeft.Controls.Add(this.label10);
            this.palLeft.Controls.Add(this.label8);
            this.palLeft.Controls.Add(this.label1);
            this.palLeft.Controls.Add(this.labDateOfCreate);
            this.palLeft.Controls.Add(this.labGender);
            this.palLeft.Controls.Add(this.labDateOfBirth);
            this.palLeft.Controls.Add(this.labName);
            this.palLeft.Controls.Add(this.lab1);
            this.palLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.palLeft.Location = new System.Drawing.Point(0, 53);
            this.palLeft.Name = "palLeft";
            this.palLeft.Size = new System.Drawing.Size(376, 457);
            this.palLeft.TabIndex = 3;
            this.palLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.palLeft_Paint);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatientID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(183, 175);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(47, 26);
            this.txtPatientID.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(950, 345);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 1;
            // 
            // dtkDateOfCreate
            // 
            this.dtkDateOfCreate.CustomFormat = "dd/MM/yyyy";
            this.dtkDateOfCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkDateOfCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkDateOfCreate.Location = new System.Drawing.Point(183, 357);
            this.dtkDateOfCreate.Name = "dtkDateOfCreate";
            this.dtkDateOfCreate.Size = new System.Drawing.Size(130, 26);
            this.dtkDateOfCreate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = " Thông Tin Bệnh Nhân";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Bệnh Nhân:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = " Giới Tính :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Sinh:";
            // 
            // labDateOfCreate
            // 
            this.labDateOfCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDateOfCreate.AutoSize = true;
            this.labDateOfCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateOfCreate.Location = new System.Drawing.Point(56, 359);
            this.labDateOfCreate.Name = "labDateOfCreate";
            this.labDateOfCreate.Size = new System.Drawing.Size(94, 20);
            this.labDateOfCreate.TabIndex = 0;
            this.labDateOfCreate.Text = "Ngày Khám:";
            this.labDateOfCreate.Click += new System.EventHandler(this.label8_Click);
            // 
            // labGender
            // 
            this.labGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGender.Location = new System.Drawing.Point(179, 311);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(83, 21);
            this.labGender.TabIndex = 0;
            this.labGender.Text = "Someone";
            // 
            // labDateOfBirth
            // 
            this.labDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDateOfBirth.AutoSize = true;
            this.labDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateOfBirth.Location = new System.Drawing.Point(179, 265);
            this.labDateOfBirth.Name = "labDateOfBirth";
            this.labDateOfBirth.Size = new System.Drawing.Size(83, 21);
            this.labDateOfBirth.TabIndex = 0;
            this.labDateOfBirth.Text = "Someone";
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(179, 217);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(83, 21);
            this.labName.TabIndex = 0;
            this.labName.Text = "Someone";
            // 
            // lab1
            // 
            this.lab1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(26, 214);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(124, 20);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Tên Bệnh Nhân:";
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.palExtendBill);
            this.palRight.Controls.Add(this.palServiceMedicine);
            this.palRight.Controls.Add(this.btnNext);
            this.palRight.Controls.Add(this.btnAddService);
            this.palRight.Controls.Add(this.panel3);
            this.palRight.Controls.Add(this.txtDoctorID);
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.label11);
            this.palRight.Controls.Add(this.txtdiagnostic);
            this.palRight.Controls.Add(this.txtservice);
            this.palRight.Controls.Add(this.label7);
            this.palRight.Controls.Add(this.label5);
            this.palRight.Controls.Add(this.labChonDichVu);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palRight.Location = new System.Drawing.Point(376, 53);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(785, 457);
            this.palRight.TabIndex = 3;
            this.palRight.Paint += new System.Windows.Forms.PaintEventHandler(this.palRight_Paint);
            // 
            // palExtendBill
            // 
            this.palExtendBill.Controls.Add(this.dgvListBillExtend);
            this.palExtendBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.palExtendBill.Location = new System.Drawing.Point(775, 0);
            this.palExtendBill.Name = "palExtendBill";
            this.palExtendBill.Size = new System.Drawing.Size(10, 447);
            this.palExtendBill.TabIndex = 13;
            // 
            // dgvListBillExtend
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.dgvListBillExtend.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListBillExtend.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBillExtend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBillExtend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.PatientName,
            this.DateOfCreate,
            this.Diagnostic,
            this.MedicalRecordID});
            this.dgvListBillExtend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBillExtend.Location = new System.Drawing.Point(0, 0);
            this.dgvListBillExtend.Name = "dgvListBillExtend";
            this.dgvListBillExtend.ReadOnly = true;
            this.dgvListBillExtend.Size = new System.Drawing.Size(10, 447);
            this.dgvListBillExtend.TabIndex = 1;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "Mã Hóa Đơn";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Tên Bệnh Nhân";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.DataPropertyName = "DateOfCreate";
            this.DateOfCreate.HeaderText = "Ngày Khám";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.ReadOnly = true;
            // 
            // Diagnostic
            // 
            this.Diagnostic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diagnostic.DataPropertyName = "Diagnostic";
            this.Diagnostic.HeaderText = "Chuẩn Đoán";
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.ReadOnly = true;
            // 
            // MedicalRecordID
            // 
            this.MedicalRecordID.DataPropertyName = "MedicalRecordID";
            this.MedicalRecordID.HeaderText = "Mã Lịch Sử Khám";
            this.MedicalRecordID.Name = "MedicalRecordID";
            this.MedicalRecordID.ReadOnly = true;
            // 
            // palServiceMedicine
            // 
            this.palServiceMedicine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.palServiceMedicine.Controls.Add(this.menutabServiceMedicin);
            this.palServiceMedicine.Controls.Add(this.btnKetThuc);
            this.palServiceMedicine.Controls.Add(this.btnThem);
            this.palServiceMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palServiceMedicine.Location = new System.Drawing.Point(2, 447);
            this.palServiceMedicine.Name = "palServiceMedicine";
            this.palServiceMedicine.Size = new System.Drawing.Size(783, 10);
            this.palServiceMedicine.TabIndex = 12;
            // 
            // menutabServiceMedicin
            // 
            this.menutabServiceMedicin.Controls.Add(this.tabService);
            this.menutabServiceMedicin.Controls.Add(this.tabKeDon);
            this.menutabServiceMedicin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menutabServiceMedicin.Location = new System.Drawing.Point(6, 9);
            this.menutabServiceMedicin.Multiline = true;
            this.menutabServiceMedicin.Name = "menutabServiceMedicin";
            this.menutabServiceMedicin.SelectedIndex = 0;
            this.menutabServiceMedicin.Size = new System.Drawing.Size(765, 167);
            this.menutabServiceMedicin.TabIndex = 7;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.txtUnitPrice);
            this.tabService.Controls.Add(this.txtBillID);
            this.tabService.Controls.Add(this.cbbSeviceName);
            this.tabService.Controls.Add(this.label6);
            this.tabService.Controls.Add(this.label13);
            this.tabService.Controls.Add(this.label12);
            this.tabService.Location = new System.Drawing.Point(4, 27);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(757, 136);
            this.tabService.TabIndex = 0;
            this.tabService.Text = "Dịch Vụ";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(174, 68);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(178, 26);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // txtBillID
            // 
            this.txtBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBillID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillID.Location = new System.Drawing.Point(672, 24);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(47, 26);
            this.txtBillID.TabIndex = 12;
            // 
            // cbbSeviceName
            // 
            this.cbbSeviceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeviceName.FormattingEnabled = true;
            this.cbbSeviceName.Location = new System.Drawing.Point(174, 21);
            this.cbbSeviceName.Name = "cbbSeviceName";
            this.cbbSeviceName.Size = new System.Drawing.Size(284, 26);
            this.cbbSeviceName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(540, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã Hóa Đơn:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Giá Dịch Vụ:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Tên Dịch Vụ:";
            // 
            // tabKeDon
            // 
            this.tabKeDon.Controls.Add(this.txtRecordID);
            this.tabKeDon.Controls.Add(this.txtAmong);
            this.tabKeDon.Controls.Add(this.txtUsage);
            this.tabKeDon.Controls.Add(this.cbbMedicine);
            this.tabKeDon.Controls.Add(this.label2);
            this.tabKeDon.Controls.Add(this.label17);
            this.tabKeDon.Controls.Add(this.cbbCatelogy);
            this.tabKeDon.Controls.Add(this.label19);
            this.tabKeDon.Controls.Add(this.label18);
            this.tabKeDon.Controls.Add(this.label16);
            this.tabKeDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabKeDon.Location = new System.Drawing.Point(4, 27);
            this.tabKeDon.Name = "tabKeDon";
            this.tabKeDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeDon.Size = new System.Drawing.Size(757, 136);
            this.tabKeDon.TabIndex = 1;
            this.tabKeDon.Text = "Kê Đơn Thuốc";
            this.tabKeDon.UseVisualStyleBackColor = true;
            // 
            // txtRecordID
            // 
            this.txtRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordID.Location = new System.Drawing.Point(134, 8);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.ReadOnly = true;
            this.txtRecordID.Size = new System.Drawing.Size(66, 26);
            this.txtRecordID.TabIndex = 35;
            // 
            // txtAmong
            // 
            this.txtAmong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmong.Location = new System.Drawing.Point(514, 98);
            this.txtAmong.Name = "txtAmong";
            this.txtAmong.Size = new System.Drawing.Size(192, 24);
            this.txtAmong.TabIndex = 32;
            // 
            // txtUsage
            // 
            this.txtUsage.AcceptsReturn = true;
            this.txtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(134, 96);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(168, 24);
            this.txtUsage.TabIndex = 33;
            // 
            // cbbMedicine
            // 
            this.cbbMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMedicine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMedicine.FormattingEnabled = true;
            this.cbbMedicine.Location = new System.Drawing.Point(514, 46);
            this.cbbMedicine.Name = "cbbMedicine";
            this.cbbMedicine.Size = new System.Drawing.Size(216, 28);
            this.cbbMedicine.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã LSK:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(407, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 26;
            this.label17.Text = "Tên Thuốc:";
            // 
            // cbbCatelogy
            // 
            this.cbbCatelogy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbCatelogy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCatelogy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCatelogy.FormattingEnabled = true;
            this.cbbCatelogy.Location = new System.Drawing.Point(134, 46);
            this.cbbCatelogy.Name = "cbbCatelogy";
            this.cbbCatelogy.Size = new System.Drawing.Size(227, 28);
            this.cbbCatelogy.TabIndex = 31;
            this.cbbCatelogy.SelectedIndexChanged += new System.EventHandler(this.cbbCatelogy_SelectedIndexChanged);
            this.cbbCatelogy.SelectedValueChanged += new System.EventHandler(this.cbbCatelogy_SelectedValueChanged_1);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(403, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Liều Lượng:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(26, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Cách Dùng:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Danh Mục:";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKetThuc.FlatAppearance.BorderSize = 0;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(86)))), ((int)(((byte)(45)))));
            this.btnKetThuc.Location = new System.Drawing.Point(654, 77);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(117, 40);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(518, 77);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(510, 359);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 37);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Tiếp Tục";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.Image")));
            this.btnAddService.Location = new System.Drawing.Point(646, 187);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(28, 28);
            this.btnAddService.TabIndex = 8;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 457);
            this.panel3.TabIndex = 6;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDoctorID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.Location = new System.Drawing.Point(715, 31);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(46, 26);
            this.txtDoctorID.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(646, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(616, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã Bác Sỹ:";
            // 
            // txtdiagnostic
            // 
            this.txtdiagnostic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiagnostic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnostic.Location = new System.Drawing.Point(243, 78);
            this.txtdiagnostic.Multiline = true;
            this.txtdiagnostic.Name = "txtdiagnostic";
            this.txtdiagnostic.Size = new System.Drawing.Size(386, 100);
            this.txtdiagnostic.TabIndex = 1;
            // 
            // txtservice
            // 
            this.txtservice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtservice.Location = new System.Drawing.Point(243, 187);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(386, 26);
            this.txtservice.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chuẩn Đoán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(268, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông Tin Khám Chữa";
            // 
            // labChonDichVu
            // 
            this.labChonDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labChonDichVu.AutoSize = true;
            this.labChonDichVu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChonDichVu.Location = new System.Drawing.Point(77, 190);
            this.labChonDichVu.Name = "labChonDichVu";
            this.labChonDichVu.Size = new System.Drawing.Size(119, 21);
            this.labChonDichVu.TabIndex = 0;
            this.labChonDichVu.Text = "Chọn Dịch Vụ:";
            // 
            // CompleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 515);
            this.Controls.Add(this.palRight);
            this.Controls.Add(this.palLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CompleteRecord";
            this.Load += new System.EventHandler(this.CompleteRecord_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.palLeft.ResumeLayout(false);
            this.palLeft.PerformLayout();
            this.palRight.ResumeLayout(false);
            this.palRight.PerformLayout();
            this.palExtendBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBillExtend)).EndInit();
            this.palServiceMedicine.ResumeLayout(false);
            this.menutabServiceMedicin.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.tabKeDon.ResumeLayout(false);
            this.tabKeDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel palLeft;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.TextBox txtservice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labChonDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labDateOfBirth;
        private System.Windows.Forms.TextBox txtdiagnostic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtkDateOfCreate;
        private System.Windows.Forms.Label labDateOfCreate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel palServiceMedicine;
        private System.Windows.Forms.TabControl menutabServiceMedicin;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.ComboBox cbbSeviceName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabKeDon;
        private System.Windows.Forms.TextBox txtAmong;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.ComboBox cbbMedicine;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbCatelogy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel palExtendBill;
        private System.Windows.Forms.DataGridView dgvListBillExtend;
        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostic;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalRecordID;
        private System.Windows.Forms.Label label2;
    }
}