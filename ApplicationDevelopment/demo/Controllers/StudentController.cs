using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult FormInput()
        {
            return View();
        }

        public IActionResult FormOutput(Student student)
        {
            return View(student);
        }
    }
}
