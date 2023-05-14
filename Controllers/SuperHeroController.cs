using DotNET_CRUD.Models;
using DotNET_CRUD.Data;
using DotNET_CRUD.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNET_CRUD.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly SuperHeroContext _db;

        public SuperHeroController(SuperHeroContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SuperHero> objSuperHeroList = _db.SuperHeroes;
            return View(objSuperHeroList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                _db.SuperHeroes.Add(superHero);
                _db.SaveChanges();
                TempData["Success"] = "SuperHero Created!";
                return RedirectToAction("Index");
            }
            return View(superHero);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var superHero = _db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return NotFound();
            }
            return View(superHero);
        }

        [HttpPost]
        public IActionResult Edit(SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                _db.SuperHeroes.Update(superHero);
                _db.SaveChanges();
                TempData["Success"] = "SuperHero Updated!";
                return RedirectToAction("Index");
            }
            return View(superHero);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var superHero = _db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return NotFound();
            }
            return View(superHero);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var superHero = _db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return NotFound();
            }
            _db.SuperHeroes.Remove(superHero);
            _db.SaveChanges();
            TempData["Success"] = "SuperHero Deleted!";
            return RedirectToAction("Index");
        }
    }
}