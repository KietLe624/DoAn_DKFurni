using DKFuni_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DKFuni_MVC.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Shop()
        {
            DKSHOP_DBEntities dbContect = new DKSHOP_DBEntities();
            List<Product_Category> Listproduct = dbContect.Product_Category.ToList();
            return View(Listproduct);
        }
        public ActionResult Detail(int id)
        {
            DKSHOP_DBEntities dbContect = new DKSHOP_DBEntities();
            Product_Category product = new Product_Category();
            return View(product);
        }
    }
}