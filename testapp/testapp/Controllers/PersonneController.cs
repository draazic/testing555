using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testapp.Models;

namespace testapp.Controllers
{
    public class PersonneController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PersonneController(ApplicationDbContext db)
        {
            _db = db;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }


        [HttpGet("Personne")]

        public IActionResult Personne()
        {
            return View(_db.Personne.OrderBy(x => x.Name).ToList());
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Personne personne)
        {
            DateTime today = DateTime.Now;

            int result = DateTime.Compare(today, personne.BithDay);
            if(result > 150)
            {
                //ModelState.IsValid = false;
            }

            if (ModelState.IsValid)
            {
                _db.Add(personne);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Personne));
            }
            return View();
        }
    }
}
