using Microsoft.AspNetCore.Mvc;
using Salam_moloyko.DAL;
using Salam_moloyko.Models;

namespace Salam_moloyko.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurTeamsController : Controller
    {
        AppDbContext _context;

        public OurTeamsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Team> teams=_context.teams.ToList();
            return View(teams);
        }
    }
}
