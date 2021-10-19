using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using Serilog;
using Serilog.Events;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigureLogger();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void ConfigureLogger()
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .Enrich.FromLogContext()
            .WriteTo.Seq("http://localhost:5341")
            .WriteTo.RollingFile(
                pathFormat: Path.Combine(@$"{Directory.GetCurrentDirectory()}\..\Logs\info-logs.txt"),
                restrictedToMinimumLevel: LogEventLevel.Information)
            .WriteTo.RollingFile(
                pathFormat: Path.Combine(@$"{Directory.GetCurrentDirectory()}\..\Logs\error-logs.txt"),
                restrictedToMinimumLevel: LogEventLevel.Error)
            .CreateLogger();
        }
    }
}
