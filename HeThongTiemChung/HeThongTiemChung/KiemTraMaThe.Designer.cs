namespace HeThongTiemChung
{
    partial class KiemTraMaThe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ktra_gvn = new System.Windows.Forms.GroupBox();
            this.txt_mathe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ktra_gvn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kiểm tra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ktra_gvn
            // 
            this.ktra_gvn.BackColor = System.Drawing.Color.Teal;
            this.ktra_gvn.Controls.Add(this.dataGridView1);
            this.ktra_gvn.Controls.Add(this.txt_mathe);
            this.ktra_gvn.Controls.Add(this.label2);
            this.ktra_gvn.Controls.Add(this.button2);
            this.ktra_gvn.Controls.Add(this.txt_makh);
            this.ktra_gvn.Controls.Add(this.label1);
            this.ktra_gvn.Location = new System.Drawing.Point(12, 97);
            this.ktra_gvn.Name = "ktra_gvn";
            this.ktra_gvn.Size = new System.Drawing.Size(837, 323);
            this.ktra_gvn.TabIndex = 2;
            this.ktra_gvn.TabStop = false;
            this.ktra_gvn.Text = "Kiểm tra";
            // 
            // txt_mathe
            // 
            this.txt_mathe.Location = new System.Drawing.Point(574, 39);
            this.txt_mathe.Name = "txt_mathe";
            this.txt_mathe.Size = new System.Drawing.Size(178, 27);
            this.txt_mathe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập mã thẻ:";
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(184, 36);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(178, 27);
            this.txt_makh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã khách hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(752, 139);
            this.dataGridView1.TabIndex = 4;
            // 
            // KiemTraMaThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.ktra_gvn);
            this.Controls.Add(this.button1);
            this.Name = "KiemTraMaThe";
            this.Text = "Kiểm tra mã thẻ";
            this.ktra_gvn.ResumeLayout(false);
            this.ktra_gvn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox ktra_gvn;
        private TextBox txt_makh;
        private Label label1;
        private TextBox txt_mathe;
        private Label label2;
        private DataGridView dataGridView1;
    }
}