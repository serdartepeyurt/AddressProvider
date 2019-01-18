using System.Collections.Generic;
using System.Linq;

namespace AddressProviderFramework.Models
{
    public class City
    {
        public string Name { get; set; }
        public State State { get; set; }
        private List<District> Districts { get; set; } = new List<District>();

        public District AddOrGetDistrict(string districtName)
        {
            var registeredDistrict = this.GetDistrict(districtName);
            if (registeredDistrict == null)
            {
                registeredDistrict = new District
                {
                    Name = districtName,
                    City = this
                };

                this.AddDistrict(registeredDistrict);
            }

            return registeredDistrict;
        }

        public District GetDistrict(string districtName)
        {
            return this.Districts.SingleOrDefault(s => s.Name.ToUpperInvariant() == districtName.ToUpperInvariant());
        }

        public IEnumerable<District> GetDistricts()
        {
            return this.Districts;
        }

        private void AddDistrict(District district)
        {
            this.Districts.Add(district);
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.State.ToString()}";
        }
    }
}