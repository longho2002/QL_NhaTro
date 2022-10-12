using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace QL_NhaTro
{
    internal class KhachHang
    {
        private DB db = new DB();

        public bool insert(string ho, string tendem, string ten, string cmnd, DateTime nsinh, bool gioitinh,
            string dienthoai, string quequan,
            MemoryStream picture, int phong)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO khachhang ( ho, tendem, ten, cmnd, nsinh, gioitinh, dienthoai, quequan, phong)" +
                    "VALUES( @ho, @tendem, @ten,@cmnd, @nsinh, @gioitinh, @dienthoai, @quequan, @picture, @phong)",
                    db.getConnection);
            command.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
            command.Parameters.Add("@tendem", SqlDbType.NVarChar).Value = tendem;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@nsinh", SqlDbType.Date).Value = nsinh;
            command.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = dienthoai;
            command.Parameters.Add("@quequan", SqlDbType.NVarChar).Value = quequan;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@giophongitinh", SqlDbType.Int).Value = phong;
            try
            {
                db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            db.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            db.closeConnection();
            return count;
        }

        internal object totalFemale()
        {
            return execCount("SELECT COUNT(*) FROM khachhang WHERE GENDER = 'Female'");
        }

        internal object totalMale()
        {
            return execCount("SELECT COUNT(*) FROM khachhang WHERE GENDER = 'Male'");
        }

        internal object tongKH()
        {
            return execCount("SELECT COUNT(*) FROM khachhang");
        }

        public bool update(int Id, int phong, string ho, string tendem, string ten, string cmnd, DateTime nsinh,
            bool gioitinh, string dienthoai, string quequan,
            MemoryStream picture, bool trangthai)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE khachhang SET ho= @ho,phong=@phong, tendem=@tendem,ten= @ten,cmnd=@cmnd,nsinh= @nsinh, gioitinh=@gioitinh, dienthoai=@dienthoai, quequan=@quequan, picture=@picture,trangthai=@trangthai where id=@id",
                    db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@phong", SqlDbType.Int).Value = phong;
            command.Parameters.Add("@ho", SqlDbType.NVarChar).Value = ho;
            command.Parameters.Add("@tendem", SqlDbType.NVarChar).Value = tendem;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = cmnd;
            command.Parameters.Add("@nsinh", SqlDbType.Date).Value = nsinh;
            command.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gioitinh;
            command.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = dienthoai;
            command.Parameters.Add("@quequan", SqlDbType.NVarChar).Value = quequan;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@trangthai", SqlDbType.Bit).Value = trangthai;
            try
            {
                db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool delete(int Id)
        {
            SqlCommand command = new SqlCommand(@"UPDATE khachhang SET status = 0 where  id=@id", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            db.openConnection();
            try
            {
                db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public DataTable get(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from khachhang where id = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();
                return table;
            }
            catch (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable getAll(string filter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from khachhang WHERE Trim(LOWER(CONCAT(ho, ten, tendem, cmnd, dienthoai, quequan)))" + " LIKE N'%" + filter.ToLower() + "%'", db.getConnection);
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();
                return table;
            }
            catch

                (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return null;


            }
        }
        public DataTable getActiveOrInActive(bool trangthai)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from khachhang where trangthai = @trangthai", db.getConnection);
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = trangthai ? "1" : "0";
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();
                return table;
            }
            catch

                (Exception e)
            {
                db.closeConnection();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public bool strongDelete(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM khachhang WHERE ID = @ID", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
