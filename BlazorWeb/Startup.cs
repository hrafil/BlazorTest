using BlazorWeb.Services;
using CurrieTechnologies.Razor.Clipboard;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWeb
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // NuGet balíèky
            services.AddClipboard();

            // Vlastní služby
            services.AddSingleton<IRandomGeneratorService, RandomGeneratorService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
