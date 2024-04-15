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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            double soluong, dongia, thanhtien;
            if (double.TryParse(txt_SL.Text, out soluong) & double.TryParse(txt_DG.Text, out dongia))
            {
                thanhtien = soluong * dongia;
                txt_TT.Text = thanhtien.ToString();
            }
        }

        private void txt_DG_TextChanged(object sender, EventArgs e)
        {
            double soluong, dongia, thanhtien;
            if (double.TryParse(txt_SL.Text, out soluong) & double.TryParse(txt_DG.Text, out dongia))
            {
                thanhtien = soluong * dongia;
                txt_TT.Text = thanhtien.ToString();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_TT.Clear();
            txt_SL.Clear();
            txt_DG.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn Muốn thoát form không? (Yes/No)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
