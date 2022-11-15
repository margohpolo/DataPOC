using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Entities
{
    public class Table
    {
        public string Schema { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public List<Column> Columns { get; private set; }

        public Table(string schema, string name)
        {
            Schema = schema;
            Name = name;
        }
        public Table(string schema, string name, string description)
        {
            Schema = schema;
            Name = name;
            Description = description;
        }

        public void SetColumns(List<Column> cols)
        {
            Columns = cols;
        }

        public void SetDescription(string desc)
        {

            Description = desc ??= "Null";
        }

        public void SetColumnDescriptions(List<Column> colsList)
        {
            //Dictionary<string, string?> descriptionDict = new Dictionary<string, string?>();
            //foreach (Column col in colsList)
            //{
            //    descriptionDict.Add(col.Name, col.Description);
            //}

            Columns.ForEach(col => col.SetDescription(
                colsList.Where(c => c.Name == col.Name)
                .Select(c => c.Description)
                .FirstOrDefault()
                )
            );

        }
    }
}
