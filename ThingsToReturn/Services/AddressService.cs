using ThingsToReturn.Extension;

namespace ThingsToReturn.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository) => _addressRepository = addressRepository;

        public AddressVM GetAddress(string userId)
        {
            return _addressRepository.GetAddress(userId).ToModel();
        }
    }
}
