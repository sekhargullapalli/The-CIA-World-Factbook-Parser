using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using AngleSharp.Html.Parser;

namespace cia.factbook.parse
{
    public class FactbookParser
    {
        /// <summary>
        /// Create a JSON file for countries with a valid GEC value
        /// </summary>
        public static void CreateCountriesList()
        {
            TextWriter tw = new StreamWriter("countrieslist.json", false);
            try
            {               
                var flagFiles = new DirectoryInfo(@"C:\Users\sekha\Desktop\factbook\attachments\flags").EnumerateFiles("*.gif");
                var anthemFiles = new DirectoryInfo(@"C:\Users\sekha\Desktop\factbook\attachments\audios\original").EnumerateFiles("*.mp3");
                var dataFiles = new DirectoryInfo(@"C:\Users\sekha\Desktop\factbook\json").EnumerateFiles("*.json");

                List<Country> Countries = new List<Country>();
                string[] lines = File.ReadAllLines("./countries.csv");
                for(int i = 1; i < lines.Length; i++)
                {
                    string[] vals = lines[i].Split(new char[] { ',' });
                    if (vals.Length < 7) continue;
                    Country c = new Country()
                    {
                        Name = vals[0].Trim().Replace("$$",","),
                        GEC = vals[1].Trim(),
                        ISO_3166_1_Alpha2=vals[2].Trim(),
                        ISO_3166_1_Alpha3 = vals[3].Trim(),
                        ISO_3166_1_Numeric = vals[4].Trim(),
                        STANAG = vals[5].Trim(),
                        Internet = vals[6].Trim()
                    }; //Note that "," values in the countries.csv file are replaced using "$$"
                    if (vals.Length > 7)
                        c.Comment = vals[7].Trim();
                    if (c.GEC != "-")
                    {
                        Console.WriteLine(c.Name);
                        Countries.Add(c);
                    }
                    //Checking paths
                    if (flagFiles.Where(f => f.Name.StartsWith(c.GEC)).Count() == 1)
                        c.Flagfile = flagFiles.Where(f => f.Name.StartsWith(c.GEC)).First().Name;
                    if (anthemFiles.Where(f => f.Name.StartsWith(c.GEC)).Count() == 1)
                        c.AnthemFile = anthemFiles.Where(f => f.Name.StartsWith(c.GEC)).First().Name;
                    if (dataFiles.Where(f => f.Name.StartsWith(c.GEC.ToLower())).Count() == 1)
                        c.Datafile = dataFiles.Where(f => f.Name.StartsWith(c.GEC.ToLower())).First().Name;
                }
                Console.WriteLine($"{Countries.Count} Countries");
                string json = JsonConvert.SerializeObject(Countries, Formatting.Indented);
                tw.WriteLine(json);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { tw.Close(); }
        }    
        /// <summary>
        /// Collect data from factbook json folder into one json file
        /// </summary>
        public static void CreateCountryDataList()
        {
            TextWriter tw = new StreamWriter("countrydetailslist.json",false);
            try
            {
                List<CountryData> CountryDataList = new List<CountryData>();
                var dataFiles = new DirectoryInfo(@"C:\Users\sekha\Desktop\factbook\json").EnumerateFiles("*.json");
                int verified = 0;
                foreach(var file in dataFiles)
                {
                    CountryData data = JsonConvert.DeserializeObject<CountryData>(File.ReadAllText(file.FullName));                    
                    Console.WriteLine(data);
                    if (data.code!=string.Empty && data.code.Length==2&&data.name!= string.Empty && data.html != string.Empty)
                    {
                        CountryDataList.Add(data);verified++;
                    }                   
                }
                Console.WriteLine($"Total files processed: {dataFiles.Count()}");
                Console.WriteLine($"Total files verified: {verified}");
                string json = JsonConvert.SerializeObject(CountryDataList, Formatting.Indented);
                tw.WriteLine(json);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { tw.Close(); }
        }


        public static void ParseHTMLContent(string content)
        {
            var parser = new HtmlParser();          
            try
            {
                var doc = parser.ParseDocument(content);
              
                //Reading background info
                var bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-background");
                if (bgelements.Count() != 0)
                {
                    //Console.WriteLine(bgelements.First().FirstElementChild.InnerHtml);                    
                    Console.WriteLine(bgelements.First().TextContent);
                }
                Console.WriteLine("----------------");
                bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-capital");
                if (bgelements.Count() != 0)
                {
                    foreach (var elem in bgelements.First().Children.Where(x => x.HasAttribute("class")
                     && x.GetAttribute("class").Contains("category_data")
                     && (x.GetAttribute("class").Contains("text") || x.GetAttribute("class").Contains("note"))))
                    {
                        foreach (var child in elem.Children)
                        {
                            Console.Write(child.TextContent);

                        }
                        elem.RemoveChild(elem.Children.First());
                        Console.WriteLine(elem.TextContent);
                    }
                }
                Console.WriteLine("------------------");
                bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-national-anthem");
                if (bgelements.Count() != 0)
                {
                    foreach (var elem in bgelements.First().Children.Where(x => x.HasAttribute("class")
                    && x.GetAttribute("class").Contains("category_data")
                    && (x.GetAttribute("class").Contains("text") || x.GetAttribute("class").Contains("note"))))
                    {
                        foreach (var child in elem.Children)
                        {
                            Console.Write(child.TextContent);
                        }
                        elem.RemoveChild(elem.Children.First());
                        Console.WriteLine(elem.TextContent);
                    }
                }
                Console.WriteLine("------------------");
                bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-country-name");
                if (bgelements.Count() != 0)
                {
                    foreach (var elem in bgelements.First().Children.Where(x => x.HasAttribute("class")
                    && x.GetAttribute("class").Contains("category_data")
                    && (x.GetAttribute("class").Contains("text") || x.GetAttribute("class").Contains("note"))))
                    {
                        foreach (var child in elem.Children)
                        {
                            Console.Write(child.TextContent);
                        }
                        elem.RemoveChild(elem.Children.First());
                        Console.WriteLine(elem.TextContent);
                    }
                }
                Console.WriteLine("------------------");
                bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-area");
                if (bgelements.Count() != 0)
                {
                    foreach (var elem in bgelements.First().Children.Where(x => x.HasAttribute("class")
                    && x.GetAttribute("class").Contains("category_data")
                    && (x.GetAttribute("class").Contains("text") || x.GetAttribute("class").Contains("note") || x.GetAttribute("class").Contains("numeric"))))
                    {
                        Console.Write(elem.Children.First().TextContent);
                        elem.RemoveChild(elem.Children.First());
                        Console.WriteLine(elem.TextContent);
                    }
                }
                Console.WriteLine("------------------");
                bgelements = doc.QuerySelectorAll("div").Where(x => x.GetAttribute("id") == "field-land-use");
                if (bgelements.Count() != 0)
                {
                    foreach (var elem in bgelements.First().Children.Where(x => x.HasAttribute("class")
                    && x.GetAttribute("class").Contains("category_data")
                    && (x.GetAttribute("class").Contains("text") || x.GetAttribute("class").Contains("note") || x.GetAttribute("class").Contains("numeric"))))
                    {
                        Console.Write(elem.Children.First().TextContent);
                        elem.RemoveChild(elem.Children.First());
                        Console.WriteLine(elem.TextContent);
                    }
                }




            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }



    }
   
}
