using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Entities
{
    public class Column
    {
        public string Name {get; private set;}
        public string Description {get; private set; }
        public ColumnAttributes Attributes {get; private set; }

        public Column(string name)
        {
            Name = name;
        }
        public Column(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void SetDescription(string desc)
        {
            Description = desc ??= "Null";
        }
        public void SetAttributes(ColumnAttributes attributes)
        {
            Attributes = attributes;
        }
    }
}
