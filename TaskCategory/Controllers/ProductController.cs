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
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;

        public ProductController(AppDbContext db)
        {
            _db = db;
        }

        [Route("Product/Index/{id}")]
        public IActionResult Index(int id)
        {
            List<Product> objListProduct = _db.Products.Where(x => x.CategoryId == id && x.IsNew).ToList();
            return View(objListProduct);
        }

        [Route("Product/IndexProductDetail/{id}")]
        public IActionResult IndexProductDetail(int id)
        {
            List<Product> objListProduct = _db.Products.Where(x => x.Id == id).ToList();
            return View(objListProduct);
        }
    }
}