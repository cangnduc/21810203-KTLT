using _21810203.DAL;
using _21810203.Entities;
using Newtonsoft.Json;

namespace _21810203.Service
{
    public class ProductHandle
    {
        public static string LoadProducts (List<Products>? CuaHang)
        {
            string lines = LoadingProducts.LoadingProductsFile("products.json");
            Console.WriteLine(lines);
            if(lines == null)
            {
                return "File is corupted";
            }
            CuaHang =  JsonConvert.DeserializeObject<List<Products>>(lines);
            if (CuaHang == null)
            {
                
                CuaHang = new List<Products> ();
                return "hvhvhj";

            }
            return "sucessfull Load File";
        }
    }
}
