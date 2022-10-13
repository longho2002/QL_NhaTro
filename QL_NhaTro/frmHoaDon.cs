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
    public partial class frmHoaDon : Form
    {
        private int option = 0;
        private HoaDon hd = new HoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ReadOnly = true;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            option = 0;
            fillGrid();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            option = 1;
            fillGrid();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            option = 2;
            fillGrid();
        }
        void fillGrid()
        {
            dataGridView.DataSource = null;
            Nullable<DateTime> timeFrom = null;
            Nullable<DateTime> timeTo = null;
            if (rbtn_on.Checked)
            {
                timeFrom = from.Value;
                timeTo = to.Value;
            }
            switch (option)
            {
                case 0:
                    dataGridView.DataSource = hd.GetAll(tb_search.Text, null, timeFrom, timeTo);
                    break;
                case 1:
                    dataGridView.DataSource = hd.GetAll(tb_search.Text, "1", timeFrom, timeTo);
                    break;
                case 2:
                    dataGridView.DataSource = hd.GetAll(tb_search.Text, "Còn hạn", timeFrom, timeTo);
                    break;
            }

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frmLapHoaDon a = new frmLapHoaDon();
            a.ShowDialog();
        }

        private void rbtn_on_CheckedChanged(object sender, EventArgs e)
        {
            pantime.Enabled = true;
        }

        private void rbtn_off_CheckedChanged(object sender, EventArgs e)
        {
            pantime.Enabled = false;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
            {
                Globals.SetGlobalHoaDonID(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
                frmThongTinHoaDon a = new frmThongTinHoaDon();
                a.ShowDialog();
                fillGrid();
            }
        }
    }
}
