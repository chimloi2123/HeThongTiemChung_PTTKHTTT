namespace HeThongTiemChung
{
    partial class TiemChung
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
            this.btn_PhieuTiem = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PhieuTiem
            // 
            this.btn_PhieuTiem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PhieuTiem.Location = new System.Drawing.Point(0, 0);
            this.btn_PhieuTiem.Name = "btn_PhieuTiem";
            this.btn_PhieuTiem.Size = new System.Drawing.Size(262, 314);
            this.btn_PhieuTiem.TabIndex = 0;
            this.btn_PhieuTiem.Text = "Tra cứu thông tin phiếu tiêm";
            this.btn_PhieuTiem.UseVisualStyleBackColor = true;
            this.btn_PhieuTiem.Click += new System.EventHandler(this.btn_PhieuTiem_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_KhachHang.Location = new System.Drawing.Point(261, 0);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(261, 314);
            this.btn_KhachHang.TabIndex = 1;
            this.btn_KhachHang.Text = "Tra cứu thông tin khách hàng";
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(0, 310);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(522, 43);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // TiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 356);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_KhachHang);
            this.Controls.Add(this.btn_PhieuTiem);
            this.Name = "TiemChung";
            this.Text = "TiemChung";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_PhieuTiem;
        private Button btn_KhachHang;
        private Button btn_Thoat;
    }
}