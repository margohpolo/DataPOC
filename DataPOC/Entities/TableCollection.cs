using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Entities
{
    public class TableCollection
    {
        public string Name { get; private set; }
        public List<Table> Tables { get; private set; }
        public TableCollection(string dbName, DateTime dateTime, List<Table> tables)
        {
            Name = dbName + "_" + dateTime.ToString();
            Tables = tables;
        }
    }
}
