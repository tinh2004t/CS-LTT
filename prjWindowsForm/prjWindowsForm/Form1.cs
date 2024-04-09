using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txt_A.Text);
            b = int.Parse(txt_B.Text);
            c = a + b;
            txt_KQ.Text = c.ToString();
            lbl_KQ.Text = "a + b = ";
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txt_A.Text);
            b = int.Parse(txt_B.Text);
            c = a - b;
            txt_KQ.Text = c.ToString();
            lbl_KQ.Text = "a - b = ";

        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txt_A.Text);
            b = int.Parse(txt_B.Text);
            c = a * b;
            txt_KQ.Text = c.ToString();
            lbl_KQ.Text = "a * b = ";

        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = int.Parse(txt_A.Text);
            b = int.Parse(txt_B.Text);
            c = a / b;
            txt_KQ.Text = c.ToString();
            lbl_KQ.Text = "a / b = ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
