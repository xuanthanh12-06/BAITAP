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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtChiSoDau.Text, out int dau) &&
        int.TryParse(txtChiSoCuoi.Text, out int cuoi) &&
        dau >= 0 && cuoi >= dau)
            {
                int kw = cuoi - dau; 
                double tongTien = 0;
                if (kw <= 100)
                {
                    tongTien = kw * 500;
                }
                else if (kw <= 250)
                {
                    tongTien = (100 * 500) + (kw - 100) * 600;
                }
                else if (kw <= 300)
                {
                    tongTien = (100 * 500) + (150 * 600) + (kw - 250) * 800;
                }
                else
                {
                    tongTien = (100 * 500) + (150 * 600) + (50 * 800) + (kw - 300) * 1000;
                }
                txtSoTien.Text = tongTien.ToString("N2");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chỉ số hợp lệ (Chỉ số cuối >= Chỉ số đầu >= 0)!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCuoi.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChiSoDau.Clear();
            txtChiSoCuoi.Clear();
            txtSoTien.Clear();
            txtChiSoDau.Focus();
        }
    }
}
