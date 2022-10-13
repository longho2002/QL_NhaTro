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
                bool trangthai = cb_trangthai.SelectedItem != null && cb_trangthai.SelectedItem.ToString().Equals("Còn ở") ? true : false;
                int phong = cb_phong.SelectedValue == null ? -1 : int.Parse(cb_phong.SelectedValue.ToString());
                MemoryStream img = new MemoryStream();
                pic.Image.Save(img, pic.Image.RawFormat);

                if (tb_ten.Text.Trim() == "" || tb_ho.Text == "" || tb_lot.Text == "" || tb_quequan.Text == "" ||
                    tb_cmnd.Text == "" || tb_Phone.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Cập nhật khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (kh.update(Globals.idKH.Value, phong, ho, lot, ten, cmnd, nsinh, gioitinh, sdt, quequan, img, trangthai))
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
                if ((MessageBox.Show("Bạn có chắc xoá khách hàng này", "Xoá khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (kh.delete(Globals.idKH.Value))
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
                cb_trangthai.SelectedValue = 0;
                cb_trangthai.SelectedIndex = 0;
            }
            else
            {
                cb_trangthai.SelectedValue = 1;
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
    }
}
