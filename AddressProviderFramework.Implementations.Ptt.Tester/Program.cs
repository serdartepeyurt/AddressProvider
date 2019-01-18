using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AddressProviderFramework.Implementations.Ptt.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new PttAddressProviderRepository();
            repo.Initialize("pk_2019_01_14.xlsx");

            // Get the first country
            var country = repo.GetCountries().First();

            // Get states
            var states = repo.GetStates(country.Name);

            foreach(var state in states)
            {
                Console.WriteLine(state);
            }

            var sc = new ServiceCollection();
            sc.AddSingleton<IAddressProviderRepository, PttAddressProviderRepository>(serviceProvider =>
            {
                var rep = new PttAddressProviderRepository();
                repo.Initialize("");
                return rep;
            });

            Console.ReadLine();
        }
    }
}
