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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void bntDongY_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtHK1.Text, out double hk1) &&
        double.TryParse(txtHK2.Text, out double hk2) &&
        hk1 >= 0 && hk1 <= 10 && hk2 >= 0 && hk2 <= 10)
            {
                double dtb = (hk1 + hk2 * 2) / 3.0;
                string xepLoai = "";

                if (dtb >= 8.0)
                    xepLoai = "Giỏi";
                else if (dtb >= 6.5)
                    xepLoai = "Khá";
                else if (dtb >= 5.0)
                    xepLoai = "Trung bình";
                else
                    xepLoai = "Yếu";

                txtXepLoai.Text = xepLoai;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHK1.Focus();
            }
        }

        private void bntLamLai_Click(object sender, EventArgs e)
        {
            txtHK1.Clear();
            txtHK2.Clear();
            txtXepLoai.Clear();
            txtHK1.Focus();
        }
    }
}
