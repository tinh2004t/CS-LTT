namespace prjWindowsForm
{
    partial class frmBai4
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_chia = new System.Windows.Forms.RadioButton();
            this.rad_nhan = new System.Windows.Forms.RadioButton();
            this.rad_tru = new System.Windows.Forms.RadioButton();
            this.rad_cong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(238, 63);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(364, 22);
            this.txt_a.TabIndex = 0;
            this.txt_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(238, 203);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(364, 22);
            this.txt_b.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số 2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(238, 351);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(364, 22);
            this.txt_result.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_chia);
            this.groupBox1.Controls.Add(this.rad_nhan);
            this.groupBox1.Controls.Add(this.rad_tru);
            this.groupBox1.Controls.Add(this.rad_cong);
            this.groupBox1.Location = new System.Drawing.Point(97, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính:";
            // 
            // rad_chia
            // 
            this.rad_chia.AutoSize = true;
            this.rad_chia.Location = new System.Drawing.Point(512, 37);
            this.rad_chia.Name = "rad_chia";
            this.rad_chia.Size = new System.Drawing.Size(55, 20);
            this.rad_chia.TabIndex = 13;
            this.rad_chia.TabStop = true;
            this.rad_chia.Text = "Chia";
            this.rad_chia.UseVisualStyleBackColor = true;
            this.rad_chia.CheckedChanged += new System.EventHandler(this.rad_chia_CheckedChanged);
            // 
            // rad_nhan
            // 
            this.rad_nhan.AutoSize = true;
            this.rad_nhan.Location = new System.Drawing.Point(350, 37);
            this.rad_nhan.Name = "rad_nhan";
            this.rad_nhan.Size = new System.Drawing.Size(60, 20);
            this.rad_nhan.TabIndex = 12;
            this.rad_nhan.TabStop = true;
            this.rad_nhan.Text = "Nhân";
            this.rad_nhan.UseVisualStyleBackColor = true;
            this.rad_nhan.CheckedChanged += new System.EventHandler(this.rad_nhan_CheckedChanged);
            // 
            // rad_tru
            // 
            this.rad_tru.AutoSize = true;
            this.rad_tru.Location = new System.Drawing.Point(190, 37);
            this.rad_tru.Name = "rad_tru";
            this.rad_tru.Size = new System.Drawing.Size(48, 20);
            this.rad_tru.TabIndex = 11;
            this.rad_tru.TabStop = true;
            this.rad_tru.Text = "Trừ";
            this.rad_tru.UseVisualStyleBackColor = true;
            this.rad_tru.CheckedChanged += new System.EventHandler(this.rad_tru_CheckedChanged);
            // 
            // rad_cong
            // 
            this.rad_cong.AutoSize = true;
            this.rad_cong.Location = new System.Drawing.Point(35, 37);
            this.rad_cong.Name = "rad_cong";
            this.rad_cong.Size = new System.Drawing.Size(60, 20);
            this.rad_cong.TabIndex = 10;
            this.rad_cong.TabStop = true;
            this.rad_cong.Text = "Cộng";
            this.rad_cong.UseVisualStyleBackColor = true;
            this.rad_cong.CheckedChanged += new System.EventHandler(this.rad_cong_CheckedChanged);
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Name = "frmBai4";
            this.Text = "frmBai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_chia;
        private System.Windows.Forms.RadioButton rad_nhan;
        private System.Windows.Forms.RadioButton rad_tru;
        private System.Windows.Forms.RadioButton rad_cong;
    }
}