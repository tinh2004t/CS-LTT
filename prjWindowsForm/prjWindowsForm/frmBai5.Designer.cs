namespace prjWindowsForm
{
    partial class frmBai5
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_songay = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cmb_thang = new System.Windows.Forms.ComboBox();
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn năm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số ngày trong tháng:";
            // 
            // txt_songay
            // 
            this.txt_songay.Location = new System.Drawing.Point(281, 256);
            this.txt_songay.Name = "txt_songay";
            this.txt_songay.Size = new System.Drawing.Size(379, 22);
            this.txt_songay.TabIndex = 5;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(188, 327);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(114, 52);
            this.btn_tinh.TabIndex = 6;
            this.btn_tinh.Text = "Tính số ngày";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(434, 327);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 52);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // cmb_thang
            // 
            this.cmb_thang.FormattingEnabled = true;
            this.cmb_thang.Location = new System.Drawing.Point(281, 81);
            this.cmb_thang.Name = "cmb_thang";
            this.cmb_thang.Size = new System.Drawing.Size(379, 24);
            this.cmb_thang.TabIndex = 8;
            this.cmb_thang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(281, 172);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(379, 24);
            this.cmb_nam.TabIndex = 9;
            // 
            // frmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_nam);
            this.Controls.Add(this.cmb_thang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txt_songay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai5";
            this.Text = "Chọn năm:";
            this.Load += new System.EventHandler(this.frmBai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_songay;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cmb_thang;
        private System.Windows.Forms.ComboBox cmb_nam;
    }
}