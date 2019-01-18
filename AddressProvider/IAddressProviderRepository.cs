namespace AddressProvider
{
    using AddressProvider.Models;
    using System.Collections.Generic;

    public interface IAddressProviderRepository
    {
        IEnumerable<Country> GetCountries();
        IEnumerable<State> GetStates(string country);
        IEnumerable<City> GetCities(string country, string state);
        IEnumerable<District> GetDistricts(string country, string state);
        IEnumerable<District> GetDistricts(string country, string state, string city);
        IEnumerable<Neighborhood> GetNeighborhoods(string country, string state, string city);
        IEnumerable<Neighborhood> GetNeighborhoods(string country, string state, string city, string district);
    }
}
