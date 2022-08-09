using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Unity;

namespace RestApiFavoriteContact.API
{
    public class Program
    {
        internal static readonly IUnityContainer Container = new UnityContainer();

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
