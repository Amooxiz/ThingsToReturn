using System.Security.Claims;
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

        public OfferToListVM FiltrateOffers(FilterModel filterModel)
        {
            IQueryable<OfferVM> offers;
            if (filterModel.CategoryId == null && String.IsNullOrEmpty(filterModel.City) && String.IsNullOrEmpty(filterModel.Name))
                offers = _offerRepository.GetAllOffers().ToModel();
            else if (filterModel.CategoryId == null && String.IsNullOrEmpty(filterModel.City))
                offers = _offerRepository.FiltrateOffersBySearchTerm(filterModel.Name).ToModel();
            else if (filterModel.CategoryId == null && String.IsNullOrEmpty(filterModel.Name))
                offers = _offerRepository.FiltrateOffersByCity(filterModel.City).ToModel();
            else if (String.IsNullOrEmpty(filterModel.City) && String.IsNullOrEmpty(filterModel.Name))
                offers = _offerRepository.FiltrateOffersByCategoryId(filterModel.CategoryId).ToModel();
            else if (filterModel.CategoryId == null)
                offers = _offerRepository.FiltrateOffersBySearchTermAndCity(filterModel.Name, filterModel.City).ToModel();
            else if (String.IsNullOrEmpty(filterModel.Name))
                offers = _offerRepository.FiltrateOffersByCategoryIdAndCity(filterModel.CategoryId, filterModel.City).ToModel();
            else if (String.IsNullOrEmpty(filterModel.City))
                offers = _offerRepository.FiltrateOffersBySearchTermAndCategoryId(filterModel.Name, filterModel.CategoryId).ToModel();
            else
                offers = _offerRepository.FiltrateOffersBySearchTermAndCategoryIdAndCity(filterModel.Name, filterModel.CategoryId, filterModel.City).ToModel();

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

        public OfferToListVM GetOffersByCategoryId(int categoryId)
        {
            var offers = _offerRepository.FiltrateOffersByCategoryId(categoryId).ToModel();

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

        public OfferToListVM GetUsersOffers(Claim claim)
        {
            var offers = _offerRepository.GetUsersOffers(claim.Value).ToModel();
            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            OfferToListVM results = new()
            {
                Offers = offersList
            };
            results.Count = results.Offers.Count;

            return results;
        }

        public OfferToListVM GetNotUsersOffers(Claim claim)
        {
            var offers = _offerRepository.GetNotUsersOffers(claim.Value).ToModel();
            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            OfferToListVM results = new()
            {
                Offers = offersList
            };
            results.Count = results.Offers.Count;

            return results;
        }

        public Offer GetOffer(int offerId)
        {
            return _offerRepository.GetOffer(offerId);
        }

        public void RemoveOffer(Offer offer)
        {
            _offerRepository.RemoveOffer(offer);
        }

        public OfferToListVM GetFollowedOffers(Claim claim)
        {
            var offers = _offerRepository.GetFollowedOffers(claim.Value).ToModel();
            var offersList = offers.ToList();

            for (int i = 0; i < offersList.Count; i++)
            {

                var categs = _offerCategoryRepository
                    .GetCategoriesOfOffer(offersList[i].Id)
                    .ToModel();
                offersList[i].CategoryListVM = new CategoryToListVM { Categories = categs.ToList() };
            }

            OfferToListVM results = new()
            {
                Offers = offersList
            };
            results.Count = results.Offers.Count;

            return results;
        }
    }
}
