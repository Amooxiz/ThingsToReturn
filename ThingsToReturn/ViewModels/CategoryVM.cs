using System.ComponentModel.DataAnnotations;

namespace ThingsToReturn.ViewModels
{
    public class CategoryVM
    {
        [Display(Name = "Nazwa Kategorii")]
        string Name { get; set; }
    }
}
