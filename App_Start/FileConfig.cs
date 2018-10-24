using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcApplication2.App_Start
{
    public static class FileConfig
    {

        public static void CreateXMLIfNotExist(){
            string filePath = HttpContext.Current.Server.MapPath("~/App_Data/countryList.xml");


            try 
	{
        if (!File.Exists(filePath))
            throw new FileNotFoundException();
	}
	catch (Exception)
	{
        using (File.Create(filePath)) { }

	}
        }
    }
}