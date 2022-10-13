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
    public partial class frmLapHoaDon : Form
    {
        private Phong ph = new Phong();
        private HoaDon hd = new HoaDon();
        private ThuePhong tp = new ThuePhong();
        public frmLapHoaDon()
        {
            InitializeComponent();
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.ReadOnly = true;
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            lb_date.Text = DateTime.Now.ToShortDateString();
            DataGridView1.DataSource = tp.GetAll(tb_search.Text, "Còn hạn");
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            DataGridView1.DataSource = tp.GetAll(tb_search.Text, "Còn hạn");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globals.SetGlobalPhongID(Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value));
            DataTable dt = hd.GetLatestBillRoom(Globals.idPhong.Value);
            if (dt.Rows.Count < 1)
            {
                lb_thongbao.Visible = true;
                btn_taohoadon.Visible = true;
                btn_xemchitiet.Visible = false;
            }
            else
            {
                Globals.SetGlobalHoaDonID(Convert.ToInt32(dt.Rows[0]["id"].ToString()));
                lb_thongbao.Visible = false;
                btn_taohoadon.Visible = false;
                btn_xemchitiet.Visible = true;
            }
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            DataTable dt = hd.GetLatestBillRoom(Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString()));
            Globals.SetGlobalHoaDonID(Convert.ToInt32(dt.Rows[0]["id"].ToString()));
            frmChiTietHoaDon a = new frmChiTietHoaDon();
            a.ShowDialog();
        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            DataTable dt = tp.GetLatestRentRoom(Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value.ToString()));
            Globals.SetGlobalHopDongID(Convert.ToInt32(dt.Rows[0]["id_thuephong"].ToString()));
            frmTaoHoaDon a = new frmTaoHoaDon();
            a.ShowDialog();
        }
    }
}
