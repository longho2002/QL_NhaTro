using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace QL_NhaTro
{
    internal class ThuePhong
    {
        private readonly DB db = new DB();
        public bool Insert(int kh, int phong, DateTime ngthue, DateTime ngtra, int tiendatacoc, int giathue)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO ThuePhong ( khachhang, phong, ngaythue, ngaytraphong, tiendatcoc , giathue)" +
                    "VALUES( @kh, @phong, @ngthue, @ngtra, @tiendatacoc, @giathue)",
                    db.getConnection);
            command.Parameters.Add("@kh", SqlDbType.Int).Value = kh;
            command.Parameters.Add("@phong", SqlDbType.Int).Value = phong;
            command.Parameters.Add("@ngthue", SqlDbType.Date).Value = ngthue;
            command.Parameters.Add("@ngtra", SqlDbType.Date).Value = ngtra;
            command.Parameters.Add("@tiendatacoc", SqlDbType.BigInt).Value = tiendatacoc;
            command.Parameters.Add("@giathue", SqlDbType.BigInt).Value = giathue;

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
        public bool Update(int id, int kh, int phong, DateTime ngthue, DateTime ngtra, int tiendatacoc, int giathue)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE ThuePhong SET khachhang=@kh, phong=@phong, ngaythue=@ngthue, ngaytraphong=@ngtra, tiendatcoc=@tiendatacoc, giathue=@giathue where id=@id",
                    db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@kh", SqlDbType.Int).Value = kh;
            command.Parameters.Add("@phong", SqlDbType.Int).Value = phong;
            command.Parameters.Add("@ngthue", SqlDbType.Date).Value = ngthue;
            command.Parameters.Add("@ngtra", SqlDbType.Date).Value = ngtra;
            command.Parameters.Add("@tiendatacoc", SqlDbType.BigInt).Value = tiendatacoc;
            command.Parameters.Add("@giathue", SqlDbType.BigInt).Value = giathue;
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
            SqlCommand command = new SqlCommand(@"UPDATE ThuePhong SET trangthai = N'Xoá' where id=@id", db.getConnection);
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
        public DataTable Get(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select ThuePhong.id,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong  from ThuePhong join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id = ThuePhong.phong where ThuePhong.id = @id", db.getConnection);
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
                    cmd = new SqlCommand("Select ThuePhong.id,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,loaiphong,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong  from ThuePhong join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id = ThuePhong.phong WHERE Trim(LOWER(CONCAT(tenphong,ten)))" + " LIKE N'%" + filter.ToLower() + "%' order by ngaythue desc", db.getConnection);
                else if (cond.Equals("expired"))
                {
                    cmd = new SqlCommand("Select ThuePhong.id,ngaythue ,ngaytraphong ,tiendatcoc ,giathue,loaiphong ,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong  from ThuePhong join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id = ThuePhong.phong WHERE Trim(LOWER(CONCAT(tenphong,ten)))" + " LIKE N'%" + filter.ToLower() + "%' and ngaytraphong < GETDATE() order by ngaythue desc", db.getConnection);
                }
                else
                {
                    cmd = new SqlCommand("Select ThuePhong.id,ngaythue ,ngaytraphong ,tiendatcoc,loaiphong ,giathue ,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong  from ThuePhong join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id = ThuePhong.phong WHERE Trim(LOWER(CONCAT(tenphong,ten)))" + " LIKE N'%" + filter.ToLower() + "%' and thuephong.trangthai = @trangthai order by ngaythue desc", db.getConnection);
                    cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = cond;
                }
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
        public DataTable GetActiveOrInActive(string trangthai)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select ThuePhong.id,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong  from ThuePhong join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id = ThuePhong.phong where ThuePhong.trangthai = @trangthai order by ngaythue desc", db.getConnection);
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai ;
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
        public bool StrongDelete(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM thuephong WHERE ID = @ID", db.getConnection);
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
        public bool GiaHan(int Id, DateTime ngay)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE ThuePhong SET ngaytraphong=@ngtra where id=@id",
                    db.getConnection);
            command.Parameters.Add("@ngtra", SqlDbType.Date).Value = ngay;
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
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
        public bool TraPhong(int Id)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE ThuePhong SET trangthai=@trangthai where id=@id",
                    db.getConnection);
            command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = "Hết hiệu lực";
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
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
        public DataTable GetLatestRentRoom(int phong)
        {
            SqlCommand command =
                new SqlCommand(
                    "Select top(1) thuephong.id id_thuephong, ngaythue from ThuePhong join phong on phong.id = ThuePhong.phong where  phong.id = @phong and ThuePhong.trangthai = N'Còn hạn' order by ngaythue desc",
                    db.getConnection);
            command.Parameters.Add("@phong", SqlDbType.Int).Value = phong;
            try
            {
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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

      

    }
}
