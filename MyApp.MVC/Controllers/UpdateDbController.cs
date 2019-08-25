using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Data;

namespace MyApp.MVC.Controllers
{
    public class UpdateDbController : Controller
    {
        private readonly DataContext _context;

        public UpdateDbController(DataContext context)
        {
            _context = context;
        }

        // GET: UpdateDb/Create
        public IActionResult Create()
        {
            ViewData["SqlQuery"] = string.Empty;

            return View();
        }

        // POST: UpdateDb/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string SqlQuery)
        {

            _context.Database.ExecuteSqlCommand(SqlQuery);

            return View();
        }

    }
}
