using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class frmThongTinHopDong : Form
    {
        private ThuePhong tp = new ThuePhong();
        private Phong ph = new Phong();
        private HoaDon hd = new HoaDon();
        private DB db = new DB();
        private KhachHang khang = new KhachHang();
        public frmThongTinHopDong()
        {
            InitializeComponent();
        }

        private void frmThongTinHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tp.Get(Globals.idHopDong.Value);
                tb_kh.Text = dt.Rows[0]["idKH"].ToString();
                cb_phong.DataSource = ph.Get(Convert.ToInt32(dt.Rows[0]["idPhong"].ToString()));
                cb_phong.DisplayMember = "ten";
                cb_phong.ValueMember = "id";
                ngthue.Value = (DateTime)dt.Rows[0]["ngaythue"];
                ngtra.Value = (DateTime)dt.Rows[0]["ngaytraphong"];
                tb_coc.Text = dt.Rows[0]["tiendatcoc"].ToString();
                tb_tien.Text = dt.Rows[0]["giathue"].ToString();
                lb_trangthai.Text = dt.Rows[0]["trangthai"].ToString();
                lb_trangthai.ForeColor = lb_trangthai.Text.Equals("Còn hạn") ? Color.MediumSeaGreen : Color.Crimson;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_GiaHan_Click(object sender, EventArgs e)
        {
            try
            {
                if (numMonth.Value < 1)
                {
                    MessageBox.Show("Chọn số tháng gia hạn lớn hơn 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tp.GiaHan(Globals.idHopDong.Value, ngtra.Value.AddMonths(Convert.ToInt32(numMonth.Value))))
                {
                    MessageBox.Show("Gia hạn Hợp đồng thành công", "Gia hạn Hợp đồng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    db.closeConnection();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Gia hạn Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_coc.Text.Trim() == "" || tb_tien.Text.Trim() == "" || tb_kh.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Cập nhật Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((ngtra.Value - ngthue.Value).TotalDays < 180)
                {
                    MessageBox.Show("Ngày trả phải lớn hơn ngày thuê 180 ngày (6 tháng)", "Cập nhật Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int kh = Convert.ToInt32(tb_kh.Text);
                int phong = (int)cb_phong.SelectedValue;
                DateTime thue = ngthue.Value;
                DateTime tra = ngtra.Value;
                int coc = Convert.ToInt32(tb_coc.Text);
                int tien = Convert.ToInt32(tb_tien.Text);
                if (tp.Update(Globals.idHopDong.Value, kh, phong, thue, tra, coc, tien))
                {
                    MessageBox.Show("Cập nhật Hợp đồng thành công", "Cập nhật Hợp đồng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    db.closeConnection();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    db.closeConnection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_dskh_Click(object sender, EventArgs e)
        {
            frmDSKH a = new frmDSKH();
            a.ShowDialog();
            if (Globals.idKH != null)
                tb_kh.Text = Globals.idKH.ToString();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn có chắc xoá Hợp đồng này", "Xoá Hợp đồng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (tp.Delete(Globals.idHopDong.Value))
                    {
                        MessageBox.Show("Xoá Hợp đồng thành công", "Xoá Hợp đồng", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                    }
                    else
                        MessageBox.Show("Xoá thất bại", "Xoá Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Xoá Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_traphong_Click(object sender, EventArgs e)
        {
            db.openConnection();
            SqlTransaction transaction;
            transaction = db.getConnection.BeginTransaction();
            try
            {
                if ((MessageBox.Show("Bạn có chắc kết thúc không", "Trả phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (tp.TraPhong(Globals.idHopDong.Value)
                        && ph.UpdateTrangthai((int)cb_phong.SelectedValue, "Trống")
                        && khang.TraPhong((int)cb_phong.SelectedValue))
                    {
                        MessageBox.Show("Trả phòng thành công", "Trả phòng", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                        transaction.Commit();
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("Trả phòng thất bại", "Trả phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                MessageBox.Show(exception.Message, "Trả phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.closeConnection();
        }

    }
}
