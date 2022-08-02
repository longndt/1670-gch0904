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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //gọi ra object mobile theo id trong DB
            var mobile = context.Mobile.Find(id);
            //xóa object mobile => xóa hàng trong bảng mobile
            context.Mobile.Remove(mobile);
            //lưu thay đổi vào DB
            context.SaveChanges();
            return RedirectToAction("Index");
            //return RedirectToAction(nameof(Index));
        }

        //Note: có thể đặt 2 action cùng tên nếu khác phương thức (VD: HttpGet và HttpPost)

        //Action Add_1 dùng để render ra form cho người dùng nhập liệu
        [HttpGet]
        public IActionResult Add ()
        {
            return View();
        }

        //Action Add_2 dùng để nhận dữ liệu từ form, xác thực dữ liệu
        //và lưu vào database nếu dữ liệu hợp lệ sau đó redirect về trang Index
        [HttpPost]
        public IActionResult Add (Mobile mobile)
        {
            //validate dữ liệu từ form
            if (ModelState.IsValid)
            {
                //add dữ liệu từ object mobile vào DB
                context.Add(mobile);
                context.SaveChanges();
                //chuyển về trang index sau khi add thành công
                return RedirectToAction(nameof(Index));
            }
            //nếu người dùng thì render ra form kèm dữ liệu để người dùng nhập lại
            return View(mobile);
        }

        //hàm Edit_1 để render ra view Edit mobile
        //yêu cầu là load dữ liệu của mobile theo id
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mobile = context.Mobile.Find(id);
            return View(mobile);
        }

        //hàm Edit_2 để nhận dữ liệu từ form
        //xác thực dữ liệu và lưu vào DB
        [HttpPost]
        public IActionResult Edit(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                context.Update(mobile);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mobile);
        }
    }
}
