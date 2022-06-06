namespace ThingsToReturn.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository) => _addressRepository = addressRepository;
    }
}
