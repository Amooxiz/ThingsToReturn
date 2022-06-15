using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IOfferCategoryRepository _offerCategoryRepository;
        private readonly IOfferCategoryService _offerCategoryService;

        public OfferService(IOfferRepository offerRepository, IOfferCategoryService offerCategoryService, IOfferCategoryRepository offerCategoryRepository)
        {
            _offerRepository = offerRepository;
            _offerCategoryService = offerCategoryService;
            _offerCategoryRepository = offerCategoryRepository;
        }

        public OfferToListVM GetAllOffers()
        {
            var offers = _offerRepository.GetAllOffers().ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public void ReserveOffer(string bookingUserId, int offerId)
        {
            _offerRepository.ReserveOffer(bookingUserId, offerId);
        }

        public void CancelReservation(int offerId)
        {
            _offerRepository.CancelReservation(offerId);
        }

        public OfferToListVM Get20LatestOffers()
        {
            var offers = _offerRepository.Get20LatestOffers().ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public OfferToListVM FiltrateOffersByName(string offerName, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByName(offerName, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }
        public OfferToListVM FiltrateOffersByCategoryId(int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByCategoryId(categoryId, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }
        public OfferToListVM FiltrateOffersByNameAndCategoryId(string offerName, int categoryId, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByNameAndCategoryId(offerName, categoryId, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }
        public OfferToListVM FiltrateOffersByDate(DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByDate(createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public OfferToListVM FiltrateOffersByCity(string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByCity(city, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public OfferToListVM FiltrateOffersByNameAndCity(string offerName, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByNameAndCity(offerName, city, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public OfferToListVM FiltrateOffersByNameAndCategoryIdAndCity(string offerName, int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByNameAndCategoryIdAndCity(offerName, categoryId, city, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
            result.Count = result.Offers.Count;

            return result;
        }

        public OfferToListVM FiltrateOffersByCategoryIdAndCity(int categoryId, string city, DateTime createdDateDownLimit, DateTime createdDateUpLimit, DateTime expirationDateDownLimit, DateTime expirationDateUpLimit)
        {
            var offers = _offerRepository.FiltrateOffersByCategoryIdAndCity(categoryId, city, createdDateDownLimit, createdDateUpLimit, expirationDateDownLimit, expirationDateUpLimit)
                .ToModel();

            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            var result = new OfferToListVM
            {
                Offers = offersList
            };
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
