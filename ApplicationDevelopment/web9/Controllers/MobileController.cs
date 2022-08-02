using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web9.Data;
using web9.Models;

namespace web9.Controllers
{
    public class MobileController : Controller
    {
        //khởi tạo DbContext khi chạy controller
        protected readonly ApplicationDbContext context;
        public MobileController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //SQL: SELECT * FROM Mobile
        //set làm trang chủ của website bằng Route
        [Route("/")]  
        public IActionResult Index()
        {
            //lấy dữ liệu từ bảng Mobile và lưu vào list
            var mobiles = context.Mobile.ToList();
            //render ra view và trả về dữ liệu từ DB
            return View(mobiles);
        }

        public IActionResult List()
        {
            return View(context.Mobile.ToList());
        }

        public IActionResult Detail(int? id)
        {
            //check xem id có null không
            if (id == null)
            {
                return NotFound();
            }
            //lấy dữ liệu của mobile theo id được gửi từ client-side (view)
            var mobile = context.Mobile.FirstOrDefault(m => m.Id == id);
            //trả về view cùng dữ liệu tương ứng
            return View(mobile);
        }
    }
}
