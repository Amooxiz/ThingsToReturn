using Microsoft.EntityFrameworkCore;
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
            Id = c.Id,
            Name = c.Name
        }) ;
            
    }
    public static IQueryable<CategoryVM> ToModel(this IQueryable<OfferCategory> offcategories)
    {
        return offcategories.Select(oc => new CategoryVM
        {
            Id = oc.CategoryId,
            Name = oc.Category.Name
        });
    }

    //Ej szymon tutaj jeszce trzeba wyciagnac kategorie. Nie idzie przez kontekst latwo
    //Wiec trzeba przepisac do VM Id klienta i potem z serwisu wyciagnac kategorie :D
    public static IQueryable<OfferVM> ToModel(this IQueryable<Offer> offers)
    {
        return offers.Select(o => new OfferVM
        {
            Id = o.Id,
            Name = o.Name,
            Description = o.Description,
            ExpirationDate = o.ExpirationDate,
            ImagePath = o.ImagePath,
            UserVM = new AppUserVm { UserName = o.User.UserName, Id = o.User.Id},
            CreationDate = o.CreatedDate,
            AddressVM = new AddressVM
            {
                Country = o.Address.Country,
                ApartmentNr = o.Address.ApartmentNr,
                BuildingNr = o.Address.BuildingNr,
                City = o.Address.City,
                Street = o.Address.Street,
                ZipCode = o.Address.ZipCode
            },
            IsReservated = (String.IsNullOrEmpty(o.BookingId)) ? false : true,
            BookingId = o.BookingId
        });
    }
    public static AddressVM ToModel(this Address address)
    {
        return new AddressVM
        {
            Country = address.Country,
            City = address.City,
            Street = address.Street,
            ZipCode = address.ZipCode,
            BuildingNr = address.BuildingNr,
            ApartmentNr = address.ApartmentNr
        };
    }
    public static IQueryable<AppUserVm> ToModel(this IQueryable<AppUser> appUsers)
    {
        return appUsers.Select(x => new AppUserVm()
        {
            Id = x.Id,
            UserName = x.UserName
        });    
    }
}