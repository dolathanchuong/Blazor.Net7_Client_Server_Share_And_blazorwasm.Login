using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using JwtDemo.Client.Helpers;
using JwtDemo.Client.Service;
using JWTDemo.Client;
using JWTDemo.Handles;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
// builder.Services.AddScoped<IAuthService, AuthService>();
// builder.Services.AddHttpClient("MyApi", options =>
// {
//     options.BaseAddress = new Uri("https://localhost:7259/");
// }).AddHttpMessageHandler<CustomHttpHandler>();

// builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddHttpClient<IAuthService, AuthService>(
    au => au.BaseAddress = new Uri(builder.Configuration["api_base_url"]!)
);
builder.Services.AddHttpClient<AuthenticationStateProvider, ApiAuthenticationStateProvider>(
    api => api.BaseAddress = new Uri(builder.Configuration["api_base_url"]!)
);
// builder.Services.AddScoped<CustomHttpHandler>();
await builder.Build().RunAsync();
