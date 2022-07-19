using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web1.Controllers
{
    public class GreenwichController : Controller
    {
        public IActionResult Index()
        {
            //Gửi data từ controller (back-end) sang view (front-end) bằng ViewData
            string address = "2 Pham Van Bach - Cau Giay - Ha Noi";
            int year = 2009;
            ViewData["truong"] = "University of Greenwich"; ;
            ViewData["diachi"] = address;
            ViewData["nam"] = year;
            //gửi data bằng ViewBag
            double grade = 4.5;
            ViewBag.Grade = grade;
            List<string> students = new List<string>
            {
                "Minh", "Hoang", "Dung", "Phuong", "Trang"
            };
            students.Add("Tuan");
            students.Add("Hong");
            ViewBag.Students = students;
            return View();
        }
    }
}
