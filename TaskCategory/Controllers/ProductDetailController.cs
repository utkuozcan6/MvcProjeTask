using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TaskCategory.Data.Context;
using TaskCategory.Entity.Entities;

namespace TaskCategory.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _db;

        public ProductDetailController(AppDbContext db)
        {
            _db = db;
        }

        [Route("ProductDetail/Index/{id}")]
        public IActionResult Index(int id)
        {
            List<Product> objListProduct = _db.Products.Where(x => x.Id == id).ToList();
            return View(objListProduct);
        }
    }
}