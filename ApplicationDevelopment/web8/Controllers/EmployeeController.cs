using Microsoft.AspNetCore.Mvc;
using web8.Models;

namespace web8.Controllers
{
    public class EmployeeController : Controller
    {
        //hàm này để render ra form cho người dùng nhập liệu
        //Cách 2: set route để làm homepage
        [Route("/")]
        public IActionResult Input()
        {
            //mặc định thì 1 Action sẽ render ra View cùng tên với Action đấy
            //View: Input.cshtml (nằm trong thư mục Views/Employee)
            //return View();
            //render ra View khác tên với Action 
            return View("~/Views/Employee/Form.cshtml");
        }

        //hàm này để nhận dữ liệu từ form và render ra kết quả ở view khác
        //Thông tin nhập từ form sẽ lưu vào model của Employee
        public IActionResult Output(Employee employee)
        {
            //View: Output.cshtml (nằm trong thư mục Views/Employee)
            //controller gửi dữ liệu qua view theo dạng model (strongly type)
            return View(employee);
        }
    }
}
