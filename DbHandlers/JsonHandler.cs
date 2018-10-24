using MvcApplication2.Interfaces;
using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.DbHandlers
{
    public class JsonHandler : IDatabase
    {
     //Demonstracja ze dane moga byc wczytane nie tylko z XML, bez koniecznosci wielkich zmian w kodzie
        public void Create(Models.CountryModel model)
        {
            throw new NotImplementedException();
        }


        public List<Models.CountryModel> GetCountries()
        {
            throw new NotImplementedException();
        }

        public CountryModel GetCountryByName(string countryName)
        {
            throw new NotImplementedException();
        }
    }
}