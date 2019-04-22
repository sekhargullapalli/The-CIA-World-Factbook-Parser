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
            //List<CountryData> CountryDataList =
            //    JsonConvert.DeserializeObject<List<CountryData>>(File.ReadAllText(@"countrydetailslist.json"));
            //CountryData data = CountryDataList.Where(x => x.code == "SE").First();
            //Console.WriteLine(data);
            //FactbookParser.ParseHTMLContent(data.html);
            //FactbookParser.ListAllFields(data.html);
            //FactbookParser.GetStructure(data.html);

            //string profileguidepath = @"C:/Users/sekha/Desktop/factbook/docs/print_profileguide.html";
            //FactbookParser.GetProfileSchema(File.ReadAllText(profileguidepath));

            //string notesanddefpath = @"C:/Users/sekha/Desktop/factbook/docs/print_notesanddefs.html";
            //FactbookParser.GetDefinitionandNotes(File.ReadAllText(notesanddefpath));

            string rankorderpath = @"C:/Users/sekha/Desktop/factbook/docs/print_rankorderguide.html";
            FactbookParser.GetComparableFields(File.ReadAllText(rankorderpath));




            Console.ReadLine();
        }
    }
}
