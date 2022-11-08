using _21810203.DAL;
using _21810203.Entities;
using Newtonsoft.Json;

namespace _21810203.Service
{
    public class ProductHandle
    {
        public static List<Products> LoadProducts (List<Products>? CuaHang)
        {
            string lines = LoadingProducts.LoadingProductsFile("products.json");
            
            if(lines == null)
            {
                return new List<Products>();
            }
            
            CuaHang =  JsonConvert.DeserializeObject<List<Products>>(lines);

            return CuaHang;
        }
    }
}
