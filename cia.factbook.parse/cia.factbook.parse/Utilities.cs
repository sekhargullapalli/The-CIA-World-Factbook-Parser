using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace cia.factbook.parse
{
    public class Utilities
    {
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
    }
}
