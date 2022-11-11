using DataPOC.Entities;
using DataPOC.Queries;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Infrastructure
{
    public class QueryRepository
    {
        private QueryList _queryList;
        private string _connString;
        public QueryRepository(string connectionString)
        {
            _connString = connectionString;
            _queryList = new QueryList();
        }


        public List<Table> GetAllTables()
        {
            return ExecuteSql(connString: _connString,
                cmdText: _queryList.GetAllTablesQuery(),
                map: x => new Table(schema: (string) x[0], name: (string) x[1])
                );
        }

        public Table GetTableDescription(Table table)
        {
            List<string> tblDesc = ExecuteSql(connString: _connString,
                cmdText: _queryList.GetTableDescriptionQuery(schemaName: table.Schema, tableName: table.Name),
                map: x => (string) x[0]);

            if (tblDesc.Count > 0)
            {
                table.SetDescription(tblDesc[0]);
            }
            return table;
        }

        public Table GetAllColumnsAndDescriptionsForThisTable(Table table)
        {
            table.SetColumns(
                ExecuteSql(connString: _connString,
                cmdText: _queryList.GetColumnsAndDescriptionsQuery(schemaName: table.Schema, tableName: table.Name),
                map: x => new Column(name: (string) x[0], description: (string) x[1])
            ));
            
            return table;
        }

        private static List<T> ExecuteSql<T>(string connString, string cmdText, Func<DbDataReader, T> map)
        {
            var res = new List<T>();
            using (SqlConnection conn = new SqlConnection(connString))
            {

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmdText;

                    conn.Open();

                    try
                    {
                        using ( var result = cmd.ExecuteReader() )
                        {
                            while ( result.Read() )
                            {
                                res.Add(map(result));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString(), $"\n {cmd.CommandText}");
                    }
                    cmd.Dispose();
                    conn.Close();
                    conn.Dispose();
                }
            }
            return res;
        }



    }
}
