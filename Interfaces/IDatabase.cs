using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.Interfaces
{
    public interface IDatabase
    {
        void Create(CountryModel model);

        List<CountryModel> GetCountries();
     
        CountryModel GetCountryByName(string countryName);
    }
}
