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
                    Console.WriteLine("add thanh cong");
                }
            }
            
            return CuaHang;
        }
        public static void SaveCH(List<Products> CuaHang)
        {
            LoadingProducts.SaveCH(CuaHang);
            
        }
        public static List<Products> RemoveItem(List<Products> CuaHang, string CateNam, int id)
        {
            foreach (var items in CuaHang)
            {
                if (items.name == CateNam)
                {
                    items.dsach.RemoveAll(r => r.id == id);
                }
            }
            return CuaHang;
        }
        public static int FindLoaiHangID(List<Products> CuaHang, string name )
        {
            for(int i = 0; i<CuaHang.Count; i ++)
            {
                if (CuaHang[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void DeletedProduct(List<Products> CuaHang,string LoaiHang, int ID)
        {
            
            product temp = new product();
            int a = FindLoaiHangID(CuaHang, LoaiHang);
            for (int i =0; i<CuaHang[a].dsach.Count;i++)
            {
                if(CuaHang[a].dsach[i].id == ID)
                {
                    temp = CuaHang[a].dsach[i];
                    temp.isDeleted = false;
                    CuaHang[a].dsach[i] = temp;
                    break;

                }
            } 
        }
        public static product FindProduct(List<Products> CuaHang, string name, int ID)
		{
            product product = new product();
            foreach(var prod in CuaHang)
			{
                if(prod.name == name)
				{
                    foreach(var sp in prod.dsach)
					{
                        if(sp.id == ID)
						{
                            product = sp;
                            break;
						}
					}
				}
			}
            return product;
		}
        
    }
}
