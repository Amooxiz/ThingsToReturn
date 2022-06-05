using ThingsToReturn.Models;
using ThingsToReturn.ViewModels;

namespace ThingsToReturn.Extension;

public static class Extender
{
    public static IQueryable<AddressVM> ToModel(this IQueryable<Address> addresses)
    {
        return addresses.Select(a => new AddressVM
        {
            Country = a.Country,
            City = a.City,
            ZipCode = a.ZipCode, 
            Street = a.Street,
            BuildingNr = a.BuildingNr,

        });
    }
    public static IQueryable<CategoryVM> ToModel(this IQueryable<Category> categories)
    {
        return categories.Select(c => new CategoryVM
        {
            Name = c.Name
        }) ;
            
    }
    public static IQueryable<CategoryVM> ToModel(this IQueryable<OfferCategory> offcategories)
    {
        return offcategories.Select(c => new CategoryVM
        {
            Name = c.Category.Name
        });
    }

    public static IQueryable<OfferVM> ToModel(this IQueryable<Offer> offers)
    {
        return offers.Select(o => new OfferVM
        {
            Name = o.Name,
            Description = o.Description,
            ExpirationDate = o.ExpirationDate,
            ImagePath = o.ImagePath,
            UserVM = new AppUserVm { UserName = o.User.UserName },
        }) ;
    }
}