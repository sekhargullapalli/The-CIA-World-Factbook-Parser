using System;
using System.Collections.Generic;
using System.Text;

namespace cia.factbook.parse
{
    public enum ProfileEntityType {None, Category, Field, SubField}
    /// <summary>
    /// The profile entity in the country details pages, Can be category, field or a sub-field
    /// </summary>
    public class ProfileEntity
    {
        public ProfileEntityType EntityType { get; set; } = ProfileEntityType.None;  
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";        
        public List<ProfileEntity> Children { get; set; } = new List<ProfileEntity>();

        public bool IsHistoric { get; set; } = false;
    }   
}
