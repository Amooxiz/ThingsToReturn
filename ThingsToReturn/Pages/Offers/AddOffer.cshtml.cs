using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

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
        private readonly IAppUserService _appUserService;

        public Address Address { get; set; }
        public IFormFile ImageFile { get; set; }
        public IList<int> Categories { get; set; }
        public Offer Offer { get; set; }
        public CategoryToListVM CategoryList { get; set; }

        public AddOfferModel(ILogger<AddOfferModel> logger, ICategoryService categoryService,
            IOfferCategoryService offercategoryservice, IOfferService offerService, IAppUserService appUserService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _offercategoryservice = offercategoryservice;
            _offerService = offerService;
            _appUserService = appUserService;
        }
        public void OnGet()
        {
            CategoryList = _categoryService.GetAllCategories();

        }

        public IActionResult OnPost()
        {

            CategoryList = _categoryService.GetAllCategories();

            var dir = Directory.GetCurrentDirectory();
            
            //Tu rzeczy zwiazane ze zdj
            var filename = ImageFile.FileName;
            string filePathForDatabase = "/Images/" + filename;
            string filePath = dir +"\\wwwroot" + "\\Images\\" + filename;

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //Trzeba to pododawac adres do ofert i tam inne wymagan
            Offer.ImagePath = filePathForDatabase;
            Offer.CreatedDate = DateTime.Now;
            Offer.Address = Address;
            Offer.User = _appUserService.GetUser(claim.Value);

            var categories = _categoryService.GetCategoriesByIdList(Categories);
            _offercategoryservice.AddOffersWithCategories(Offer, categories);


            //Zapis zdjeica
            Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            ImageFile.CopyTo(fileStream);
            fileStream.Dispose();

            return RedirectToPage("/Offers/Offers");
        }
    }
}
