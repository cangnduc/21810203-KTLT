using _21810203.Entities;
using Newtonsoft.Json;
namespace _21810203.DAL
{
    
    public class LoadingProducts
    {
        public static string LoadingProductsFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string lines = sr.ReadToEnd();
            sr.Close();
            return lines;
        }
        public static List<Products> LoadProducts(List<Products>? CuaHang)
        {
            string lines = LoadingProductsFile("products.json");

            if (lines == null)
            {
                return new List<Products>();
            }

            CuaHang = JsonConvert.DeserializeObject<List<Products>>(lines);
            if (CuaHang == null)
            {
                return new List<Products>();
            }
            return CuaHang;
        }
        public void savingProduct(string path, string lines)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(lines);
            sw.Close();
        }
        public static void SaveCH(List<Products> CuaHang)
        {
            string fpath = "products.json";
            string json = JsonConvert.SerializeObject(CuaHang);
            StreamWriter sw = new StreamWriter(fpath);
            sw.WriteLine(json);
            sw.Close ();
        }
    }
}
