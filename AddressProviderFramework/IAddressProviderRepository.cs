namespace AddressProviderFramework
{
    using AddressProviderFramework.Models;
    using System.Collections.Generic;

    public interface IAddressProviderRepository
    {
        /// <summary>
        /// Gets countries
        /// </summary>
        /// <returns></returns>
        IEnumerable<Country> GetCountries();
        IEnumerable<State> GetStates(string country);
        /// <summary>
        /// Gets cities by given params.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="state">Can be null</param>
        /// <returns></returns>
        IEnumerable<City> GetCities(string country, string state);
        /// <summary>
        /// Gets districts by given params.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="state"></param>
        /// <param name="city">Can be null</param>
        /// <returns></returns>
        IEnumerable<District> GetDistricts(string country, string state, string city = null);
        /// <summary>
        /// Gets neighborhoods by given params.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="state"></param>
        /// <param name="city"></param>
        /// <param name="district">Can be null</param>
        /// <returns></returns>
        IEnumerable<Neighborhood> GetNeighborhoods(string country, string state, string city, string district = null);
    }
}
