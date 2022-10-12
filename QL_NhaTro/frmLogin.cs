using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMK.Text.Equals("1") && tbTK.Text.Equals("admin"))
                {
                    frmDashBoard dashBoard = new frmDashBoard();
                    this.Hide();
                    dashBoard.ShowDialog();
                    tbMK.Text = "";
                    tbTK.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai thong tin dang nhap!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
