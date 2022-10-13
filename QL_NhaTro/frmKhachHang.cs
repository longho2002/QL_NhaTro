using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class frmKhachHang : Form
    {
        private KhachHang kh = new KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
            datagridview.AutoGenerateColumns = false;
            datagridview.ColumnHeadersHeight = 30;
            datagridview.ReadOnly = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemKH a = new frmThemKH();
            a.ShowDialog();
            fillGrid();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            fillGrid();

        }
        private void datagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview.CurrentRow != null && datagridview.CurrentRow.Cells[0].Value != null)
            {
                Globals.SetGlobalUserID(Convert.ToInt32(datagridview.CurrentRow.Cells[0].Value));
                frmThongTinKH a = new frmThongTinKH();
                a.ShowDialog();
                fillGrid();
            }
        }

        private void fillGrid()
        {
            datagridview.DataSource = null;
            datagridview.Rows.Clear();
            DataTable t = kh.getAll(tb_search.Text);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                datagridview.Rows.Add(1);
                datagridview.Rows[i].Cells[0].Value = t.Rows[i]["id"].ToString();
                datagridview.Rows[i].Cells[1].Value = t.Rows[i]["ho"].ToString();
                datagridview.Rows[i].Cells[2].Value = t.Rows[i]["tendem"].ToString();
                datagridview.Rows[i].Cells[3].Value = t.Rows[i]["ten"].ToString();
                datagridview.Rows[i].Cells[4].Value = t.Rows[i]["CMND"].ToString();
                datagridview.Rows[i].Cells[5].Value = (DateTime)t.Rows[i]["nsinh"];
                datagridview.Rows[i].Cells[6].Value = (bool)t.Rows[i]["gioitinh"] ? "Nam" : "Nữ";
                datagridview.Rows[i].Cells[7].Value = t.Rows[i]["dienthoai"].ToString();
                datagridview.Rows[i].Cells[8].Value = t.Rows[i]["trangthai"].ToString();
                datagridview.Rows[i].Cells[9].Value = t.Rows[i]["phong"].ToString();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
