using System.ComponentModel.DataAnnotations;

namespace ThingsToReturn.ViewModels
{
    public class CategoryVM
    {
        [Display(Name = "Nazwa Kategorii")]
        public string Name { get; set; }
    }
}
