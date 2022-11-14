using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class Edit_ProductModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? name { get; set; }
        [BindProperty]
        public int pid { get; set; }
        [BindProperty]
        public string? prod_name { get; set; }
        [BindProperty]
        public double prod_price { get; set; }
        [BindProperty]
        public DateTime prod_date { get; set; }
        [BindProperty]
        public string? ProductsName { get;set; }
        public List<Products>? CuaHang;
        public product product;
        public string thongbao = string.Empty;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            if(name != null)
			{
                product = ProductHandle.FindProduct(CuaHang, name, id);
            }
            
        }
        public void OnPost()
		{
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            if(prod_name == null || prod_price <0 || ProductsName == null)
			{
                thongbao = "please fill in all information";
			}
            else
			{
                
                product.id = ProductHandle.GenerateID(ProductsName, CuaHang);
                product.name = prod_name;
                product.price = prod_price;
                product.Expiration = prod_date;
                CuaHang = ProductHandle.Add_Product(CuaHang, product, ProductsName);
                ProductHandle.SaveCH(CuaHang);
                thongbao = "Thanhcong";
            }
           

        }
    }
}
