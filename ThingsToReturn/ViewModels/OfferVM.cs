namespace ThingsToReturn.ViewModels
{
    public class OfferVM
    {
        public string Name { get; set; }
        public string? ImagePath { get; set; }
        public string? Description { get; set; }
        public DateTime ExpirationDate { get; set; }
        public AddressVM AddressVM { get; set; }
        public bool IsReservation { get; set; }
    }
}
