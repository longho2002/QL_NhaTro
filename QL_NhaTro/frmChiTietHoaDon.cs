using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class frmChiTietHoaDon : Form
    {
        private HoaDon hd = new HoaDon();
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                if (Globals.idHoaDon != null)
                {
                    dt = hd.Get(Globals.idHoaDon.Value);
                    lb_tienphong.Text = dt.Rows[0]["giathue"].ToString();
                    lb_diencu.Text = dt.Rows[0]["chisonuoccu"].ToString();
                    lb_dienmoi.Text = dt.Rows[0]["chisodienmoi"].ToString();
                    lb_nuoccu.Text = dt.Rows[0]["chisonuoccu"].ToString();
                    lb_nuocmoi.Text = dt.Rows[0]["chisonuocmoi"].ToString();
                    lb_ten.Text = dt.Rows[0]["tenkhachhang"].ToString();
                    lb_tenphong.Text = dt.Rows[0]["tenphong"].ToString();
                    lb_makh.Text = dt.Rows[0]["idKH"].ToString();
                    lb_maphong.Text = dt.Rows[0]["idPhong"].ToString();
                    lb_wifi.Text = dt.Rows[0]["tienwifi"].ToString();
                    lb_vesinh.Text = dt.Rows[0]["tienrac"].ToString();
                    lb_giadien.Text = dt.Rows[0]["dongiadien"].ToString();
                    lb_gianuoc.Text = dt.Rows[0]["dongianuoc"].ToString();
                    lb_diensd.Text = (Convert.ToInt32(lb_dienmoi.Text) - Convert.ToInt32(lb_diencu.Text)).ToString();
                    lb_nuocsd.Text = (Convert.ToInt32(lb_nuocmoi.Text) - Convert.ToInt32(lb_nuoccu.Text)).ToString();
                    lb_phikhac.Text = dt.Rows[0]["chiphikhac"].ToString();
                    lb_mota.Text = dt.Rows[0]["mota"].ToString();
                    lb_tongtien.Text = dt.Rows[0]["tongtien"].ToString();
                    lb_tienthanhtoan.Text = dt.Rows[0]["sotiendathanhtoan"].ToString();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
