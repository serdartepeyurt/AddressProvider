namespace AddressProvider.Shared
{
    using System;
    using System.Collections.Generic;

    public class Country
    {
        public string Name { get; set; }
        public IEnumerable<State> States { get; set; }
    }
}
