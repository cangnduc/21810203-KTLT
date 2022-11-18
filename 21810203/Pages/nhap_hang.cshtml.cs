using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class nhap_hangModel : PageModel
    {
        public List<Products>? CuaHang;
        [BindProperty]
        public string? tenhang { get; set; }
        [BindProperty]
        public int soluong { get; set; }
        public string thongbao = string.Empty;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
        }
       
      
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            if(tenhang != null || soluong >0)
            {
                NhapHangHandler.LuuNhapHang(tenhang, soluong);
                ProductHandle.NhapHang(CuaHang, tenhang, soluong);
                Response.Redirect("DsNhapHang");
            }
            else
            {
                thongbao = "Please fill in all field";
            }
            
        }

    }
}
