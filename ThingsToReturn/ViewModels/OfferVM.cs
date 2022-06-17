namespace ThingsToReturn.ViewModels;

public class OfferVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? ImagePath { get; set; }
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public AddressVM AddressVM { get; set; }
    public AppUserVm UserVM { get; set; } 
    public CategoryToListVM CategoryListVM { get; set; }
    public bool IsReservated { get; set; }
    public string? BookingId { get; set; }
}
