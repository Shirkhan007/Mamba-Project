using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Salam_moloyko.Areas.Admin.Controllers;
using Salam_moloyko.DAL;
using Salam_moloyko.Models;
using System.Diagnostics;

namespace Salam_moloyko.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;


        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            Team team = new Team()
            {
                Id= 1,
                Title="Isci",
                Description="kjsfksfjksjf",
                ImageUrl="dadad.png"
                
            };
            _dbContext.teams.Add(team);
            _dbContext.SaveChanges();
            return View();
        }
     
       
    }
}
