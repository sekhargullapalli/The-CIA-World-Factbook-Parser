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

            //string rankorderpath = @"C:/Users/sekha/Desktop/factbook/docs/print_rankorderguide.html";
            //FactbookParser.GetComparableFields(File.ReadAllText(rankorderpath));

            //Utilities.CreateFlagsReadMe();

            //FactbookParser.CreateCountryDataList();

            //List<CountryData> CountryDataList =
            //    JsonConvert.DeserializeObject<List<CountryData>>(File.ReadAllText(@"countrydetailslist.json"));
            //CountryData data = CountryDataList.Where(x => x.code == "SW").First();
            //Console.WriteLine(data);
            //List<ProfileEntity> entities = FactbookParser.ParseProfileData(data.html);
            //foreach (var entity in entities)
            //    entity.PrintEntity();

            //Creating country details!
            Dictionary<string, List<ProfileEntity>> CountryDetails = new Dictionary<string, List<ProfileEntity>>();
            List<CountryData> CountryDataList =
               JsonConvert.DeserializeObject<List<CountryData>>(File.ReadAllText(@"countrydetailslist.json"));
            Console.WriteLine($"Total Countries: {CountryDataList.Count}");
            int index = 1;
            foreach(var data in CountryDataList)
            {
                Console.WriteLine($"[ {index} of {CountryDataList.Count}] - {data.code} - {data.name}");
                List<ProfileEntity> entities = FactbookParser.ParseProfileData(data.html);
                foreach (var entity in entities)
                    entity.CheckEntity();
                CountryDetails.Add(data.code, entities);
                index++;
            }
            TextWriter tw = new StreamWriter("countrydetails.json");
            string json = JsonConvert.SerializeObject(CountryDetails, Formatting.Indented);
            tw.WriteLine(json);
            Console.WriteLine("Done!");

            Console.ReadLine();
        }
    }
}
