namespace AddressProvider.Models
{
    public class Neighborhood
    {
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public District District { get; set; }

        public override string ToString()
        {
            return $"{this.Name}, {this.District.ToString()}, {this.PostalCode}";
        }
    }
}