using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace cia.factbook.parse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CountryData> CountryDataList =
                JsonConvert.DeserializeObject<List<CountryData>>(File.ReadAllText(@"countrydetailslist.json"));
            CountryData data = CountryDataList.Where(x => x.code == "IN").First();
            Console.WriteLine(data);
            //FactbookParser.ParseHTMLContent(data.html);
            //FactbookParser.ListAllFields(data.html);
            FactbookParser.GetStructure(data.html);
            Console.ReadLine();
        }
    }
}
