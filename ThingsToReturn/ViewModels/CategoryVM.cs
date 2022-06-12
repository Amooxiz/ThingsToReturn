using System.ComponentModel.DataAnnotations;

namespace ThingsToReturn.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Display(Name = "Nazwa Kategorii")]
        public string Name { get; set; }
    }
}
