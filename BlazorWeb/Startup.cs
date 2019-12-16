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
            // NuGet bal��ky
            services.AddClipboard();

            // Vlastn� slu�by
            services.AddSingleton<IRandomGeneratorService, RandomGeneratorService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
