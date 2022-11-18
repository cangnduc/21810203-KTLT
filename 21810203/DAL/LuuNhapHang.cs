using _21810203.Entities;
using Newtonsoft.Json;

namespace _21810203.DAL
{
    public class LuuFileNhapHang
    {
        public static List<PhieuNhap> readfile(List<PhieuNhap>? PhieuNhap)
        {
            string filepath = "Nhaphang.json";
            StreamReader sr = new StreamReader(filepath);
            string line = sr.ReadToEnd();
            sr.Close();
            if (line == null)
            {
                return new List<PhieuNhap>();
            }
            PhieuNhap = JsonConvert.DeserializeObject<List<PhieuNhap>>(line);
            return PhieuNhap;

        }
        public static void savefile(List<PhieuNhap> PhieuNhap)
        {
            string fpath = "Nhaphang.json";
            string json = JsonConvert.SerializeObject(PhieuNhap);
            StreamWriter sw = new StreamWriter(fpath);
            sw.WriteLine(json);
            sw.Close();
            
        }
    }
}
