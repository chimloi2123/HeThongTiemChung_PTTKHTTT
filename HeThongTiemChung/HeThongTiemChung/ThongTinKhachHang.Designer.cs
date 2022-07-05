namespace HeThongTiemChung
{
    partial class ThongTinKhachHang
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
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.tb_Tim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Ve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(6, 26);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.RowTemplate.Height = 29;
            this.dgv_KhachHang.Size = new System.Drawing.Size(863, 547);
            this.dgv_KhachHang.TabIndex = 0;
            // 
            // tb_Tim
            // 
            this.tb_Tim.Location = new System.Drawing.Point(12, 61);
            this.tb_Tim.Name = "tb_Tim";
            this.tb_Tim.Size = new System.Drawing.Size(227, 27);
            this.tb_Tim.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_KhachHang);
            this.groupBox1.Location = new System.Drawing.Point(245, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 579);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hoặc số điện thoại:";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(145, 94);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(94, 29);
            this.btn_Tim.TabIndex = 4;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Ve
            // 
            this.btn_Ve.Location = new System.Drawing.Point(12, 562);
            this.btn_Ve.Name = "btn_Ve";
            this.btn_Ve.Size = new System.Drawing.Size(94, 29);
            this.btn_Ve.TabIndex = 5;
            this.btn_Ve.Text = "Trở về";
            this.btn_Ve.UseVisualStyleBackColor = true;
            this.btn_Ve.Click += new System.EventHandler(this.btn_Ve_Click);
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.btn_Ve);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Tim);
            this.Name = "ThongTinKhachHang";
            this.Text = "ThongTinKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_KhachHang;
        private TextBox tb_Tim;
        private GroupBox groupBox1;
        private Label label1;
        private Button btn_Tim;
        private Button btn_Ve;
    }
}