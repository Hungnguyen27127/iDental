namespace WF_iDental
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.palTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picSmallAvatar = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.palLogin = new System.Windows.Forms.Panel();
            this.labLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labusername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labpass = new System.Windows.Forms.Label();
            this.palTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallAvatar)).BeginInit();
            this.palLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // palTop
            // 
            this.palTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.palTop.Controls.Add(this.label2);
            this.palTop.Controls.Add(this.picSmallAvatar);
            this.palTop.Controls.Add(this.btnExit);
            this.palTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTop.Location = new System.Drawing.Point(0, 0);
            this.palTop.Name = "palTop";
            this.palTop.Size = new System.Drawing.Size(1250, 67);
            this.palTop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phòng Khám Chuyên Khoa Răng ";
            // 
            // picSmallAvatar
            // 
            this.picSmallAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picSmallAvatar.Image")));
            this.picSmallAvatar.Location = new System.Drawing.Point(23, 6);
            this.picSmallAvatar.Name = "picSmallAvatar";
            this.picSmallAvatar.Size = new System.Drawing.Size(64, 55);
            this.picSmallAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSmallAvatar.TabIndex = 9;
            this.picSmallAvatar.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1198, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // palLogin
            // 
            this.palLogin.Controls.Add(this.labLogin);
            this.palLogin.Controls.Add(this.pictureBox1);
            this.palLogin.Controls.Add(this.btnLogin);
            this.palLogin.Controls.Add(this.labusername);
            this.palLogin.Controls.Add(this.txtPassword);
            this.palLogin.Controls.Add(this.txtUsername);
            this.palLogin.Controls.Add(this.labpass);
            this.palLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palLogin.Location = new System.Drawing.Point(0, 67);
            this.palLogin.Name = "palLogin";
            this.palLogin.Size = new System.Drawing.Size(1250, 653);
            this.palLogin.TabIndex = 2;
            // 
            // labLogin
            // 
            this.labLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Century", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labLogin.Location = new System.Drawing.Point(496, 96);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(289, 57);
            this.labLogin.TabIndex = 14;
            this.labLogin.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnLogin.Location = new System.Drawing.Point(721, 481);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(347, 42);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labusername
            // 
            this.labusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labusername.AutoSize = true;
            this.labusername.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labusername.Location = new System.Drawing.Point(717, 287);
            this.labusername.Name = "labusername";
            this.labusername.Size = new System.Drawing.Size(143, 23);
            this.labusername.TabIndex = 9;
            this.labusername.Text = "Tên tài khoản :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(721, 427);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(347, 30);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(721, 326);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(347, 30);
            this.txtUsername.TabIndex = 10;
            // 
            // labpass
            // 
            this.labpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labpass.AutoSize = true;
            this.labpass.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.labpass.Location = new System.Drawing.Point(717, 388);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(103, 23);
            this.labpass.TabIndex = 11;
            this.labpass.Text = "Mật khẩu :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.palLogin);
            this.Controls.Add(this.palTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.palTop.ResumeLayout(false);
            this.palTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallAvatar)).EndInit();
            this.palLogin.ResumeLayout(false);
            this.palLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSmallAvatar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel palLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labusername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labpass;
    }
}

