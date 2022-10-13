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
    public partial class frmHopDong : Form
    {
        private ThuePhong tp = new ThuePhong();
        private int option = 0;
        public frmHopDong()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView.Columns[6].DefaultCellStyle.Format = "MM/dd/yyyy";
            dataGridView.ReadOnly = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            frmThemHopDong a = new frmThemHopDong();
            a.ShowDialog();
            fillGrid();
        }
       

        void fillGrid()
        {
            dataGridView.DataSource = null;
            switch (option)
            {
                case 0:
                    dataGridView.DataSource = tp.GetAll(tb_search.Text);
                    break;
                case 1:
                    dataGridView.DataSource = tp.GetAll(tb_search.Text, "expired");
                    break;
                case 2:
                    dataGridView.DataSource = tp.GetAll(tb_search.Text, "Còn hạn");
                    break;
                default:
                    dataGridView.DataSource = tp.GetAll(tb_search.Text, "Hết hiệu lực");
                    return;
            }
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            option = 0;
        }
        private void btn_hethan_Click(object sender, EventArgs e)
        {
            option = 1;
        }
        private void btn_dangthue_Click(object sender, EventArgs e)
        {
            option = 2;
        }
        private void btn_datra_Click(object sender, EventArgs e)
        {
            option = 3;
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            fillGrid(); 
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
            {
                Globals.SetGlobalHopDongID(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value));
                frmThongTinHopDong a = new frmThongTinHopDong();
                a.ShowDialog();
                fillGrid();
            }
        }
    }
}
