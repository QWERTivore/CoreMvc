using Microsoft.AspNetCore.Mvc;
using GetTheRepsWeb.Presentation.ViewModels;

namespace GetTheRepsWeb.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel vm)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
