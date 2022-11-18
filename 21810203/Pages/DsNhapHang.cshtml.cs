using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Service;
using _21810203.Entities;
namespace _21810203.Pages
{
    
    public class DsNhapHangModel : PageModel
    {
        public List<PhieuNhap>? PhieuNhaps;
        public void OnGet()
        {
            PhieuNhaps = NhapHangHandler.LoadPhieuNhap();
        }
    }
}
