using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class frmThemHopDong : Form
    {
        private ThuePhong tp = new ThuePhong();
        private Phong ph = new Phong();
        DB db = new DB();
        public frmThemHopDong()
        {
            InitializeComponent();
        }

        private void btn_dskh_Click(object sender, EventArgs e)
        {
            frmDSKH a = new frmDSKH();
            a.ShowDialog();
            if (Globals.idKH != null)
                tb_kh.Text = Globals.idKH.ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;
            try
            {
                if (tb_coc.Text.Trim() == "" || tb_tien.Text.Trim() == "" || tb_kh.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((ngthue.Value - ngtra.Value).TotalDays < 180)
                {
                    MessageBox.Show("Ngày trả phải lớn hơn ngày thuê 180 ngày (6 tháng)", "Thêm Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int kh = Convert.ToInt32(tb_kh.Text);
                int phong = (int)cb_phong.SelectedValue;
                DateTime thue = ngthue.Value;
                DateTime tra = ngtra.Value;
                int coc = Convert.ToInt32(tb_coc.Text);
                int tien = Convert.ToInt32(tb_tien.Text);
                transaction = db.getConnection.BeginTransaction();
                if (tp.Insert(kh, phong, thue, tra, coc, tien) && ph.UpdateTrangthai(phong, "Bận"))
                {
                    MessageBox.Show("Thêm Hợp đồng thành công", "Thêm Hợp đồng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    transaction.Commit();
                    db.closeConnection();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm Hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                    db.closeConnection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThemHopDong_Load(object sender, EventArgs e)
        {
            cb_phong.DataSource = ph.GetActiveOrInActive("Hoạt động");
            cb_phong.DisplayMember = "tên";
            cb_phong.ValueMember = "id";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ngthue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_coc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tb_tien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ngtra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_kh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
