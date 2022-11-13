using DataPOC.Entities;
using DataPOC.Helpers;
using DataPOC.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
                map: x => new Table(schema: NullHelper.ValueFromDB(x[0]), name: NullHelper.ValueFromDB(x[1]))
                );
        }

        public Table GetTableDescription(Table table)
        {
            List<string> tblDesc = ExecuteSql(connString: _connString,
                cmdText: _queryList.GetTableDescriptionQuery(schemaName: table.Schema, tableName: table.Name),
                map: x => NullHelper.ValueFromDB(x[0]));

            if (tblDesc.Count > 0)
            {
                table.SetDescription(tblDesc[0]);
            }
            return table;
        }

        public Table GetColumnAttributesForThisTable(Table table)
        {
            List<Column> cols = ExecuteSql(connString: _connString,
                cmdText: _queryList.GetColumnAttributesForThisTableQuery(schemaName: table.Schema, tableName: table.Name),
                map: x =>
                {
                    Column newCol = new Column(name: NullHelper.ValueFromDB(x[0]));
                    newCol.SetAttributes(new ColumnAttributes(
                            columnDefault: NullHelper.ValueFromDB(x[1]), isNullable: NullHelper.ValueFromDB(x[2]), dataType: NullHelper.ValueFromDB(x[3]),
                            charMaxLength: NullHelper.ValueFromDB(x[4]), charDataLength: NullHelper.ValueFromDB(x[5]), 
                            numericPrecision: NullHelper.ValueFromDB(x[6]), numericScale: NullHelper.ValueFromDB(x[7]), 
                            datetimePrescision: NullHelper.ValueFromDB(x[8]), charSetName: NullHelper.ValueFromDB(x[9]), 
                            collationName: NullHelper.ValueFromDB(x[10])
                        ));
                    return newCol;
                });

            table.SetColumns(cols);

            return table;
        }

        public Table GetColumnDescriptionsForThisTable(Table table)
        {
            List<Column> columns = ExecuteSql(connString: _connString,
                cmdText: _queryList.GetColumnDescriptionsForThisTableQuery(schemaName: table.Schema, tableName: table.Name),
                map: x => new Column(name: NullHelper.ValueFromDB(x[0]), description: NullHelper.ValueFromDB(x[1]))
                );

            table.SetColumnDescriptions(columns);

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
