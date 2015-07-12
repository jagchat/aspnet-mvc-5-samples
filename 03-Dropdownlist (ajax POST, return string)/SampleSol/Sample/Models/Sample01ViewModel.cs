using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Models
{
    public class Sample01ViewModel
    {
        public string SelectedCountry { get; set; }

        public List<Country> Countries
        {
            get
            {
                return new List<Country>()
                {
                    new Country(){Id="USA", Caption = "United States of America"},
                    new Country(){Id="IN", Caption = "India"},
                    new Country(){Id="CAN", Caption = "Canada"},
                };
            }
        }

        public IEnumerable<SelectListItem> GetCountriesListItems()
        {
            return Countries.Select(c => new SelectListItem() { Text = c.Caption, Value = c.Id });
        }
    }
}