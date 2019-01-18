namespace AddressProviderFramework.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class State
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        private List<City> Cities { get; set; } = new List<City>();

        public City AddOrGetCity(string cityName)
        {
            var registeredCity = this.GetCity(cityName);
            if (registeredCity == null)
            {
                registeredCity = new City
                {
                    Name = cityName,
                    State = this
                };

                this.AddCity(registeredCity);
            }

            return registeredCity;
        }

        public City GetCity(string cityName)
        {
            return this.Cities.SingleOrDefault(s => s.Name == cityName);
        }

        public IEnumerable<City> GetCities()
        {
            return this.Cities;
        }

        private void AddCity(City city)
        {
            this.Cities.Add(city);
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Country.ToString()}";
        }
    }
}
