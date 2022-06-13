using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IOfferCategoryService _offerCategoryService;

        public OfferService(IOfferRepository offerRepository, IOfferCategoryService offerCategoryService)
        {
            _offerRepository = offerRepository;
            _offerCategoryService = offerCategoryService;
        }

        //public OfferToListVM GetAllOffers()
        //{
        //    var offers = _offerRepository.GetAllOffers().ToModel();

        //    var offersList = offers.ToList();

        //    for (int i = 0; i < offersList.Count; i ++)
        //    {

        //        var categs = _offerCategoryRepository
        //            .GetCategoriesOfOffer(offersList[i].Id)
        //            .ToModel();
        //        offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
        //    }

        //    var result = new OfferToListVM
        //    {
        //        Offers = offersList
        //    };
        //    result.Count = result.Offers.Count;

        //    return result;
        //}

        public OfferToListVM GetAllOffers()
        {
            var offers = _offerRepository.GetAllOffers();

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName},
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;

        }

        public OfferToListVM Get20LatestOffers()
        {
            var offers = _offerRepository.Get20LatestOffers();

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName },
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;
        }

        public OfferToListVM FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByName(offerName, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit);

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName },
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;
        }
        public OfferToListVM FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByCategoryId(categoryId, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit);

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName },
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;
        }
        public OfferToListVM FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByNameAndCategoryId(offerName, categoryId, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit);

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName },
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;
        }
        public OfferToListVM FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByDate(createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit);

            OfferToListVM result = new OfferToListVM();

            result.Offers = new List<OfferVM>();
            foreach (var offer in offers)
            {
                // mapowanie obiektow
                var pVM = new OfferVM()
                {
                    Name = offer.Name,
                    Description = offer.Description,
                    ImagePath = offer.ImagePath,
                    CreationDate = offer.CreatedDate,
                    ExpirationDate = offer.ExpirationDate,
                    UserVM = new AppUserVm() { UserName = offer.User.UserName },
                    AddressVM = new AddressVM()
                    {
                        Country = offer.Address.Country,
                        City = offer.Address.City,
                        Street = offer.Address.Street,
                        ZipCode = offer.Address.ZipCode,
                        BuildingNr = offer.Address.BuildingNr,
                        ApartmentNr = offer.Address.ApartmentNr,
                    },
                    CategoryListVM = _offerCategoryService.GetCategoriesOfOffer(offer.Id)
                };
                result.Offers.Add(pVM);
            }
            result.Count = result.Offers.Count;
            return result;
        }
        public DateTime GetCreatedDateDownLimit() => _offerRepository.GetCreatedDateDownLimit();
        public DateTime GetCreatedDateUpLimit() => _offerRepository.GetCreatedDateUpLimit();
        public DateTime GetExpirationDateDownLimit() => _offerRepository.GetExpirationDateDownLimit();
        public DateTime GetExpirationDateUpLimit() => _offerRepository.GetExpirationDateUpLimit();
        public void AddOffer(Offer offer) => _offerRepository.AddOffer(offer);
    }
}
