﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TatilRezervasyon.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
            
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.TGetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }


    }
}
