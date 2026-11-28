using GymSystem.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Controllers
{
    public class PlanController : Controller
    {
        private GymDBContext _context=new GymDBContext();
        public async Task<IActionResult> Index()
        {
            var plans=await _context.Plans.ToListAsync();
            return View(plans);
        }


    }
}
