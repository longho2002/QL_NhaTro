using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhaTro
{
    internal class Phong
    {
        private readonly DB db = new DB();
        public bool Insert(string ten, string loaiphong, int giasan)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO phong ( tenphong, loaiphong, giasan)" +
                    " VALUES(@ten,@loaiphong,@giasan)",
                    db.getConnection);
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiphong;
            command.Parameters.Add("@giasan", SqlDbType.BigInt).Value = giasan;
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
        public bool Update(int id, string ten, string loaiphong, int giasan, string trangthai)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE phong SET giasan= @giasan,loaiphong=@loaiphong, tenphong=@ten, trangthai=@trangthai  where id=@id",
                    db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@giasan", SqlDbType.BigInt).Value = giasan;
            command.Parameters.Add("@loaiphong", SqlDbType.NVarChar).Value = loaiphong;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;
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

        public bool Delete(int Id)
        {
            return UpdateTrangthai(Id, "Xoa");
        }
        public DataTable Get(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from phong where id = @id or trangthai = N'Hoạt động'", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                db.openConnection();
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
        public DataTable GetAll(string filter, string cond = null)
        {
            try
            {
                SqlCommand cmd;
                if (cond == null)
                    cmd = new SqlCommand("Select * from phong WHERE Trim(LOWER(CONCAT(loaiphong, tenphong )))" + " LIKE N'%" + filter.ToLower() + "%'", db.getConnection);
                else
                {
                    cmd = new SqlCommand(
                        "Select * from phong WHERE Trim(LOWER(CONCAT(loaiphong, tenphong )))" + " LIKE N'%" +
                        filter.ToLower() + "%' and trangthai = @trangthai", db.getConnection);
                    cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = cond;
                }
                db.openConnection();
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
        public DataTable GetActiveOrInActive(string trangthai)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from phong where trangthai = @trangthai", db.getConnection);
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;
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
        public bool UpdateTrangthai(int Id, string trangthai)
        {
            SqlCommand command = new SqlCommand(@"UPDATE phong SET trangthai = @tranghai where id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@tranghai", SqlDbType.NVarChar).Value = trangthai;
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
        public bool StrongDelete(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM phong WHERE ID = @ID", db.getConnection);
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
        public DataTable GetAllKH(int Id)
        {
            SqlCommand command = new SqlCommand(@"Select * from phong join khachhang on khachhang.phong = phong.id where phong.id = @ID and phong.trangthai = N'Bận' and khachhang.trangthai = 1", db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            try
            {
                db.openConnection();

                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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
    }
}