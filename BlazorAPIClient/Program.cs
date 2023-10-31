using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorAPIClient;
using BlazorAPIClient.DataServices;

Console.WriteLine("BlazorAPIClient has started...");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]!) });

builder.Services.AddHttpClient<ITypicodeDataService, RESTTypicodeDataService>(
    stcds => stcds.BaseAddress = new Uri(builder.Configuration["api_base_url"]!)
);

builder.Services.AddHttpClient<ISpaceXDataService, GraphQLSpaceXDataService>(
    stcds => stcds.BaseAddress = new Uri(builder.Configuration["api_base_url_GraphQL"]!)
);

await builder.Build().RunAsync();
