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
    public partial class frmDSKH : Form
    {
        private KhachHang kh = new KhachHang();
        public frmDSKH()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ReadOnly = true;
        }

        private void frmDSKH_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = kh.getAll("");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = kh.getAll(tb_Search.Text.Trim());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells[0].Value != null)
                Globals.SetGlobalUserID(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString()));
            else
            {
                Globals.SetGlobalUserID(null);
            }
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
