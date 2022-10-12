using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_NhaTro
{
    public partial class frmThongTinKH : Form
    {
        private DB _db = new DB();
        private KhachHang kh = new KhachHang();
        private Phong ph = new Phong();
        public frmThongTinKH()
        {
            InitializeComponent();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(opf.FileName);
                pic.Text = opf.FileName.Split('\\').Last();
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = tb_ten.Text;
                string ho = tb_ho.Text;
                string lot = tb_lot.Text;
                string quequan = tb_quequan.Text;
                string cmnd = tb_cmnd.Text;
                DateTime nsinh = bdate.Value;
                bool gioitinh = radioButtonMale.Checked ? true : false;
                string sdt = tb_Phone.Text;
                bool trangthai = cb_trangthai.SelectedText.Equals("Còn ở") ? true : false;
                int phong = int.Parse(cb_phong.SelectedValue.ToString());
                MemoryStream img = new MemoryStream();
                pic.Image.Save(img, pic.Image.RawFormat);

                if (tb_ten.Text.Trim() == "" || tb_ho.Text == "" || tb_lot.Text == "" || tb_quequan.Text == "" ||
                    tb_cmnd.Text == "" || tb_Phone.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (kh.update(int.Parse(lb_id.Text), phong, ho, lot, ten, cmnd, nsinh, gioitinh, sdt, quequan, img, trangthai))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công", "Cập nhật khách hàng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(lb_id.Text);
                if ((MessageBox.Show("Bạn có chắc xoá khách hàng này", "Xoá khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (kh.delete(studentId))
                    {
                        MessageBox.Show("Xoá khách hàng thành công", "Xoá khách hàng", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                    }
                    else
                        MessageBox.Show("Xoá thất bại", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmThongTinKH_Load(object sender, EventArgs e)
        {
            DataTable khTable = kh.get(Globals.idKH.Value);
            if (khTable.Rows.Count < 1)
            {
                MessageBox.Show("Lỗi không tìm thấy hãy thử lại", "Xoá khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            tb_ten.Text = khTable.Rows[0]["ten"].ToString();
            tb_ho.Text = khTable.Rows[0]["ho"].ToString();
            tb_lot.Text = khTable.Rows[0]["tendem"].ToString();
            tb_quequan.Text = khTable.Rows[0]["ten"].ToString();
            tb_cmnd.Text = khTable.Rows[0]["CMND"].ToString();
            bdate.Value = (DateTime)khTable.Rows[0]["nsinh"];
            tb_Phone.Text = khTable.Rows[0]["dienthoai"].ToString();
            if ((bool)khTable.Rows[0]["gioitinh"])
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }

            if ((bool)khTable.Rows[0]["trangthai"])
            {
                cb_trangthai.SelectedIndex = 0;
            }
            else
            {
                cb_trangthai.SelectedIndex = 1;
            }

            DataTable phTable = ph.GetAll("");
            cb_phong.DataSource = phTable;
            cb_phong.DisplayMember = "tenphong";
            cb_phong.ValueMember = "id";
            cb_phong.SelectedValue = khTable.Rows[0]["phong"];

            Byte[] data = new Byte[0];
            data = khTable.Rows[0]["anh"].ToString() == "" ? System.IO.File.ReadAllBytes((Application.StartupPath + "\\Resources\\" + "unknowuser.png")) : (Byte[])(khTable.Rows[0]["anh"]);
            MemoryStream mem = new MemoryStream(data);
            pic.Image = Image.FromStream(mem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cb_phong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void tb_quequan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tb_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tb_lot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_ho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
