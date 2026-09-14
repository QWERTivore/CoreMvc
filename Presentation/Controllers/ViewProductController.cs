using Microsoft.AspNetCore.Mvc;
using GetTheRepsWeb.Application.DTO;

namespace GetTheRepsWeb.Presentation.Controllers
{
    public class ViewProductController : Controller
    {
        [HttpGet]
        public IActionResult ViewProducts()
        {
            return View();
        }
    }
}
