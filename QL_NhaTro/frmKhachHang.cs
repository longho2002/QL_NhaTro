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
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemKH a = new frmThemKH();
            a.ShowDialog();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            datagridview.DataSource = null;
            datagridview.Rows.Clear();
            datagridview.DataSource = kh.getAll(tb_search.Text);
            if (datagridview.ColumnCount > 1)
            {
                datagridview.Columns[0].Width = 200;
                datagridview.Columns[1].Width = 200;
            }
        }
        private void datagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Globals.SetGlobalUserID((int)datagridview.CurrentRow.Cells[0].Value);
            frmThongTinKH a = new frmThongTinKH();
            a.ShowDialog();
        }
    }
}
