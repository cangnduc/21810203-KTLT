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
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CuaHang = ProductHandle.LoadProducts(CuaHang);
            Console.WriteLine(1 + CuaHang.Count());
        }
    }
}