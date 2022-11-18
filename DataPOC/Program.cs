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

            OutputBuilder outputBuilder = new OutputBuilder(config);
            outputBuilder.RunAll();

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