using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository) => _addressRepository = addressRepository;

        public List<string> GetAllCities()
        {
            return _addressRepository.GetAllCities().ToList();
        }
    }
}
