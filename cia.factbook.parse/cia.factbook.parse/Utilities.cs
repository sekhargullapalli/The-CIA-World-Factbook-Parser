using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace cia.factbook.parse
{
    public static class Utilities
    {
        /// <summary>
        /// Create the string for Flags of the world mark down file and writes to console.
        /// </summary>
        public static void CreateFlagsReadMe()
        {
            Console.Clear();
            Console.WriteLine("<div>");            
            string pattern = "<div class=\"flagcontainer\"><img src= \"https://raw.githubusercontent.com/sekhargullapalli/cia_factbook_parser/master/cia.factbook.data/country_flags/PATH\" width=\"125\" height =\"100\" title =\"TITLE\"><p>TITLE</p></div>";
            List<CountryData> CountryDataList =
               JsonConvert.DeserializeObject<List<CountryData>>(File.ReadAllText(@"countrydetailslist.json"));            
            var files = new DirectoryInfo(@"C:\Users\sekha\Desktop\factbook\attachments\flags").EnumerateFiles("*.gif");
            foreach (var file in files)
            {
                string filename = file.Name;
                CountryData data = CountryDataList.Where(x => x.code == file.Name.Substring(0,2)).FirstOrDefault();
                if (data != null && data.name!=string.Empty)
                    Console.WriteLine(pattern.Replace("PATH",filename).Replace("TITLE",data.name));
            }
            Console.WriteLine("</div>");
            //Following css is used            
            //< style type = "text/css" >
            //div.flagcontainer {
            //float: left;
            //margin: 10px;
            //max - width:120px;
            //height: 160px;
            //}
            //div p {
            //text - align: center;
            //}
            //</ style >
        }

        public static void PrintEntity(this ProfileEntity entity)
        {
            if (entity.Key.Trim() == string.Empty) throw new Exception("Empty Key!");
            if (entity.Value.Trim() == string.Empty && entity.Note.Trim()==string.Empty && entity.Children.Count == 0)
                throw new Exception("No value not child entities!");

            if (entity.EntityType== ProfileEntityType.Category)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n================================================================");
                Console.WriteLine(entity.Key);
                Console.WriteLine("==================================================================\n");
                foreach (var child in entity.Children)
                    child.PrintEntity();
            }            
            else if (entity.EntityType == ProfileEntityType.Field)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine($"  +{entity.Key}");
                Console.WriteLine("------------------------------------------------------------------\n");
                
                if (entity.Value.Trim()!=string.Empty)
                    Console.WriteLine($"  {entity.Value}\n");
                foreach (var child in entity.Children)
                    child.PrintEntity();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;


                if (entity.Note.Trim() != string.Empty)
                    Console.WriteLine($"  note: {entity.Note}");
                if (entity.Date.Trim() != string.Empty)
                    Console.WriteLine($"  date: {entity.Date}");
                if (entity.ComparisonRank.HasValue)
                    Console.WriteLine($"  country comparison to the world:: {entity.ComparisonRank}");
            }
            else if (entity.EntityType == ProfileEntityType.SubField)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (entity.Key=="*")
                    Console.WriteLine($"      * {entity.Value} {entity.Note} {entity.Date}");
                else
                    Console.WriteLine($"      +{entity.Key}: {entity.Value} {entity.Note} {entity.Date}");
            }
        }
    }
}
