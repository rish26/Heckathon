using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Web.Mvc;

namespace Heckathon.Models
{
    public class CityViewModel
    {
        public List<Models.CityDataModel> CityList =
            new List<Models.CityDataModel>();
        public int SelectedCityID { get; set; }
        public IEnumerable<SelectListItem> CityIEnum
        {
            get
            {
                return new SelectList(CityList, "ID", "CityName");
            }
        }
    }

    public class StateProvinceViewModel
    {
        public List<Models.StateProvinceDataModel> StateProvinceList =
            new List<Models.StateProvinceDataModel>();
        public int SelectedStateProvinceID { get; set; }
        public IEnumerable<SelectListItem> StateProvinceIEnum
        {
            get
            {
                return new SelectList(StateProvinceList, "ID", "StateOrProvinceName");
            }
        }
    }

    public class CountryViewModel
    {
        public List<Models.CountryDataModel> CountryList =
            new List<Models.CountryDataModel>();
        public int SelectedCountryID { get; set; }
        public IEnumerable<SelectListItem> CountryIEnum
        {
            get
            {
                return new SelectList(CountryList, "ID", "CountryName");
            }
        }
    }

  
}