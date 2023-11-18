using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DKFuni_MVC.Models;
namespace DKFuni_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DKSHOP_DBEntities dBContext = new DKSHOP_DBEntities();
            List<Product_Category> Listproduct = dBContext.Product_Category.ToList();
            return View(Listproduct);
        }
    }
}