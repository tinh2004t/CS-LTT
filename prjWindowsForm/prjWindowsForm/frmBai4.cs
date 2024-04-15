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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rad_cong_CheckedChanged(object sender, EventArgs e)
        {
            if(rad_cong.Checked)
            {
                double a, b;
                if(double.TryParse(txt_a.Text, out a) & double.TryParse(txt_b.Text, out b))
                {
                    txt_result.Text = (a + b).ToString();
                }
            }
        }

        private void rad_tru_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_tru.Checked)
            {
                double a, b;
                if (double.TryParse(txt_a.Text, out a) & double.TryParse(txt_b.Text, out b))
                {
                    txt_result.Text = (a - b).ToString();
                }
            }
        }

        private void rad_nhan_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_nhan.Checked)
            {
                double a, b;
                if (double.TryParse(txt_a.Text, out a) & double.TryParse(txt_b.Text, out b))
                {
                    txt_result.Text = (a * b).ToString();
                }
            }
        }

        private void rad_chia_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_chia.Checked)
            {
                double a, b;
                if (double.TryParse(txt_a.Text, out a) & double.TryParse(txt_b.Text, out b))
                {
                    txt_result.Text = (a / b).ToString();
                }
            }
        }
    }
}
