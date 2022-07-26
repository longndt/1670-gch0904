using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Privacy.cshtml");
        }


        public IActionResult FormOutput(Student student)
        {
            return View(student);
        }
    }
}
