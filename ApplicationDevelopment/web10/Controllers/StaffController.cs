using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web10.Data;

namespace web10.Controllers
{
    public class StaffController : Controller
    {
        //khai báo ApplicationDbContext để kết nối đến database
        private readonly ApplicationDbContext context;  
        
        public StaffController (ApplicationDbContext DbContext)
        {
            context = DbContext;
        }    

        //view all staffs
        public IActionResult Index()
        {
            var staffs = context.Staffs
                .Include(s => s.Department)
                .ToList();  //array of Staff objects
            return View(staffs); //gửi dữ liệu sang view bằng model
        }

        //view staff by id
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var staff = context.Staffs
                                .Include(s => s.Department) 
                                .FirstOrDefault(s => s.Id == id);
                                //Staff object
            return View(staff);
        }
    }
}
