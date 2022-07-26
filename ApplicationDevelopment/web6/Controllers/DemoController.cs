using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web6.Models;

namespace web6.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            //hàm Index mặc định sẽ render ra View có tên là Index.cshtml
            //return View();
            
            //nếu muốn hàm này render ra View khác thì khi rõ đường dẫn của View đấy
            //return View("~/Views/Demo/Greenwich.cshtml");
            return View("~/Views/Home/Privacy.cshtml");
        }
        
        public IActionResult Demo1()
        {
            //tạo dữ liệu mẫu để truyền sang view (front-end)
            string city = "Hà Nội";
            int year = 2021;
            double grade = 7.5;
            bool isPassed = false;
            
            //sử dụng ViewData để truyền dữ liệu sang view
            ViewData["city"] = city;
            ViewData["year"] = year;
            ViewData["GRADE"] = grade;
            ViewData["Pass"] = isPassed;
            ViewData["greenwich"] = "Greenwich Vietnam";
            return View();
        }

        public IActionResult Demo2()
        {
            string vn = "Vietnam";
            List<string> names = new List<string>()
            {
                "Minh", "Huong", "Hung", "Nam", "Khanh"
            };
            names.Add("Quan");
            names.Add("Tung");

            //sử dụng ViewBag để truyền dữ liệu
            ViewBag.Vietnam = vn;
            ViewBag.Name = names;

            return View();
        }

        public IActionResult Demo3()
        {
            //tạo List các Mobile dựa vào Model đã tạo
            List<Mobile> mobiles = new List<Mobile>()
            {
                new Mobile(1, "iPhone", 10, 1299.99),
                new Mobile(2, "Samsung", 20, 1199.99),
                new Mobile(3, "Xiaomi", 30, 1099.99),
            };

            //sử dụng model để truyển dữ liệu
            //Note: 1 action chỉ gửi được 1 model duy nhất
            return View(mobiles);
        }
        
    }
}
