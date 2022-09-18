using DemoAzureFunctionsWithDI.Demos;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(DemoAzureFunctionsWithDI.Startup))]

namespace DemoAzureFunctionsWithDI;

internal class Startup : FunctionsStartup
{
    public override void Configure(IFunctionsHostBuilder builder)
    {
        // データベース接続先を切り替えます
        builder.Services.AddScoped<IDemoRepository, AzureTableDemoRepository>();
        //builder.Services.AddScoped<IDemoRepository, SqldatabaseDemoRepository>();
    }
}
