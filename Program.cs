using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Startup;

namespace primeiroprojetoMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartupConfig>();
                    webBuilder.UseKestrel();
                    webBuilder.UseIISIntegration();
                });
    }
}
