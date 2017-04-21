using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcTutorials.Models;

namespace AspNetMvcTutorials.Controllers
{
    public class DataModelExampleController : Controller
    {
        // GET: DataModelExample
        public ActionResult Index()
        {
            using (var db = new MvcShopOnlineEntities())
            {
                var products = db.Products.ToList();
                return View(products);
            }
        }


        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(RegisterUserView item)
        {
            string firstname = item.FirstName;
            string lastname = item.LastName;
            string email = item.Email;

            // INSERT TO DATABASE

            return RedirectToAction("Index", "Home");
        }

    }
}