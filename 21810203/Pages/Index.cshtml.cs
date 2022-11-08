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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            thongbao = ProductHandle.LoadProducts(CuaHang);
            Console.Write(CuaHang.Count);
        }
    }
}