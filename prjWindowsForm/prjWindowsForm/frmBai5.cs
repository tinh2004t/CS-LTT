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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBai5_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 12;  i++)
            {
                cmb_thang.Items.Add(i);
            }

            for (int i = 1900; i <= 3000; i++)
            {
                cmb_nam.Items.Add(i);
            }
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            int thang, nam;
            thang = int.Parse(cmb_thang.Text);
            nam = int.Parse(cmb_nam.Text);
            switch (thang)
            {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                    txt_songay.Text = "Tháng có 31 ngày";
                    break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                    txt_songay.Text = "Tháng có 30 ngày";
                    break;
                    case 2:
                        if (nam % 4 == 0)
                    {
                        txt_songay.Text = "Tháng có 29 ngày";
                    }
                        else
                    {
                        txt_songay.Text = "Tháng có 28 ngày";
                    }
                        break;  
            }
        }
    }
}
