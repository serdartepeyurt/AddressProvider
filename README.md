# AddressProviderFramework
Simple address provider framework and PTT(Turkish Post) implementation written on NetCore 2.2. When implemented it turns into a basic one-way in-memory database for addresses.

You can easily add your own implementations, and you can share them with me so I can display here!

## NuGet Packages 
AddressProviderFramework https://www.nuget.org/packages/AddressProviderFramework/1.0.1

PTT(Turkish Post) Implementation https://www.nuget.org/packages/AddressProviderFramework.Implementations.Ptt/1.0.0

## Usage example

```C#
var repo = new PttAddressProviderRepository();
repo.Initialize("pk_2019_01_14.xlsx");

// Get the first country
var country = repo.GetCountries().First();
var states = repo.GetStates(country.Name);

foreach(var state in states)
{
    Console.WriteLine(state);
}

Console.ReadLine();
```

![output](https://user-images.githubusercontent.com/1710600/51405449-6b763080-1b67-11e9-8139-89cd29145e63.png)

## How to use

The PTT(Turkish Post) implementation for AddressProviderFramework, uses xslx file to populate data. You can get the latest xlsx file from http://postakodu.ptt.gov.tr/Dosyalar/pk_list.zip

Because it uses a file to populate data, you don't need any other data source. It loads data on `Initialize()` method, by given data file. If you are leveraging DI, it should be added to the services layer as a singleton service.

```C#
// Use this method to add services to the container.
public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddSingleton<IAddressProviderRepository, PttAddressProviderRepository>(serviceProvider =>
        {
            var repo = new PttAddressProviderRepository();
            repo.Initialize(filePath);
            return repo;
        });
}
```


## How to implement new providers

You can simply include the NuGet package, then implement the `IAddressProviderRepository` however you'd like. You can always use any data source.

## Third party packages

In PTT implementation, there's an excel reader package used `ExcelDataReader`. You can find it on https://github.com/ExcelDataReader/ExcelDataReader.
