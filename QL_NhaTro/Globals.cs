using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaTro
{
    internal class Globals
    {
        public static Nullable<int> idKH { get; private set; }
        public static Nullable<int> idHopDong { get; private set; }
        public static Nullable<int> idPhong { get; private set; }
        public static Nullable<int> idHoaDon { get; private set; }
        public static void SetGlobalUserID(Nullable<int> id)
        {
            idKH = id;
        }
        public static void SetGlobalHopDongID(Nullable<int> id)
        {
            idHopDong = id;
        }
        public static void SetGlobalPhongID(Nullable<int> id)
        {
            idPhong = id;
        }

        public static void SetGlobalHoaDonID(Nullable<int> id)
        {
            idHoaDon = id;
        }
    }
}
