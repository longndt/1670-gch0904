using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using web4.Models;

namespace web4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            //khởi tạo dữ liệu mẫu
            Student s1 = new Student(1, "Nam", 18, "nam@gmail.com");
            Student s2 = new Student(2, "Minh", 19, "minh@gmail.com");
            Student s3 = new Student(3, "Huong", 20, "huong@gmail.com");
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            //render ra view và gửi kèm dữ liệu thông qua model
            return View(students);
        }
    }
}
