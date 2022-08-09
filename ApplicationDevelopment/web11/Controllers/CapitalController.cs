using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web11.Data;
using web11.Models;

namespace web11.Controllers
{
    public class CapitalController : Controller
    {
        private ApplicationDbContext context;

        public CapitalController(ApplicationDbContext DbContext)
        {
            this.context = DbContext;
        }
        
        public IActionResult Index()
        {
            var capitals = context.Capital
                .Include(c => c.Country)
                .ToList();
            return View(capitals);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //gọi đến capital theo id có chứa liên kết đến bảng Country
            var capital = context.Capital
                    .Include(c => c.Country)
                    .FirstOrDefault(c => c.Id == id);
            return View(capital);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //tạo object capital chứa id cần xóa
            var capital = context.Capital.Find(id);
            //dùng DbContext để xóa objet
            context.Remove(capital);
            //lưu lại thay đổi trong DB
            context.SaveChanges();
            //gửi thông báo về view thông qua TempData
            TempData["Info"] = "Delete capital succeed !";
            //quay ngược về action Index sau khi thành công
            return RedirectToAction("Index");
        }

        //hàm này để render ra form Add cho người dùng nhập
        [HttpGet]
        public IActionResult Add ()
        {
            //sử dụng ViewBag để đẩy dữ liệu của bảng Country vào form
            var countries = context.Country.ToList();
            ViewBag.Countries = countries;
            return View();
        }

        //hàm này để nhận và xử lý dữ liệu từ form
        [HttpPost] 
        public IActionResult Add (Capital capital)
        {
            //validate dữ liệu từ form thông qua annotation của Model
            if (ModelState.IsValid)
            {
                //add dữ liệu vào DB nếu hợp lệ
                context.Add(capital);
                context.SaveChanges();
                //trả thông báo về view
                TempData["Info"] = "Add capital succeed !";
                //redirect về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu nhập vào không hợp lệ trả lại form cùng với dữ liệu đã nhập
            return View(capital);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            //check id null
            if (id == null)
            {
                return NotFound();
            }
            //đẩy dữ liệu của bảng Country vào form
            var countries = context.Country.ToList();
            ViewBag.Countries = countries;
            //tạo object capital lấy từ DB theo id
            var capital = context.Capital.Find(id);
            //render ra form Edit cùng với dữ liệu sẵn có
            return View(capital);
        }

        [HttpPost]
        public IActionResult Edit(Capital capital)
        {
            if (ModelState.IsValid)
            {
                //update dữ liệu vào DB nếu hợp lệ
                context.Update(capital);
                context.SaveChanges();
                //trả thông báo về view
                TempData["Info"] = "Edit capital succeed !";
                //redirect về trang index
                return RedirectToAction(nameof(Index));
            }
            //nếu dữ liệu nhập vào không hợp lệ trả lại form cùng với dữ liệu đã nhập
            return View(capital);
        }
    }
}
