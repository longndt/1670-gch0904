using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web9.Data;

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
        //Mục đích: Load toàn bộ dữ liệu từ bảng Mobile và gửi về View
        [Route("/")]
        public IActionResult Index()
        {
            var mobiles = context.Mobile.ToList();
            return View(mobiles);
        }
    }
}
