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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBanKinh.Text, out double r) && r > 0)
            {
                double chuVi = 2 * Math.PI * r;
                double dienTich = Math.PI * r * r;
                txtChuVi.Text = Math.Round(chuVi, 2).ToString();
                txtDienTich.Text = Math.Round(dienTich, 2).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập bán kính hợp lệ lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanKinh.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtBanKinh.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
      

        
