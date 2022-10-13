using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_NhaTro
{
    public partial class frmThongKe : Form
    {
        private HoaDon hd = new HoaDon();
        private int currentYear = DateTime.Now.Year;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DataTable dtb = hd.thongkeDoanhThu(DateTime.Now);
            chart1.DataSource = dtb;
            chart1.Series[0].Name = "Tháng";
            foreach (DataRow item in dtb.Rows)
            {
                chart1.Series["Tháng"].Points.AddXY(item["Mnth"].ToString(), item["tong"].ToString());
            }
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.Text = "Thống kê doanh thu theo năm";
            chart1.Titles.Add(title);

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Year == currentYear)
            {
                return;
            }
            else
                currentYear = dateTimePicker1.Value.Year;
            chart1.DataSource = null;
            chart1.Series.Clear();
            DataTable dtb = hd.thongkeDoanhThu(dateTimePicker1.Value);
            if (dtb.Rows.Count > 0)
            {
                lb_tb.Visible = false;
                chart1.DataSource = dtb;
                chart1.Series.Add( new Series()
                {
                    Name = "Tháng"
                });
                // chart1.Series[0].;
                foreach (DataRow item in dtb.Rows)
                {
                    chart1.Series["Tháng"].Points.AddXY(item["Mnth"].ToString(), item["tong"].ToString());
                }
            }
            else
            {
                lb_tb.Visible = true;
            }
        }
    }
}
