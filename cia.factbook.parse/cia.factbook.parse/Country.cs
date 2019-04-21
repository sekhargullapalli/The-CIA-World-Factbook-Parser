using System;
using System.Collections.Generic;
using System.Text;

namespace cia.factbook.parse
{
    public class Country
    {
        /// <summary>Country Name</summary>        
        public string Name { get; set; } = "";
        /// <summary>Geo political entities and codes (formerly FIPS PUB 10-4)</summary>        
        public string GEC { get; set; } = "";
        /// <summary>ISO 3166 1 two character code</summary>
        public string ISO_3166_1_Alpha2 { get; set; } = "";
        /// <summary>ISO 3166 1 three character code</summary>
        public string ISO_3166_1_Alpha3 { get; set; } = "";
        /// <summary>ISO 3166 1 three digit numeric code</summary>
        public string ISO_3166_1_Numeric { get; set; } = "";
        /// <summary>Standardization agreement 1059</summary>
        public string STANAG { get; set; } = "";
        /// <summary>Internet country code</summary>        
        public string Internet{ get; set; } = "";
        /// <summary>Additional Comment</summary>        
        public string Comment { get; set; } = "";

        /// <summary>Flag image file name</summary> 
        public string Flagfile { get; set; } = "";
        /// <summary>National anthem mp3 file name</summary> 
        public string AnthemFile { get; set; } = "";
        /// <summary>Json file (containing HTML data) name</summary> 
        public string Datafile { get; set; } = "";
    }
}
