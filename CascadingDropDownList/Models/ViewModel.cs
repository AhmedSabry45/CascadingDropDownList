using System.ComponentModel.DataAnnotations;

namespace CascadingDropDownList.Models
{
    public class ViewModel
    {
        [Display(Name ="City")]
        public int CityId { get; set; }
        //to render dropdownlist

        public IEnumerable<City>? Cities { get; set; }


        [Display(Name = "Area")]
        public int AreaId { get; set; }
        //to render dropdownlist

        public IEnumerable<Area>? Areas { get; set; }=new List<Area>();



    }
}
