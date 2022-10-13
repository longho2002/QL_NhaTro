using Guna.UI2.WinForms;
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
    public partial class frmDashBoard : Form
    {
        private Form activeForm;
        public frmDashBoard()
        {
            InitializeComponent();
            OpenChildForm(new frmTongQuan(), btn_tongquan);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            if (activeForm != null)
                activeForm.Close();
            toggleButton_Click(btnSender as Guna2Button);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPan.Controls.Add(childForm);
            this.mainPan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void toggleButton_Click(Guna2Button a)
        {
            Guna2Button tmp;
            foreach (object VARIABLE in Pan_Menu.Controls)
            {
                if (VARIABLE.GetType() == typeof(Guna2Button))
                {
                    tmp = VARIABLE as Guna2Button;
                    if (tmp.Text.Equals(a.Text))
                    {
                        tmp.BackColor = Color.FromArgb(94, 148, 255);
                        tmp.ForeColor = Color.White;
                    }
                    else
                    {
                        tmp.BackColor = Color.Transparent;
                        tmp.ForeColor = Color.Gray;
                    }
                }

            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tongquan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTongQuan(), btn_tongquan);
            lb_hienthi.Text = "Tổng quan";
        }

        private void btn_ngthue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), btn_ngthue);
            lb_hienthi.Text = "Người thuê";
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhong(), btn_phong);
            lb_hienthi.Text = "Phòng";
        }

        private void btn_hopdong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHopDong(), btn_hopdong);
            lb_hienthi.Text = "Hợp đồng";
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon(), btn_hoadon);
            lb_hienthi.Text = "Hoá đơn";
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe(), btn_thongke);
            lb_hienthi.Text = "Thống kê";
        }
    }
}
