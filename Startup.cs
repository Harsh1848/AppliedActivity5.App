using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace AppliedActivity5
{
    public class Startup : IStartup
    {
        public void Configure(IAppHostBuilder appBuilder)
        {
            appBuilder.ConfigureServices(services =>
            {
                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseSqlite($"Filename={App.DatabasePath}");
                });
            });

            appBuilder.UseMauiApp<App>();
        }
    }
}
