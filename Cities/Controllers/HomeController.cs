﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repo)
        {
            _repository = repo;
        }

        public ViewResult Index() => View(_repository.Cities);

        public ViewResult Create() => View();

        [HttpPost]
        public IActionResult Create(City city)
        {
            _repository.AddCity(city);
            return RedirectToAction("Index");
        }
    }
}
