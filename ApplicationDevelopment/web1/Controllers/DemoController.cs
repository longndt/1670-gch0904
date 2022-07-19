using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class DemoController : Controller
    {
        //function này dùng để render ra file Hello.cshtml trong thư mục Views/Demo
        //Note1: Tên thư mục trong View trùng với tên Controller
        //Note2: Tên file view trùng với tên function
        //URL: /Demo/Hello
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}
