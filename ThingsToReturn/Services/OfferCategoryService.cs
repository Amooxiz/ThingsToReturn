using System.Security.Claims;
using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferCategoryService : IOfferCategoryService
    {
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        private readonly IAppUserService _appUserService;
        private readonly ICategoryService _categoryService;
        public OfferCategoryService(IOfferCategoryRepository offerCategoryRepository, IAppUserService appUserService, ICategoryService categoryService)
        {
            _offerCategoryRepository = offerCategoryRepository;
            _appUserService = appUserService;
            _categoryService = categoryService;
        }

        public void AddOffersWithCategories(Offer Offer, IFormFile ImageFile, Address Address, Claim claim, IList<int> Categories)
        {
            var dir = Directory.GetCurrentDirectory();

            //Tu rzeczy zwiazane ze zdj
            var filename = ImageFile.FileName;
            string filePathForDatabase = "/Images/" + filename;
            string filePath = dir + "\\wwwroot" + "\\Images\\" + filename;

            //Trzeba to pododawac adres do ofert i tam inne wymagan
            Offer.ImagePath = filePathForDatabase;
            Offer.CreatedDate = DateTime.Now;
            Offer.Address = Address;
            Offer.User = _appUserService.GetUser(claim.Value);

            var categories = _categoryService.GetCategoriesByIdList(Categories);

            //Zapis zdjeica
            Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            ImageFile.CopyTo(fileStream);
            fileStream.Dispose();

            var offercats = categories.Select(c => new OfferCategory
            {

                Category = c,
                Offer = Offer,
            }).ToList();

            _offerCategoryRepository.AddOffersWithCategories(offercats);
            
        }

        public CategoryToListVM GetCategoriesOfOffer(int offerId)
        {
            
            var categories = _offerCategoryRepository.GetCategoriesOfOffer(offerId).ToModel();

            var result = new CategoryToListVM
            {
                Categories = categories.ToList()
            };
            result.Count = result.Categories.Count;

            return result;

        }

    }
}
