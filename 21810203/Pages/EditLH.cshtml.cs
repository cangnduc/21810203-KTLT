using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class EditLHModel : PageModel
    {

        [BindProperty(SupportsGet =true)]
        public string? LoaiHang { get; set; }
        public string thongbao = string.Empty;
        [BindProperty]
        public string? ten_LH { get; set; }
        public List<Products>? CuaHang;
        public void OnGet()
        {
        }
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            if(ten_LH != null && LoaiHang != null)
            {
                ProductHandle.RenameLoaiHang(CuaHang,LoaiHang,ten_LH);
                Response.Redirect("add_loaihang");
            }
            else
            {
                thongbao = "Please enter new Category name";
            }
        }
    }
}
