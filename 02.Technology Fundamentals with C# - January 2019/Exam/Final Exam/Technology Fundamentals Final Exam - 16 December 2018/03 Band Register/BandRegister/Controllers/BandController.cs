using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandDbContext())
            {
                var band = db.Bands.ToList();
                return View(band);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            using (var db = new BandDbContext())
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            using (var db = new BandDbContext())
            {
                db.Bands.Add(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandDbContext())
            {
                var bandToEdit = db.Bands.Find(id);
                return View(bandToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var db = new BandDbContext())
            {
                var bandToEdit = db.Bands.Update(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandDbContext())
            {
                var bandToDelete = db.Bands.Find(id);
                return View(bandToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {

            using (var db = new BandDbContext())
            {
                db.Bands.Remove(band);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}