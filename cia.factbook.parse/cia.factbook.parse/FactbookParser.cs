using System;
using System.Collections.Generic;
using System.Text;

using System.IO;


namespace cia.factbook.parse
{
    public class FactbookParser
    {
        public static void CreateCountriesList()
        {
            try
            {
                List<Country> Countries = new List<Country>();
                string[] lines = File.ReadAllLines("./countries.csv");
                for(int i = 1; i < lines.Length; i++)
                {
                    string[] vals = lines[i].Split(new char[] { ',' });
                    if (vals.Length < 7) continue;
                    Country c = new Country()
                    {
                        Name = vals[0].Trim(),
                        GEC = vals[1].Trim(),
                        ISO_3166_1_Alpha2=vals[2].Trim(),
                        ISO_3166_1_Alpha3 = vals[3].Trim(),
                        ISO_3166_1_Numeric = vals[4].Trim(),
                        STANAG = vals[5].Trim(),
                        Internet = vals[6].Trim()
                    };
                    if (vals.Length > 7)
                        c.Comment = vals[7].Trim();
                    if (c.GEC != "-")
                    {
                        Console.WriteLine(c.Name);
                        Countries.Add(c);
                    }
                }
                Console.WriteLine($"{Countries.Count} Countries");                
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
