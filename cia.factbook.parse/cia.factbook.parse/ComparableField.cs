using System;
using System.Collections.Generic;
using System.Text;

namespace cia.factbook.parse
{
    public class ComparableField
    {
        public string FieldName { get; set; } = "";
        public string Category { get; set; } = "";
        public bool IsDescending { get; set; } = true;
    }
}
