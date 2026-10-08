using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 frm = new Bai1();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 frm = new Bai2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3 frm = new Bai3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4 frm = new Bai4();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
