using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace QL_NhaTro
{
    internal class HoaDon
    {
        private readonly DB _db = new DB();
        public bool Insert(int id_thuephong, DateTime ngaylaphoadon,
            int tienwifi, int chisonuoccu, double chisodiencu, int chisonuocmoi, double chisodienmoi, int dongiadien,
            int dongianuoc, int tienrac, int chiphikhac, int tienphong, string mota, double tongtien)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO hoadon (id_thuephong, ngaylaphoadon, tienwifi,chisonuoccu, chisodiencu, chisonuocmoi,chisodienmoi, dongiadien, dongianuoc,tienrac,tienphong, chiphikhac,mota,tongtien)VALUES( @id_thuephong, @ngaylaphoadon, @tienwifi, @chisonuoccu,  @chisodiencu, @chisonuocmoi, @chisodienmoi, @dongiadien,@dongianuoc,@tienrac,@tienphong,@chiphikhac,@mota,@tongtien)",
                    _db.getConnection);
            command.Parameters.Add("@id_thuephong", SqlDbType.Int).Value = id_thuephong;
            command.Parameters.Add("@ngaylaphoadon", SqlDbType.Date).Value = ngaylaphoadon;
            command.Parameters.Add("@tienwifi", SqlDbType.Int).Value = tienwifi;
            command.Parameters.Add("@chisonuocmoi", SqlDbType.Int).Value = chisonuocmoi;
            command.Parameters.Add("@chisodienmoi", SqlDbType.Float).Value = chisodienmoi;
            command.Parameters.Add("@chisonuoccu", SqlDbType.Int).Value = chisonuoccu;
            command.Parameters.Add("@chisodiencu", SqlDbType.Float).Value = chisodiencu;
            command.Parameters.Add("@dongiadien", SqlDbType.Int).Value = dongiadien;
            command.Parameters.Add("@dongianuoc", SqlDbType.Int).Value = dongianuoc;
            command.Parameters.Add("@tienrac", SqlDbType.Int).Value = tienrac;
            command.Parameters.Add("@chiphikhac", SqlDbType.Int).Value = chiphikhac;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            command.Parameters.Add("@tongtien", SqlDbType.Float).Value = tongtien;
            command.Parameters.Add("@tienphong", SqlDbType.Int).Value = tienphong;
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
        public bool Update(int id, DateTime ngaylaphoadon,
            int tienwifi, int chisonuoccu, double chisodiencu, int chisonuocmoi, double chisodienmoi, int dongiadien,
            int dongianuoc, int tienrac, int chiphikhac, int tienphong, string mota, double tongtien, double sotiendathanhtoan)
        {
            SqlCommand command =
                new SqlCommand(
                    $"UPDATE hoadon SET ngaylaphoadon=@ngaylaphoadon,chisonuoccu =@chisonuoccu, chisodiencu=@chisodiencu,tienphong=@tienphong, tienwifi=@tienwifi, chisonuocmoi=@chisonuocmoi, chisodienmoi=@chisodienmoi, dongiadien=@dongiadien,dongianuoc=@dongianuoc,tienrac=@tienrac,chiphikhac=@chiphikhac,mota=@mota,tongtien=@tongtien,sotiendathanhtoan=@sotienthanhtoan where id=@id",
                    _db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@ngaylaphoadon", SqlDbType.Date).Value = ngaylaphoadon;
            command.Parameters.Add("@tienwifi", SqlDbType.Int).Value = tienwifi;
            command.Parameters.Add("@chisonuocmoi", SqlDbType.Int).Value = chisonuocmoi;
            command.Parameters.Add("@chisodienmoi", SqlDbType.Float).Value = chisodienmoi;
            command.Parameters.Add("@chisonuoccu", SqlDbType.Int).Value = chisonuoccu;
            command.Parameters.Add("@chisodiencu", SqlDbType.Float).Value = chisodiencu;
            command.Parameters.Add("@dongiadien", SqlDbType.Int).Value = dongiadien;
            command.Parameters.Add("@dongianuoc", SqlDbType.Int).Value = dongianuoc;
            command.Parameters.Add("@tienrac", SqlDbType.Int).Value = tienrac;
            command.Parameters.Add("@chiphikhac", SqlDbType.Int).Value = chiphikhac;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = mota;
            command.Parameters.Add("@tongtien", SqlDbType.Float).Value = tongtien;
            command.Parameters.Add("@sotienthanhtoan", SqlDbType.Float).Value = sotiendathanhtoan;
            command.Parameters.Add("@tienphong", SqlDbType.Int).Value = tienphong;
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
        public bool ThanhToan(int Id)
        {
            SqlCommand command = new SqlCommand(@"UPDATE hoadon SET sotiendathanhtoan = tongtien WHERE ID = @ID", _db.getConnection);
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
                SqlCommand cmd = new SqlCommand("select hoadon.id ,id_thuephong ,ngaylaphoadon ,tienwifi ,chisonuocmoi ,chisodienmoi ,chisonuoccu,chisodiencu,dongiadien ,dongianuoc ,tienrac ,chiphikhac ,mota ,tongtien,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,thuephong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong,sotiendathanhtoan from hoadon join thuephong on hoadon.id_thuephong = thuephong.id join KhachHang on KhachHang.id = thuephong.khachhang join phong on phong.id =thuephong.phong WHERE hoadon.id = @id", _db.getConnection);
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
        public DataTable GetAll(string filter, string cond = null, Nullable<DateTime> timeFrom = null, Nullable<DateTime> timeTo = null)
        {
            try
            {
                if (timeFrom == null || timeTo == null)
                {
                    timeFrom = new DateTime(2000, 1, 1);
                    timeTo = new DateTime(2090, 1, 1);
                }
                SqlCommand cmd;
                if (cond == null)
                    cmd = new SqlCommand("select hoadon.id id,id_thuephong ,ngaylaphoadon ,tienwifi ,chisonuocmoi ,chisodienmoi ,chisonuoccu,chisodiencu,dongiadien ,dongianuoc ,tienrac ,chiphikhac ,mota ,tongtien ,thuephong.id id_thuephong,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,thuephong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong,sotiendathanhtoan from hoadon join thuephong on hoadon.id_thuephong = thuephong.id join KhachHang on KhachHang.id = thuephong.khachhang join phong on phong.id =thuephong.phong WHERE Trim(LOWER(CONCAT(tenphong, ten,ho,tendem,cmnd )))" + " LIKE N'%" + filter.ToLower() + "%' and ngaylaphoadon BETWEEN @timefrom AND @timeto order by ngaylaphoadon desc", _db.getConnection);
                else
                {
                    if (cond == "1")
                        cmd = new SqlCommand(
                            "select hoadon.id id,id_thuephong ,ngaylaphoadon ,tienwifi ,chisonuocmoi ,chisodienmoi ,chisonuoccu,chisodiencu,dongiadien ,dongianuoc ,tienrac ,chiphikhac ,mota ,tongtien ,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,thuephong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong,sotiendathanhtoan from hoadon join thuephong on hoadon.id_thuephong =thuephong.id join KhachHang on KhachHang.id = thuephong.khachhang join phong on phong.id =thuephong.phong WHERE Trim(LOWER(CONCAT(tenphong, ten,ho,tendem,cmnd )))" +
                            " LIKE N'%" + filter.ToLower() + "%' and sotiendathanhtoan >= tongtien and ngaylaphoadon BETWEEN @timefrom AND @timeto order by ngaylaphoadon desc", _db.getConnection);
                    else
                    {
                        cmd = new SqlCommand(
                            "select hoadon.id id ,id_thuephong ,ngaylaphoadon ,tienwifi ,chisonuocmoi ,chisodienmoi ,chisonuoccu,chisodiencu,dongiadien ,dongianuoc ,tienrac ,chiphikhac ,mota ,tongtien ,ngaythue ,ngaytraphong ,tiendatcoc ,giathue ,thuephong.trangthai,ten as [tenkhachhang], tenphong,khachhang.id idKH, phong.id idPhong,sotiendathanhtoan from hoadon join thuephong on hoadon.id_thuephong =thuephong.id join KhachHang on KhachHang.id =thuephong.khachhang join phong on phong.id =thuephong.phong WHERE Trim(LOWER(CONCAT(tenphong, ten,ho,tendem,cmnd )))" +
                            " LIKE N'%" + filter.ToLower() + "%' and sotiendathanhtoan < tongtien and ngaylaphoadon BETWEEN @timefrom AND @timeto order by ngaylaphoadon desc", _db.getConnection);
                    }
                }
                cmd.Parameters.Add("@timefrom", SqlDbType.Date).Value = timeFrom;
                cmd.Parameters.Add("@timeto", SqlDbType.Date).Value = timeTo;
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
            SqlCommand cmd = new SqlCommand("select * from hoadon join thuephong where thuephong.id = @id and sotiendathanhtoan < tongtien", _db.getConnection);
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

        public DataTable GetLatestBillRoom(int id)
        {
            try
            {
                DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                SqlCommand command = new SqlCommand(
                    "select hoadon.id, id_thuephong, ngaylaphoadon, tienwifi, chisonuocmoi, chisodienmoi,chisonuoccu,chisodiencu, dongiadien, dongianuoc, tienrac, chiphikhac, mota, tongtien, thuephong.id idid_thuephong, ngaythue, ngaytraphong, tiendatcoc, giathue, thuephong.trangthai, ten as [tenkhachhang], tenphong, khachhang.id idKH, phong.id idPhong, sotiendathanhtoan from hoadon join thuephong on hoadon.id_thuephong = thuephong.id join KhachHang on KhachHang.id = thuephong.khachhang join phong on phong.id = thuephong.phong WHERE phong.id = @id and ngaylaphoadon > @ngay", _db.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@ngay", SqlDbType.Date).Value = firstDayOfMonth;
                _db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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
        public DataTable thongkeDoanhThu(DateTime date)
        {
            try
            {
                DateTime dateto = new DateTime(date.Year + 1, 1, 1);
                DateTime datefrom = new DateTime(date.Year,1,1);
                SqlCommand command = new SqlCommand(
                    "SELECT MONTH(ngaylaphoadon) AS Mnth, YEAR(ngaylaphoadon) AS Yr, sum(sotiendathanhtoan) as tong FROM hoadon WHERE ngaylaphoadon >= @datefrom AND ngaylaphoadon <  @dateto GROUP BY MONTH(ngaylaphoadon), YEAR(ngaylaphoadon)", _db.getConnection);
                command.Parameters.Add("@dateto", SqlDbType.Date).Value = dateto;
                command.Parameters.Add("@datefrom", SqlDbType.Date).Value = datefrom;
                _db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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
    }
}
