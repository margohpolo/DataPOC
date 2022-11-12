using DataPOC.Entities;
using DataPOC.Helpers.OutputHelpers;
using DataPOC.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataPOC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            StartupAndSetup(config);
            QueryRepository qr = new QueryRepository(connectionString: config.GetConnectionString("ConnectionString"));
            TableCollection tableCollection = new TableCollection(dbName: "dbName", dateTime: DateTime.Now, tables: qr.GetAllTables());
            for (int i = 0; i < tableCollection.Tables.Count; i++)
            {
                tableCollection.Tables[i] = qr.GetTableDescription(tableCollection.Tables[i]);
                tableCollection.Tables[i] = qr.GetColumnAttributesForThisTable(tableCollection.Tables[i]);
                tableCollection.Tables[i] = qr.GetColumnDescriptionsForThisTable(tableCollection.Tables[i]);
            }
            string convToJson = JsonOutput.TableCollectionToJson(tableCollection);
            Console.WriteLine(convToJson);

        }

        public static void StartupAndSetup(IConfiguration cfig)
        {
            IServiceCollection services = new ServiceCollection();

            Startup startUp = new Startup(cfig);
            startUp.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();
        }
    }
}