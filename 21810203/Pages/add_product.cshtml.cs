using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class addproductModel : PageModel
    {
        public int id;
        public List<Products>? CuaHang;
        [BindProperty]
        public string? prod_name { get; set; }
        [BindProperty]
        public string? prod_price { get; set; }
        [BindProperty]
        public DateTime prod_date { get; set; }
        [BindProperty]
        public string? ProductsName { get; set; }
        public string thongbao = string.Empty;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
        }
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
           
            
            product pro = new product();
            if(prod_price == null || prod_name == null)
            {
                thongbao = "Please fill in all missing information";
            }
            else
            {
                if (ProductsName != null)
                {
                    id = ProductHandle.GenerateID(ProductsName, CuaHang);
                    pro.id = id;
                    pro.name = prod_name;
                    pro.price = double.Parse(prod_price);
                    pro.quantity = 1;
                    pro.isDeleted = true;
                    pro.Expiration = prod_date;
                    CuaHang = ProductHandle.Add_Product(CuaHang, pro, ProductsName);
                    ProductHandle.SaveCH(CuaHang);
                    thongbao = "thanh cong";
                    Response.Redirect("index");
                }
               
            }
           
        }
    }

}
