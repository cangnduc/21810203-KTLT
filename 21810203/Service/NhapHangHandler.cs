using _21810203.DAL;
using _21810203.Entities;
namespace _21810203.Service
{
    public class NhapHangHandler
    {
        public static void LuuNhapHang(string tenhang, int soluong)
        {
            PhieuNhap temp = new PhieuNhap();
            List<PhieuNhap> PhieuNhaps = LoadPhieuNhap();
            temp.STT = PhieuNhaps.Count + 1;
            temp.tenhang = tenhang;
            temp.soluong = soluong;
            temp.date = System.DateTime.Now;
            PhieuNhaps.Add(temp);
            LuuFileNhapHang.savefile(PhieuNhaps);
        }
        public static List<PhieuNhap> LoadPhieuNhap()
        {
            List<PhieuNhap> phieuNhaps = new List<PhieuNhap>();
            phieuNhaps = LuuFileNhapHang.readfile(phieuNhaps);
            return phieuNhaps;
        }
    }
}
