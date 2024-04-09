namespace prjWindowsForm
{
    partial class Form1
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
            this.lbl_KQ = new System.Windows.Forms.Label();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.txt_KQ = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_tru = new System.Windows.Forms.Button();
            this.btn_chia = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_KQ
            // 
            this.lbl_KQ.AutoSize = true;
            this.lbl_KQ.Location = new System.Drawing.Point(50, 330);
            this.lbl_KQ.Name = "lbl_KQ";
            this.lbl_KQ.Size = new System.Drawing.Size(55, 16);
            this.lbl_KQ.TabIndex = 2;
            this.lbl_KQ.Text = "Kết quả:";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(160, 62);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(386, 22);
            this.txt_A.TabIndex = 3;
            // 
            // txt_KQ
            // 
            this.txt_KQ.Location = new System.Drawing.Point(160, 324);
            this.txt_KQ.Name = "txt_KQ";
            this.txt_KQ.Size = new System.Drawing.Size(386, 22);
            this.txt_KQ.TabIndex = 4;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(160, 184);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(386, 22);
            this.txt_B.TabIndex = 5;
            // 
            // btn_cong
            // 
            this.btn_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_cong.Location = new System.Drawing.Point(160, 228);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(107, 40);
            this.btn_cong.TabIndex = 6;
            this.btn_cong.Text = "+";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_tru.Location = new System.Drawing.Point(277, 228);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(107, 40);
            this.btn_tru.TabIndex = 7;
            this.btn_tru.Text = "-";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_chia.Location = new System.Drawing.Point(507, 228);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(107, 40);
            this.btn_chia.TabIndex = 8;
            this.btn_chia.Text = "/";
            this.btn_chia.UseVisualStyleBackColor = true;
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_nhan.Location = new System.Drawing.Point(394, 228);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(107, 40);
            this.btn_nhan.TabIndex = 9;
            this.btn_nhan.Text = "*";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_chia);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.txt_KQ);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.lbl_KQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_KQ;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.TextBox txt_KQ;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.Button btn_chia;
        private System.Windows.Forms.Button btn_nhan;
    }
}

