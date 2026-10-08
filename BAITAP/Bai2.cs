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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void bntTinh_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtChieuDai.Text, out double dai) &&
        double.TryParse(txtChieuRong.Text, out double rong) &&
        dai > 0 && rong > 0)
            {
                double chuVi = (dai + rong) * 2;
                double dienTich = dai * rong;

                txtChuVi.Text = chuVi.ToString();
                txtDienTich.Text = dienTich.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chiều dài và chiều rộng hợp lệ (> 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntLamLai_Click(object sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();
            txtChieuDai.Focus();
        }
    }
}
