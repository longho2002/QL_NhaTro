using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QL_NhaTro
{
    public partial class frmThongTinHoaDon : Form
    {
        private HoaDon hd = new HoaDon();
        public frmThongTinHoaDon()
        {
            InitializeComponent();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
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
                double sotiendathanhtoan = Convert.ToDouble(tb_tien.Text);

                if (tb_nuoccu.Text.Trim() == "" || tb_nuocmoi.Text.Trim() == "" || tb_diencu.Text.Trim() == "" ||
                    tb_dienmoi.Text.Trim() == "" || tb_gianuoc.Text.Trim() == "" || tb_giadien.Text.Trim() == "" ||
                    tb_wifi.Text.Trim() == "" || tb_vesinh.Text.Trim() == "" || tb_phikhac.Text.Trim() == "" ||
                    lb_tongtien.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Hoá đơn", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (hd.Update(Globals.idHoaDon.Value, ngaylap, wifi, nuoccu, diencu, nuocmoi, dienmoi, giadien, gianuoc, vesinh, phikhac, tienphong, mota, tongtien, sotiendathanhtoan))
                {
                    MessageBox.Show("Cập nhật hoá đơn thành công", "Cập nhật hoá đơn", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Cập nhật hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn có chắc xoá hoá đơn này", "Xoá hoá đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (hd.StrongDelete(Globals.idHoaDon.Value))
                    {
                        MessageBox.Show("Xoá hoá đơn thành công", "Xoá hoá đơn", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                    }
                    else
                        MessageBox.Show("Xoá thất bại", "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Xoá hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn có muốn thanh toán hoá đơn này không", "Thanh toán hoá đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (hd.ThanhToan(Globals.idHoaDon.Value))
                    {
                        MessageBox.Show("Thanh toán hoá đơn thành công", "Thanh toán hoá đơn", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                    }
                    else
                        MessageBox.Show("Thanh toán thất bại", "Thanh toán hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thanh toán hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmThongTinHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = hd.Get(Globals.idHoaDon.Value);
            lb_ten.Text = dt.Rows[0]["tenkhachhang"].ToString();
            lb_tenphong.Text = dt.Rows[0]["tenphong"].ToString();
            lb_makh.Text = dt.Rows[0]["idKH"].ToString();
            lb_maphong.Text = dt.Rows[0]["idPhong"].ToString();
            lb_giaphong.Text = dt.Rows[0]["giathue"].ToString();
            tb_nuoccu.Text = dt.Rows[0]["chisonuoccu"].ToString();
            tb_diencu.Text = dt.Rows[0]["chisodiencu"].ToString();
            tb_nuoccu.Text = dt.Rows[0]["chisonuocmoi"].ToString();
            tb_dienmoi.Text = dt.Rows[0]["chisodienmoi"].ToString();
            tb_nuocmoi.Text = dt.Rows[0]["chisonuocmoi"].ToString();
            tb_giadien.Text = dt.Rows[0]["dongiadien"].ToString();
            tb_gianuoc.Text = dt.Rows[0]["dongianuoc"].ToString();
            tb_wifi.Text = dt.Rows[0]["tienwifi"].ToString();
            tb_mota.Text = dt.Rows[0]["mota"].ToString();
            tb_phikhac.Text = dt.Rows[0]["chiphikhac"].ToString();
            lb_tongtien.Text = dt.Rows[0]["tongtien"].ToString();
            tb_tien.Text = dt.Rows[0]["sotiendathanhtoan"].ToString();
        }
    }
}
