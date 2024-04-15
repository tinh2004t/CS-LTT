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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void hệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 frmBai1 = new frmBai1();
            frmBai1.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai4 frmBai4 = new frmBai4();
            frmBai4.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai5 frmBai5 = new frmBai5();
            frmBai5.Show(); 
        }
    }
}
