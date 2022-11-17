using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Entities;
using _21810203.Service;
namespace _21810203.Pages
{
    public class nhap_hangModel : PageModel
    {
        public List<Products>? CuaHang;
        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
        }
    }
}
