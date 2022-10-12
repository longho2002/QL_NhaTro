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

namespace QL_NhaTro
{
    public partial class frmThemKH : Form
    {
        private DB db = new DB();
        private KhachHang kh = new KhachHang();
        private Phong ph = new Phong();
        public frmThemKH()
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

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            DataTable phTable = ph.GetAll("");
            cb_phong.DataSource = phTable;
            cb_phong.DisplayMember = "tenphong";
            cb_phong.ValueMember = "id";
            if (phTable.Rows.Count < 1)
            {
                MessageBox.Show("Hãy thêm phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int phong = int.Parse(cb_phong.SelectedValue.ToString());
                MemoryStream img = new MemoryStream();
                pic.Image.Save(img, pic.Image.RawFormat);

                if (tb_ten.Text.Trim() == "" || tb_ho.Text == "" || tb_lot.Text == "" || tb_quequan.Text == "" ||
                    tb_cmnd.Text == "" || tb_Phone.Text == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (kh.insert(ho, lot, ten, cmnd, nsinh, gioitinh, sdt, quequan, img, phong))
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thêm khách hàng", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
