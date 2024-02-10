// See https://aka.ms/new-console-template for more information
using DesignPatterns.SingletonPattern;



Console.WriteLine(DateTime.Now.ToLongTimeString());

var countries = await CountryProvider.Instance.GetCountries();

countries.ForEach(country => Console.WriteLine(country.Name));


await CountryProvider.Instance.GetCountries();

Console.WriteLine(CountryProvider.Instance.CountryCount);
Console.WriteLine(DateTime.Now.ToLongTimeString());