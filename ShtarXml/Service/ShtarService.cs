using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ShtarXml.Configuratuion.Configuration;

namespace ShtarXml.Service
{
    internal static class ShtarService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(ShtarPath))
            {
                
                XDocument document = new();
             
                XElement Queries = new("queries");

                document.Add(Queries);

                document.Save(ShtarPath);
            }
        }

        public static void addDateToXml(string day, string monthDay, string month, string year, string result)
        {
            
            XDocument document = XDocument.Load(ShtarPath);

            XElement? shtar = document.Descendants("queries").FirstOrDefault();

            if (shtar == null)
            {
                return;
            }

            //create new x elemnt (class-room)
            XElement newJewishDate = new(
                "query",
                new XElement("day", day),
                new XElement("day-month", monthDay),
                new XElement("month", month),
                new XElement("year", year),
                new XElement("result", result)
                );

            shtar.Add(newJewishDate);
            document.Save(ShtarPath);
        }

    }
}
