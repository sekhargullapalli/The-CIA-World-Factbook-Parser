using System;
using System.Collections.Generic;
using System.Text;

namespace cia.factbook.parse
{
    public enum ProfileEntityType {None, Category, Field, SubField}
    class ProfileEntity
    {
        public ProfileEntityType EntityType { get; set; } = ProfileEntityType.None;  
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";
        public bool IsRankedEntity { get; set; } = false;
        public List<ProfileEntity> Children { get; set; } = new List<ProfileEntity>();
    }   
}
