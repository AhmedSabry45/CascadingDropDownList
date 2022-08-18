using CascadingDropDownList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CascadingDropDownList.Controllers
{
    public class HomeController : Controller
    {
        
        private List<City> _cityList;

        private List<Area> _areaList;

        public HomeController()
        {
            //step1//
            _cityList = new List<City>
            { 
                new City{Id = 1, Name="Suez"},
                 new City{Id = 2, Name="Alex"},
                  new City{Id = 3,Name="Cairo"}
            };

            _areaList = new List<Area>
            {
                new Area{Id = 1,Name="Moshy",CityId=1},
                new Area{Id = 2,Name="elsalam",CityId=1},
                new Area{Id = 3,Name="Poartawfeek",CityId=1},
        
                 
                new Area{Id = 5,Name="Miamy",CityId=2},
                new Area{Id = 6,Name="Stanly",CityId=2},
                new Area{Id = 7,Name="Amria",CityId=2},
               
                
                new Area{Id = 9,Name="Marg",CityId=3},
                new Area{Id = 10,Name="Nasr-City",CityId=3},
                new Area{Id = 11,Name="Masr-elgdida",CityId=3}
               
            };
        }

        //step2 go to view Index
        public IActionResult Index()
        {
            //Step3 must send same type of Data
            var viewM = new ViewModel
            {
                Cities = _cityList.ToList(),
            };
            return View(viewM);
        }

        //action for Ajax Request
        public IActionResult GetAreas(int cityId)
        {
            var areas = _areaList.Where(a => a.CityId == cityId).ToList();
            return Ok(areas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}