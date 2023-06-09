﻿using MagazinArticoleVestimentare.Data;
using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ProduseController : Controller
    {
        private readonly AppDbContext _context;
        public ProduseController(AppDbContext context)
        {
             _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Produse.ToList();
            return View(data);

        }
    }
}
