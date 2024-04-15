using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2_LTT.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.name = "Le Tuan Tinh - 2210900130";
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}