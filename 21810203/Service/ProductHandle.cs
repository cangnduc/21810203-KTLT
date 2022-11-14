using _21810203.DAL;
using _21810203.Entities;
using Newtonsoft.Json;

namespace _21810203.Service
{
    public class ProductHandle
    {
        public static List<Products> LoadProducts (List<Products>? CuaHang)
        {
            
            CuaHang =  LoadingProducts.LoadProducts(CuaHang);
            if(CuaHang.Count > 0)
            {

                return CuaHang;
            }
            return new List<Products>();
        }
        public static int GenerateID(string tukhoa, List<Products> CuaHang)
        {
            int id = -1;
            for(int i =0; i < CuaHang.Count; i++)
            {
                if(CuaHang[i].name == tukhoa)
                {
                    for(int j = 0; j <CuaHang[i].dsach.Count; j++ )
                    {
                        if( CuaHang[i].dsach[j].id >= id)
                        {
                            id = CuaHang[i].dsach[j].id;
                        }
                    }
                }
            }
            return id+1;
        }
        public static List<Products> Add_Product(List<Products> CuaHang, product sp, string tukhoa)
        {
            foreach(var pro in CuaHang)
            {
                if (pro.name == tukhoa)
                {
                    pro.dsach.Add(sp);
                }
            }
            return CuaHang;
        }
        public static void SaveCH(List<Products> CuaHang)
        {
            LoadingProducts.SaveCH(CuaHang);
            
        }
    }
}
