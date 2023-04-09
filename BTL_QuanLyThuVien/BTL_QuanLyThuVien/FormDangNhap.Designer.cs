namespace BTL_QuanLyThuVien
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.lbTenDN = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.bntDN = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenDN
            // 
            this.lbTenDN.AutoSize = true;
            this.lbTenDN.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTenDN.Location = new System.Drawing.Point(476, 157);
            this.lbTenDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenDN.Name = "lbTenDN";
            this.lbTenDN.Size = new System.Drawing.Size(179, 45);
            this.lbTenDN.TabIndex = 0;
            this.lbTenDN.Text = "Username:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMatKhau.Location = new System.Drawing.Point(477, 245);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(168, 45);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Password:";
            // 
            // bntDN
            // 
            this.bntDN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bntDN.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntDN.Location = new System.Drawing.Point(674, 376);
            this.bntDN.Name = "bntDN";
            this.bntDN.Size = new System.Drawing.Size(183, 75);
            this.bntDN.TabIndex = 1;
            this.bntDN.Text = "Login";
            this.bntDN.UseVisualStyleBackColor = false;
            this.bntDN.Click += new System.EventHandler(this.bntDN_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.Red;
            this.bntThoat.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntThoat.Location = new System.Drawing.Point(885, 377);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(183, 74);
            this.bntThoat.TabIndex = 1;
            this.bntThoat.Text = "Exit";
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(674, 156);
            this.txtDN.Multiline = true;
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(440, 46);
            this.txtDN.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(674, 244);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = 'x';
            this.txtMatKhau.Size = new System.Drawing.Size(440, 46);
            this.txtMatKhau.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bntThoat);
            this.panel1.Controls.Add(this.txtDN);
            this.panel1.Controls.Add(this.bntDN);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.lbTenDN);
            this.panel1.Controls.Add(this.lbMatKhau);
            this.panel1.Location = new System.Drawing.Point(93, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 523);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QuanLyThuVien.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(1311, 139);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "~~LOGIN AS ADMIN~~ ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.bntDN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1311, 771);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập ";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbTenDN;
        private Label lbMatKhau;
        private Button bntDN;
        private Button bntThoat;
        private TextBox txtDN;
        private TextBox txtMatKhau;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbName;
        private System.Windows.Forms.Timer timer1;
    }
}