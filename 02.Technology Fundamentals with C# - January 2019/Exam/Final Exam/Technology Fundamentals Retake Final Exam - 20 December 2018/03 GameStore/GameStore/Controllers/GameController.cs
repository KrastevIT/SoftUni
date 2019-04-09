using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var gameStore = db.GameStores.ToList();
                return View(gameStore);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            using (var db = new GameStoreDbContext())
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.GameStores.Add(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameStoreToEdit = db.GameStores.Find(id);
                return View(gameStoreToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameStoreToEdit = db.GameStores.Update(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var gameSoreToDelete = db.GameStores.Find(id);
                return View(gameSoreToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.GameStores.Remove(game);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}