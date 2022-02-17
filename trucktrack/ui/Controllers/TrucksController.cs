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
            return View("Trucks");
        }
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        public IActionResult Details(int ID)
        {
            return View("Details");
        }
    }
}