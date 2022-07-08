namespace HeThongTiemChung
{
    partial class MHDatVacxin
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
            this.btn_GioHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.dtgv_DSVX = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ThemVacxin = new System.Windows.Forms.Button();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.tb_MoTa = new System.Windows.Forms.TextBox();
            this.tb_Gia = new System.Windows.Forms.TextBox();
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.tb_Ma = new System.Windows.Forms.TextBox();
            this.btn_ThemGioHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSVX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GioHang
            // 
            this.btn_GioHang.Location = new System.Drawing.Point(974, 12);
            this.btn_GioHang.Name = "btn_GioHang";
            this.btn_GioHang.Size = new System.Drawing.Size(94, 29);
            this.btn_GioHang.TabIndex = 0;
            this.btn_GioHang.Text = "Giỏ hàng";
            this.btn_GioHang.UseVisualStyleBackColor = true;
            this.btn_GioHang.Click += new System.EventHandler(this.btn_GioHang_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(333, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Mua Vacxin Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm: ";
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Location = new System.Drawing.Point(181, 121);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(376, 27);
            this.tb_TimKiem.TabIndex = 3;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(591, 117);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(94, 32);
            this.btn_Tim.TabIndex = 4;
            this.btn_Tim.Text = "tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // dtgv_DSVX
            // 
            this.dtgv_DSVX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DSVX.Location = new System.Drawing.Point(108, 184);
            this.dtgv_DSVX.Name = "dtgv_DSVX";
            this.dtgv_DSVX.RowHeadersWidth = 51;
            this.dtgv_DSVX.RowTemplate.Height = 29;
            this.dtgv_DSVX.Size = new System.Drawing.Size(534, 278);
            this.dtgv_DSVX.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ThemVacxin);
            this.groupBox1.Controls.Add(this.tb_SoLuong);
            this.groupBox1.Controls.Add(this.tb_MoTa);
            this.groupBox1.Controls.Add(this.tb_Gia);
            this.groupBox1.Controls.Add(this.tb_Ten);
            this.groupBox1.Controls.Add(this.tb_Ma);
            this.groupBox1.Controls.Add(this.btn_ThemGioHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(724, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 297);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Vacxin";
            // 
            // btn_ThemVacxin
            // 
            this.btn_ThemVacxin.Location = new System.Drawing.Point(85, 254);
            this.btn_ThemVacxin.Name = "btn_ThemVacxin";
            this.btn_ThemVacxin.Size = new System.Drawing.Size(162, 29);
            this.btn_ThemVacxin.TabIndex = 11;
            this.btn_ThemVacxin.Text = "Thêm Vacxin";
            this.btn_ThemVacxin.UseVisualStyleBackColor = true;
            this.btn_ThemVacxin.Click += new System.EventHandler(this.btn_ThemVacxin_Click);
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(114, 186);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(175, 27);
            this.tb_SoLuong.TabIndex = 10;
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(114, 150);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(175, 27);
            this.tb_MoTa.TabIndex = 9;
            // 
            // tb_Gia
            // 
            this.tb_Gia.Location = new System.Drawing.Point(114, 117);
            this.tb_Gia.Name = "tb_Gia";
            this.tb_Gia.Size = new System.Drawing.Size(175, 27);
            this.tb_Gia.TabIndex = 8;
            // 
            // tb_Ten
            // 
            this.tb_Ten.Location = new System.Drawing.Point(114, 72);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(175, 27);
            this.tb_Ten.TabIndex = 7;
            // 
            // tb_Ma
            // 
            this.tb_Ma.Location = new System.Drawing.Point(114, 32);
            this.tb_Ma.Name = "tb_Ma";
            this.tb_Ma.Size = new System.Drawing.Size(175, 27);
            this.tb_Ma.TabIndex = 6;
            // 
            // btn_ThemGioHang
            // 
            this.btn_ThemGioHang.Location = new System.Drawing.Point(85, 219);
            this.btn_ThemGioHang.Name = "btn_ThemGioHang";
            this.btn_ThemGioHang.Size = new System.Drawing.Size(162, 29);
            this.btn_ThemGioHang.TabIndex = 5;
            this.btn_ThemGioHang.Text = "Thêm vào giỏ hàng";
            this.btn_ThemGioHang.UseVisualStyleBackColor = true;
            this.btn_ThemGioHang.Click += new System.EventHandler(this.btn_ThemGioHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Vacxin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Vacxin";
            // 
            // MHDatVacxin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_DSVX);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GioHang);
            this.Name = "MHDatVacxin";
            this.Text = "MHDatVacxin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DSVX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_GioHang;
        private Label label1;
        private Label label2;
        private TextBox tb_TimKiem;
        private Button btn_Tim;
        private DataGridView dtgv_DSVX;
        private GroupBox groupBox1;
        private Button btn_ThemVacxin;
        private TextBox tb_SoLuong;
        private TextBox tb_MoTa;
        private TextBox tb_Gia;
        private TextBox tb_Ten;
        private TextBox tb_Ma;
        private Button btn_ThemGioHang;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}