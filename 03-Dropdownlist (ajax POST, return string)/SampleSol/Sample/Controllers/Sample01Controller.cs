using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class Sample01Controller : Controller
    {
        // GET: Sample01
        public ActionResult Index()
        {
            var m = new Sample01ViewModel();
            return View(m);
        }

        [HttpPost]
        public string PostSelectedCountry(Sample01ViewModel m)
        {
            return m.SelectedCountry;
        }

    }
}