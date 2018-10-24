using MvcApplication2.Interfaces;
using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcApplication2.DbHandlers
{
    public class XMLHandler : IDatabase
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Models.CountryModel>), new XmlRootAttribute("ArrayOfCountryModel"));
        string filePath = HttpContext.Current.Server.MapPath("~/App_Data/countryList.xml");

        public void Create(Models.CountryModel model)
        {
            var model2 = GetCountries(); 
            model2.Add(model);

            using (var writer = new FileStream(filePath, FileMode.Create))
            {
                new XmlSerializer(typeof(List<CountryModel>)).Serialize(writer, model2);
            }
        }

        public List<Models.CountryModel> GetCountries()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return (List<CountryModel>)xmlSerializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {

                return (new List<Models.CountryModel> { });
            }
          
        }


        public CountryModel GetCountryByName(string countryName)
        {
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                List<CountryModel> countries=(List<CountryModel>)xmlSerializer.Deserialize(reader);
                return countries.Where(country => country.Name == countryName).FirstOrDefault();
            }
        }
  

        private List<CountryModel> RedirectToAction(string p)
        {
            throw new NotImplementedException();
        }
    
    }
}