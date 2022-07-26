using Microsoft.AspNetCore.Mvc;
using web7.Models;

namespace web7.Controllers
{
    public class UserController : Controller
    {
        //hàm này sẽ render ra form login
        public IActionResult LoginForm()
        {
            return View();
        }

        //hàm này sẽ check dữ liệu login và show kết quả
        public IActionResult LoginCheck(User user)
        {
            string result = null;
            if (user.UserName == "admin" && user.Password == "123456")
            {
                result = "Login succeed !";
            } else
            {
                result = "Login failed !";
            }

            ViewBag.Result = result;
            //return View();
            return View(user);
        }
    }
}
