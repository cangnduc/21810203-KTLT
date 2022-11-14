using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Service;
using _21810203.Entities;
namespace _21810203.Pages
{
    public class delete_productModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int id { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? name { get; set; }
        public string thongbao = string.Empty;
        public List<Products>? CuaHang;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            Console.WriteLine(CuaHang[1].dsach[3].name);
        }
        public void OnPost()
        {
           
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            //CuaHang = ProductHandle.RemoveItem(CuaHang,name,id);
            if(name != null)
            {
                ProductHandle.DeletedProduct(CuaHang, name, id);
            }
           
            ProductHandle.SaveCH(CuaHang);
            thongbao = "thanh cong";
            Response.Redirect("index");
        }
    }
}
