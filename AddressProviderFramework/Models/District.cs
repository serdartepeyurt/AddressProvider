namespace AddressProviderFramework.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class District
    {
        public string Name { get; set; }
        public City City { get; set; }
        private List<Neighborhood> Neighborhoods { get; set; } = new List<Neighborhood>();

        public Neighborhood AddOrGetNeighborhood(string neighborhoodStr, string postalCode)
        {
            var registeredNeighborhood = this.GetNeighborhood(neighborhoodStr);
            if (registeredNeighborhood == null)
            {
                registeredNeighborhood = new Neighborhood
                {
                    Name = neighborhoodStr,
                    District = this,
                    PostalCode = postalCode
                };

                this.AddNeighborhood(registeredNeighborhood);
            }

            return registeredNeighborhood;
        }

        public Neighborhood GetNeighborhood(string neighborhoodStr)
        {
            return this.Neighborhoods.SingleOrDefault(s => s.Name == neighborhoodStr);
        }

        public IEnumerable<Neighborhood> GetNeighborhoods()
        {
            return this.Neighborhoods;
        }

        private void AddNeighborhood(Neighborhood neighborhood)
        {
            this.Neighborhoods.Add(neighborhood);
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.City.ToString()}";
        }
    }
}
