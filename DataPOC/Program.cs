using DataPOC.Entities;
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
            string connStr = config.GetConnectionString("ConnectionString");
            QueryRepository qr = new QueryRepository(connectionString: config.GetConnectionString("ConnectionString"));
            List<Table> allTables = qr.GetAllTables();
            for (int i = 0; i < allTables.Count; i++)
            {
                allTables[i] = qr.GetTableDescription(allTables[i]);
                allTables[i] = qr.GetAllColumnsAndDescriptionsForThisTable(allTables[i]);
            }

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