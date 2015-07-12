using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    //- How to bind a dropdownlist from a viewmodel
    //- How to make an item selected in a dropdownlist through viewmodel
    //- How to do a full postback using dropdownlist (and retain the value selected after postback)
    //- How to retrieve the dropdownlist value posted through full postback (not through view model) using various ways
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
            m.SelectedCountry = Request["ddlCountries"];
            return View(m);
        }

        //OR
        //[HttpPost]
        //public ActionResult Index(FormCollection collection)
        //{
        //    var m = new Sample01ViewModel();
        //    m.SelectedCountry = collection.Get("ddlCountries");
        //    return View(m);
        //}

        //OR
        //[HttpPost]
        //public ActionResult Index(string ddlCountries)
        //{
        //    var m = new Sample01ViewModel();
        //    m.SelectedCountry = ddlCountries;
        //    return View(m);
        //}
    }
}