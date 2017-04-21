using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTutorials.Controllers
{
    public class City
    {
        public string Id { set; get; }
        public string Name { set; get; }
    }

    public class DropDownListViewModel
    {
        public string City { set; get; }       
    }

    public class DropDownListController : Controller
    {
        // GET: DropDownList
        public ActionResult Index()
        {
            var cities = new[]
            {
                new { ID = "DANANG", Name = "Chi nhánh Đà Nẵng - 38 Đường Yên Bái" },
                new { ID = "HUE", Name = "Chi nhánh Huế - 5A Đường Phong Châu (Big C)" },
                new { ID = "CANTHO", Name = "Chi nhánh Cần Thơ - 118 Đường 3/2" }
            };
            ViewBag.CityList = new SelectList(cities, "ID", "Name", "HUE");

            // Case 1: Ten ViewBag <> Ten DropDownList
            // ViewBag.CityList = new SelectList(cities, "ID", "Name", "HUE");
            // @Html.DropDownList("City", (SelectList)ViewBag.CityList, new { @class = "form-control" })

            // Case 2: Ten ViewBag == Ten DropDownList
            // ViewBag.City = new SelectList(cities, "ID", "Name", "HUE");
            // @Html.DropDownList("City", null, new { @class = "form-control" })


            var model = new DropDownListViewModel();
            ViewBag.City = new SelectList(cities, "ID", "Name", "HUE");
            return View(model);
        }
    }
}