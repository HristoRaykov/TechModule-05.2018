﻿using Microsoft.AspNetCore.WebUtilities;

namespace IMDB.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class FilmController : Controller
    {
        private readonly IMDBDbContext dbContext;

        public FilmController(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Film> films = dbContext.Films.ToList();
            
            return View(films);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {       
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                dbContext.Films.Add(film);
                dbContext.SaveChanges();

                return Redirect("/");
            }

            return View(film);
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            Film film = dbContext.Films.Find(id);

            return View(film);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Film film)
        {
            if (ModelState.IsValid)
            {
                dbContext.Films.Update(film);
                dbContext.SaveChanges();

                return Redirect("/");
            }

            return View(film);            
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int? id)
        {
            Film film = dbContext.Films.Find(id);

            return View(film);
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Film film)
        { 
            dbContext.Films.Remove(film);
            dbContext.SaveChanges();

            return Redirect("/");   
        }
    }
}
