using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using web11.Data;

namespace web11.Controllers
{
    public class CountryController : Controller
    {
        private ApplicationDbContext context;

        public CountryController(ApplicationDbContext DbContext)
        {
            this.context = DbContext;
        }
        
        public IActionResult Index()
        {
            return View(context.Country
                            .Include(c => c.Capital)
                            .ToList());
        }
    }
}
