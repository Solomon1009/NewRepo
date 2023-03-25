using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext(); 
        // GET: Product
        public ActionResult Index()
        {
            var listProduct = _dbContext.Books.ToList();
            return View("TrangChu",listProduct);
        }

        public ActionResult Details(int id)
        {
            var product = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            return View("ChiTiet",product);
        }

        public ActionResult Authors()
        {
            var listAuthors = _dbContext.Authors.ToList();
            return View(listAuthors);
        }

        public ActionResult AuthorDetails(int id)
        {
            var author = _dbContext.Authors.FirstOrDefault(x => x.Id == id);
            return View(author);
        }
    }
}