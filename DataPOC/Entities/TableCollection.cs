using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Entities
{
    public class TableCollection
    {
        public List<Table> Tables { get; private set; }
        public TableCollection(List<Table> tables)
        {
            Tables = tables;
        }
    }
}
