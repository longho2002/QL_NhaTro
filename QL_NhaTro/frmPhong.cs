using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QL_NhaTro
{
    public partial class frmPhong : Form
    {
        private Phong ph = new Phong();
        private ThuePhong tp = new ThuePhong();
        public frmPhong()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        void fillGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = ph.GetAll("");
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pan_kh.Controls.Clear();
            DataTable dt = ph.GetAllKH(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString()));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Label lb_kh = new Label()
                {
                    Text = dt.Rows[i]["ten"].ToString(),
                    Size = new Size(279, 24),
                    Location = new Point(0 , 15 + i * 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                pan_kh.Controls.Add(lb_kh);
            }
            if (dataGridView.CurrentRow.Cells[0].Value != null)
            {
                if (!dataGridView.CurrentRow.Cells[4].Value.ToString().Equals("Xoá"))
                    panThongTin.Enabled = true;
                tb_gia.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                tb_loaiphong.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                tb_tenphong.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                lb_id.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                if (dataGridView.CurrentRow.Cells[4].Value.ToString() == "Trống")
                {
                    rbtn_active.Checked = true;
                }
                else
                {
                    rbtn_inactive.Checked = true;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tb_gia.Text = "";
            tb_loaiphong.Text = "";
            tb_tenphong.Text = "";
            lb_id.Text = "";
            rbtn_active.Checked = true;
            pan_kh.Controls.Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string gia = tb_gia.Text;
                string loaiphong = tb_loaiphong.Text;
                string tenphong = tb_tenphong.Text;

                if (gia.Trim() == "" || loaiphong.Trim() == "" || tenphong.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ph.Insert(tenphong, loaiphong, Convert.ToInt32(gia)))
                {
                    MessageBox.Show("Thêm Phòng thành công", "Thêm Phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    tb_gia.Text = "";
                    tb_loaiphong.Text = "";
                    tb_tenphong.Text = "";
                    lb_id.Text = "";
                    rbtn_active.Checked = true;
                    pan_kh.Controls.Clear();
                    fillGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                string gia = tb_gia.Text;
                string loaiphong = tb_loaiphong.Text;
                string tenphong = tb_tenphong.Text;
                string trangthai = rbtn_active.Checked ? "Hoạt động" : "Bận";
                if (gia.Trim() == "" || loaiphong.Trim() == "" || tenphong.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Cập nhật Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tp.GetLatestRentRoom(Convert.ToInt32(lb_id.Text)).Rows.Count > 0 && trangthai.Equals("Hoạt động"))
                {
                    MessageBox.Show("Hãy thanh toán phòng trước khi cập nhật trạng thái thành khả dụng!", "Cập nhật Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (ph.Update(Convert.ToInt32(lb_id.Text), tenphong, loaiphong, Convert.ToInt32(gia), trangthai))
                {
                    MessageBox.Show("Cập nhật Phòng thành công", "Cập nhật Phòng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    pan_kh.Controls.Clear();
                    fillGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lb_id.Text.Trim() == "")
            {

                MessageBox.Show("Hãy chọn phòng để thực hiện lệnh xoá", "Xoá Phòng", MessageBoxButtons.OK,
                    MessageBoxIcon
                        .Information);
                return;
            }
            try
            {
                if ((MessageBox.Show("Bạn có chắc xoá Phòng này", "Xoá Phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (ph.Delete(Convert.ToInt32(lb_id.Text)))
                    {
                        MessageBox.Show("Xoá Phòng thành công", "Xoá Phòng", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                    }
                    else
                        MessageBox.Show("Xoá thất bại", "Xoá Phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Xoá Phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
