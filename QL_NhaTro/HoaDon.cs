using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_NhaTro
{
    internal class HoaDon
    {
        private readonly DB _db = new DB();
        public bool Insert(int thuephong, DateTime ngaylaphoadon,
            int tienwifi, int chisonuocmoi, float chisodienmoi, int dongiadien,
            int dongianuoc, int tienrac, int chiphikhac, string mota, int tongtien, int sotiendathanhtoan)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO phong (thuephong, ngaylaphoadon, tienwifi, chisonuocmoi, chisodienmoi, dongiadien, dongianuoc,tienrac,chiphikhac,mota,tongtien,sotiendathanhtoan)VALUES( @thuephong, @ngaylaphoadon, @tienwifi, @chisonuocmoi, @chisodienmoi, @dongiadien,@dongianuoc,@tienrac,@chiphikhac,@mota,@tongtien,@sotiendathanhtoan)",
                    _db.getConnection);
            command.Parameters.Add("@thuephong", SqlDbType.BigInt).Value = thuephong;
            command.Parameters.Add("@ngaylaphoadon", SqlDbType.Date).Value = ngaylaphoadon;
            command.Parameters.Add("@tienwifi", SqlDbType.Int).Value = tienwifi;
            command.Parameters.Add("@chisonuocmoi", SqlDbType.Int).Value = chisonuocmoi;
            command.Parameters.Add("@chisodienmoi", SqlDbType.Float).Value = chisodienmoi;
            command.Parameters.Add("@dongiadien", SqlDbType.Int).Value = dongiadien;
            command.Parameters.Add("@dongianuoc", SqlDbType.Int).Value = dongianuoc;
            command.Parameters.Add("@tienrac", SqlDbType.BigInt).Value = tienrac;
            command.Parameters.Add("@chiphikhac", SqlDbType.BigInt).Value = chiphikhac;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            command.Parameters.Add("@tongtien", SqlDbType.BigInt).Value = tongtien;
            command.Parameters.Add("@sotiendathanhtoan", SqlDbType.BigInt).Value = sotiendathanhtoan;
            try
            {
                _db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    _db.closeConnection();
                    return true;
                }
                else
                {
                    _db.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                _db.closeConnection();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Update(int id, int thuephong, DateTime ngaylaphoadon,
            int tienwifi, int chisonuocmoi, float chisodienmoi, int dongiadien,
            int dongianuoc, int tienrac, int chiphikhac, string mota, int tongtien, int sotiendathanhtoan)
        {
            SqlCommand command =
                new SqlCommand(
                    $"UPDATE phong SET thuephong=@thuephong, ngaylaphoadon=@ngaylaphoadon, tienwifi=@tienwifi, chisonuocmoi=@chisonuocmoi, chisodienmoi=@chisodienmoi, dongiadien=@dongiadien,dongianuoc=@dongianuoc,tienrac=@tienrac,chiphikhac=@chiphikhac,mota=@mota,tongtien=@tongtien,sotiendathanhtoan=@sotiendathanhtoan where id=@id",
                    _db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@thuephong", SqlDbType.BigInt).Value = thuephong;
            command.Parameters.Add("@ngaylaphoadon", SqlDbType.Date).Value = ngaylaphoadon;
            command.Parameters.Add("@tienwifi", SqlDbType.Int).Value = tienwifi;
            command.Parameters.Add("@chisonuocmoi", SqlDbType.Int).Value = chisonuocmoi;
            command.Parameters.Add("@chisodienmoi", SqlDbType.Float).Value = chisodienmoi;
            command.Parameters.Add("@dongiadien", SqlDbType.Int).Value = dongiadien;
            command.Parameters.Add("@dongianuoc", SqlDbType.Int).Value = dongianuoc;
            command.Parameters.Add("@tienrac", SqlDbType.BigInt).Value = tienrac;
            command.Parameters.Add("@chiphikhac", SqlDbType.BigInt).Value = chiphikhac;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            command.Parameters.Add("@tongtien", SqlDbType.BigInt).Value = tongtien;
            command.Parameters.Add("@sotiendathanhtoan", SqlDbType.BigInt).Value = sotiendathanhtoan;
            try
            {
                _db.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    _db.closeConnection();
                    return true;
                }
                else
                {
                    _db.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                _db.closeConnection();
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool StrongDelete(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM hoadon WHERE ID = @ID", _db.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            _db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                _db.closeConnection();
                return true;
            }
            else
            {
                _db.closeConnection();
                return false;
            }
        }
        public DataTable Get(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from hoadon where id = @id", _db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                _db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                _db.closeConnection();
                return table;
            }
            catch (Exception e)
            {
                _db.closeConnection();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable GetAll(string filter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select hoadon.id ,id_thuephong ,ngaylaphoadon ,tienwifi ,chisonuocmoi ,chisodienmoi ,dongiadien ,dongianuoc ,tienrac ,chiphikhac ,mota ,tongtien ,ThuePhong.id idThuephong,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,ThuePhong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong,sotiendathanhtoan from hoadon join ThuePhong on hoadon.id_thuephong = ThuePhong.id join KhachHang on KhachHang.id = ThuePhong.khachhang join phong on phong.id =ThuePhong.phong WHERE Trim(LOWER(CONCAT(tenphong, ten,ho,tenlot )))" + " LIKE N'%" + filter.ToLower() + "%' order by ngaythue desc", _db.getConnection);
                _db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                _db.closeConnection();
                return table;
            }
            catch

                (Exception e)
            {
                _db.closeConnection();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool CheckHoaDon(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from hoadon join ThuePhong where ThuePhong.id = @id and sotiendathanhtoan < tongtien", _db.getConnection);
            _db.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            _db.closeConnection();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
