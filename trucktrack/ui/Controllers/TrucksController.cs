using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ui.Controllers
{
    public class TrucksController : Controller
    {
        // 
        // GET: /Detail/

        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        public string Details(int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Truck Number {ID}");
        }
    }
}