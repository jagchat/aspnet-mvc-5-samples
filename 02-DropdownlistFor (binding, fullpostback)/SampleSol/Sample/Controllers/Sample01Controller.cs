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
        public ActionResult Index(string dummy) //due to overload
        {
            var m = new Sample01ViewModel();
            m.SelectedCountry = Request["SelectedCountry"];
            return View(m);
        }

        //OR
        //[HttpPost]
        //public ActionResult Index(FormCollection collection)
        //{
        //    var m = new Sample01ViewModel();
        //    m.SelectedCountry = collection.Get("SelectedCountry");
        //    return View(m);
        //}

        //OR
        //[HttpPost]
        //public ActionResult Index(string SelectedCountry)
        //{
        //    var m = new Sample01ViewModel();
        //    m.SelectedCountry = SelectedCountry;
        //    return View(m);
        //}

        //OR
        //[HttpPost]
        //public ActionResult Index(Sample01ViewModel m) //posted value will be automatically assigned to "SelectedCountry" property in view model
        //{
        //    return View(m);
        //}
    }
}