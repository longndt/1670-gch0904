using Microsoft.AspNetCore.Mvc;

namespace web10.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
