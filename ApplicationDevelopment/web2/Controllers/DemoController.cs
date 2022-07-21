using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Demo1()
        {
            string vn = "Vietnam is a peaceful country";
            int year = 2022;
            ViewData["vietnam"] = vn;
            ViewData["year"] = year;
            ViewData["grade"] = 7.8;
            return View();
        }

        public IActionResult Demo2()
        {
            string gw = "Greenwich University - Vietnam";
            ViewBag.Greenwich = gw;
            ViewBag.Price = 999.99;
            List<string> cities = new List<string>()
            {
                 "Hanoi", "HCM City", "Da Nang"
            };
            cities.Add("Hue");
            cities.Remove("HCM City");
            ViewBag.City = cities;        
            return View();
        }
    }
}
