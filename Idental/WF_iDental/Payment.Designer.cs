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
            this.btnBillCancle = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.palBillBottom = new System.Windows.Forms.Panel();
            this.palBillTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.palTop.SuspendLayout();
            this.palContain.SuspendLayout();
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
            this.palContain.Controls.Add(this.btnBillCancle);
            this.palContain.Controls.Add(this.btnDone);
            this.palContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palContain.Location = new System.Drawing.Point(4, 57);
            this.palContain.Name = "palContain";
            this.palContain.Size = new System.Drawing.Size(886, 427);
            this.palContain.TabIndex = 2;
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
            this.labBill.Location = new System.Drawing.Point(103, 17);
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
            this.palTop.ResumeLayout(false);
            this.palContain.ResumeLayout(false);
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
    }
}