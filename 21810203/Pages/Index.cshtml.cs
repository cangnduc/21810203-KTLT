using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _21810203.Service;
using _21810203.Entities;
namespace _21810203.Pages
{
    public class IndexModel : PageModel
    {
        public List<Products> CuaHang = new List<Products>();
        public string thongbao = string.Empty;
        private readonly ILogger<IndexModel> _logger;
        public bool kiemtra = false;
        [BindProperty]
        public string Timkiem { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
        }
        public void OnPost()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            
            if (Timkiem == null)
            {
                thongbao = "Please enter keyword";
                
            }
            else
            {
                
                CuaHang = ProductHandle.TimKiem(CuaHang, Timkiem);
            }
            
        }
    }
}