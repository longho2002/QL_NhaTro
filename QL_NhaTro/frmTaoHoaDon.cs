using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QL_NhaTro
{
    public partial class frmTaoHoaDon : Form
    {
        private HoaDon hd = new HoaDon();
        private ThuePhong tp = new ThuePhong();
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void tb_nuoccu_TextChanged(object sender, EventArgs e)
        {
            if (tb_nuoccu.Text.Trim() == "" || tb_nuocmoi.Text.Trim() == "" || tb_diencu.Text.Trim() == "" ||
                tb_dienmoi.Text.Trim() == "") return;
            lb_nuocsd.Text = (int.Parse(tb_nuocmoi.Text) - int.Parse(tb_nuoccu.Text)).ToString();
            lb_diensd.Text = (int.Parse(tb_dienmoi.Text) - int.Parse(tb_diencu.Text)).ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_dienmoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        void tinhtong()
        {
            if (tb_nuoccu.Text.Trim() == "" || tb_nuocmoi.Text.Trim() == "" || tb_diencu.Text.Trim() == "" ||
                tb_dienmoi.Text.Trim() == "" || tb_gianuoc.Text.Trim() == "" || tb_giadien.Text.Trim() == "" ||
                tb_wifi.Text.Trim() == "" || tb_vesinh.Text.Trim() == "" || tb_phikhac.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Lập hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                lb_tongtien.Text = (int.Parse(lb_giaphong.Text)
                                    + int.Parse(tb_wifi.Text)
                                    + int.Parse(tb_vesinh.Text)
                                    + int.Parse(tb_phikhac.Text)
                                    + int.Parse(lb_diensd.Text) * int.Parse(tb_gianuoc.Text)
                                    + float.Parse(lb_nuocsd.Text) * int.Parse(tb_gianuoc.Text)
                    ).ToString("0.00");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            tinhtong();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                int mathue = Globals.idHopDong.Value;
                DateTime ngaylap = DateTime.Now;
                int wifi = Convert.ToInt32(tb_wifi.Text);
                int vesinh = Convert.ToInt32(tb_vesinh.Text);
                int nuocmoi = Convert.ToInt32(tb_nuocmoi.Text);
                int nuoccu = Convert.ToInt32(tb_nuoccu.Text);
                Double dienmoi = Convert.ToDouble(tb_dienmoi.Text);
                Double diencu = Convert.ToDouble(tb_diencu.Text);
                int giadien = Convert.ToInt32(tb_giadien.Text);
                int gianuoc = Convert.ToInt32(tb_gianuoc.Text);
                int phikhac = Convert.ToInt32(tb_phikhac.Text);
                int tienphong = Convert.ToInt32(lb_giaphong.Text);
                string mota = tb_mota.Text;
                double tongtien = Convert.ToDouble(lb_tongtien.Text);


                if (tb_nuoccu.Text.Trim() == "" || tb_nuocmoi.Text.Trim() == "" || tb_diencu.Text.Trim() == "" ||
                    tb_dienmoi.Text.Trim() == "" || tb_gianuoc.Text.Trim() == "" || tb_giadien.Text.Trim() == "" ||
                    tb_wifi.Text.Trim() == "" || tb_vesinh.Text.Trim() == "" || tb_phikhac.Text.Trim() == "" || lb_tongtien.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tinhtong();
                if (hd.Insert(mathue, ngaylap, wifi, nuoccu, diencu, nuocmoi, dienmoi, giadien, gianuoc, vesinh, phikhac, tienphong, mota, tongtien))
                {
                    MessageBox.Show("Thêm Hoá đơn thành công", "Thêm Hoá đơn", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm Hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = tp.Get(Globals.idHopDong.Value);
            lb_ten.Text = dt.Rows[0]["tenkhachhang"].ToString();
            lb_tenphong.Text = dt.Rows[0]["tenphong"].ToString();
            lb_makh.Text = dt.Rows[0]["idKH"].ToString();
            lb_maphong.Text = dt.Rows[0]["idPhong"].ToString();
            lb_giaphong.Text = dt.Rows[0]["giathue"].ToString();
            DataTable dt1 = hd.GetLatestBillRoom(int.Parse(dt.Rows[0]["idPhong"].ToString()));

            tb_nuoccu.Text = dt1.Rows.Count > 0 ? dt1.Rows[0]["chisonuocmoi"].ToString() : "0";
            tb_diencu.Text = dt1.Rows.Count > 0 ? ((float)dt1.Rows[0]["chisodienmoi"]).ToString("0.00") : "0";
        }
    }
}
