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
    public partial class frmTongQuan : Form
    {
        private HoaDon hd = new HoaDon();
        private ThuePhong tp = new ThuePhong();

        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            DataGridView1.AutoGenerateColumns = false;
            DataGridView2.AutoGenerateColumns = false;

            DataTable dt = tp.GetActiveOrInActive("Còn hạn");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridView2.Rows.Add(1);
                DataGridView2.Rows[i].Cells[0].Value = dt.Rows[i]["id"].ToString();
                DataGridView2.Rows[i].Cells[1].Value = dt.Rows[i]["tenkhachhang"].ToString();
                DataGridView2.Rows[i].Cells[2].Value = dt.Rows[i]["tenphong"].ToString();
                double num = ((DateTime)dt.Rows[i]["ngaytraphong"] - (DateTime)dt.Rows[i]["ngaythue"]).TotalDays;
                DataGridView2.Rows[i].Cells[3].Value = num.ToString();
                DataGridView2.Rows[i].Cells[3].Style.ForeColor = num > 0 ? Color.Green : Color.Red;
                DataGridView2.Rows[i].Cells[4].Value = num > 0 ? "Còn hạn" : "Hết hạn";
            }

            DataGridView1.DataSource = hd.GetAll("", "0");
            DataGridView1.ColumnHeadersHeight = 30;
        }
    }
}
