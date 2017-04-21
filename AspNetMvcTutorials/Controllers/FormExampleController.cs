using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTutorials.Controllers
{
    public class FormExampleController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string q)
        {
            var message = "You want to search: " + q;
            ViewBag.Result = message;
            return View();
        }

        public ActionResult RazorForm()
        {
            return View();
        }
    }
}