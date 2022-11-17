using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class DeleteLHModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? LoaiHang { get; set; }
        public string thongbao = string.Empty;
        public List<Products>? CuaHang;
        public void OnGet()
        {
                        
        }
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            if(LoaiHang != null)
            {
                ProductHandle.XoaLoaiHang(CuaHang, LoaiHang);
                Response.Redirect("add_loaihang");
            }
            else
            {
                thongbao = "Co loi xay ra, vui long thu lai";
            }
            
        }
    }
}
