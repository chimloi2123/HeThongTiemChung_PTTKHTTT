namespace HeThongTiemChung
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Location = new System.Drawing.Point(143, 74);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(240, 27);
            this.tb_TaiKhoan.TabIndex = 2;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(143, 143);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '☺';
            this.tb_MatKhau.Size = new System.Drawing.Size(240, 27);
            this.tb_MatKhau.TabIndex = 3;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(416, 272);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(94, 29);
            this.btn_DangKy.TabIndex = 4;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(143, 193);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(94, 29);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 313);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_TaiKhoan;
        private TextBox tb_MatKhau;
        private Button btn_DangKy;
        private Button btn_DangNhap;
    }
}