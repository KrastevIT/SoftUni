using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BookLibraryDbContext())
            {
                var library = db.Libraries.ToList();
                return View(library);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            using (var db = new BookLibraryDbContext())
            {
                db.Libraries.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BookLibraryDbContext())
            {
                var libraryToEdit = db.Libraries.Find(id);
                return View(libraryToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new BookLibraryDbContext())
            {
                db.Libraries.Update(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BookLibraryDbContext())
            {
                var libraryDelete = db.Libraries.Find(id);
                return View(libraryDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new BookLibraryDbContext())
            {
                db.Libraries.Remove(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}