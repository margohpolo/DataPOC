using DataPOC.Entities;
using DataPOC.Helpers;
using DataPOC.Helpers.OutputHelpers.Excel;
using DataPOC.Helpers.OutputHelpers.Json;
using DataPOC.Helpers.OutputHelpers.Markdown.Templates;
using DataPOC.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace DataPOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //config setup
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            StartupAndSetup(config);

            //create output folders
            CreateOutputFolders(config);

            //get data from db
            TableCollection tableCollection = GetDataFromDb(config);

            //create json output file from data
            string convToJson = JsonOutput.TableCollectionToJson(tableCollection);
            //Console.WriteLine(convToJson);
            FileWriter.WriteNewJsonFile(dbName: "WideWorldImporters", dataJson: convToJson);

            //create markdown data dictionaries
            Dictionary<string, string> dataDict = DataDictionary.DataDictionaryTemplate(tableCollection);
            FileWriter.WriteNewMarkdownDocs(dataDict);

            ////create excel file
            FileWriter.WriteNewExcelFile(
                dbName: "WideWorldImporters",
                xlDict: ExcelOutput.ExcelDataDict(tableCollection)
                );


        }

        public static void StartupAndSetup(IConfiguration cfig)
        {
            IServiceCollection services = new ServiceCollection();

            Startup startUp = new Startup(cfig);
            startUp.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();
        }

        public static void CreateOutputFolders(IConfiguration cfig)
        {
            IConfigurationSection sec = cfig.GetSection("OutputFolders");
            List<string> folderList = new List<string>();
            folderList.Add(sec.GetSection("ParentFolder").Value);
            folderList.Add(sec.GetSection("ParentFolder").Value + sec.GetSection("JsonOutputFolder").Value);
            folderList.Add(sec.GetSection("ParentFolder").Value + sec.GetSection("MarkdownOutputFolder").Value);
            folderList.Add(sec.GetSection("ParentFolder").Value + sec.GetSection("ExcelOutputFolder").Value);
            foreach ( string item in folderList )
            {
                if ( !Directory.Exists(Path.GetDirectoryName(item)) )
                {
                    Console.WriteLine($"{item} folder does not exist. Creating folder now...");

                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(item));
                    }
                    catch ( Exception ex )
                    {
                        Console.WriteLine(ex.Message, $"\n Unable to create Directory {item}");
                    }

                    Console.WriteLine($"{item} folder created.");
                }
                else
                {
                    Console.WriteLine($"{item} folder exists. No need to re-create.");
                }
            }
        }

        public static TableCollection GetDataFromDb(IConfiguration cfig)
        {
            QueryRepository qr = new QueryRepository(connectionString: cfig.GetConnectionString("ConnectionString"));
            TableCollection tblCollection = new TableCollection(dbName: "dbName", dateTime: DateTime.Now, tables: qr.GetAllTables());
            for ( int i = 0; i < tblCollection.Tables.Count; i++ )
            {
                tblCollection.Tables[i] = qr.GetTableDescription(tblCollection.Tables[i]);
                tblCollection.Tables[i] = qr.GetColumnAttributesForThisTable(tblCollection.Tables[i]);
                tblCollection.Tables[i] = qr.GetColumnDescriptionsForThisTable(tblCollection.Tables[i]);
            }

            return tblCollection;
        }

    }
}