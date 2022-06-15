using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ThingsToReturn.Pages
{
    [BindProperties]
    [Authorize]
    public class AddOfferModel : PageModel
    {
        private readonly ILogger<AddOfferModel> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IOfferCategoryService _offercategoryservice;
        private readonly IOfferService _offerService;

        public Address Address { get; set; }
        public IFormFile ImageFile { get; set; }
        public IList<int> Categories { get; set; }
        public Offer Offer { get; set; }
        public CategoryToListVM CategoryList { get; set; }

        public AddOfferModel(ILogger<AddOfferModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
        }
        public void OnGet()
        {
            CategoryList = _categoryService.GetAllCategories();

        }

        public IActionResult OnPost()
        {
            CategoryList = _categoryService.GetAllCategories();

            //Tu rzeczy zwiazane ze zdj
            var cwd = Directory.GetCurrentDirectory();
            var filename = ImageFile.FileName;
            string filePath = cwd + "\\Images\\" + filename;

            //Trzeba to pododawac adres do ofert i tam inne wymagan
            Offer.ImagePath = filePath;
            Offer.CreatedDate = DateTime.Now;

            //Zapis zdjeica
            Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            ImageFile.CopyTo(fileStream);

            _offerService.AddOffer(Offer);
            return Page();
        }
    }
}
