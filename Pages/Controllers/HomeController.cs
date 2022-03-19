﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BillTotal = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(BillModel bill)
        {
            if (ModelState.IsValid)
            {
                var model = bill;
                //var Model = Model;
                ViewBag.BillTotal = model.CalculateBillTotal();
            }
            else
            {
                ViewBag.BillTotal = 0;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}