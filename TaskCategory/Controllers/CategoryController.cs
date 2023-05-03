using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskCategory.Data.Context;
using TaskCategory.Entity.Entities;

namespace TaskCategory.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objListCategory = _db.Products.ToList();
            return View(objListCategory);
        }
    }
}