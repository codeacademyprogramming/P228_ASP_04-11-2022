using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228Mentor.DAL;
using P228Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Active = 6;

            List<Pricing> pricings = _context.Pricings
                .Include(p=>p.PricingServices).ThenInclude(ps=>ps.Service).ToList();

            ViewBag.Services = _context.Services.ToList();

            return View(pricings);
        }
    }
}
