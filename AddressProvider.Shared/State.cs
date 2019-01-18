namespace AddressProvider.Shared
{
    using System.Collections.Generic;

    public class State
    {
        public string Name { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
