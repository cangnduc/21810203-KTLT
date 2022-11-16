using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Service;
using _21810203.Entities;
namespace _21810203.Pages
{
    public class add_loaihangModel : PageModel
    {
        [BindProperty]
        public string? loaihang { get; set; }
        public List<Products>? CuaHang;
        public string thongbao = string.Empty;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if(loaihang == null)
            {
                thongbao = "Please fill in";
            }
            else
            {
                CuaHang = ProductHandle.LoadProducts(CuaHang);
                ProductHandle.addLoaiHang(CuaHang, loaihang);
                ProductHandle.SaveCH(CuaHang);
                thongbao = "Add Thanh Cong";
            }
            
        }
    }
}
