using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Blazored.LocalStorage;
using JwtDemo.Client.Helpers;
using JwtDemo.Share.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace JwtDemo.Client.Service
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _navigationManager;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           NavigationManager navigationManager,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
            _navigationManager = navigationManager;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await _httpClient.PostAsJsonAsync("api/accounts", registerModel);
            if (result.IsSuccessStatusCode)
                return new RegisterResult { Successful = true, Errors = null };
            return new RegisterResult { Successful = false, Errors = new List<string> { "Error occured" } };
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            #region Code New
            // HttpClient client = new HttpClient();
            // // Define the URL and JSON body data
            // string url = "https://localhost:7259/api/Login";
            // string jsonBody = "{\"email\": \"dolathanchuong@gmail.com\", \"password\": \"123aA!@#\", \"rememberMe\": false}";
            // StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            // HttpResponseMessage response = await client.PostAsync(url, content);
            // var loginResult = JsonSerializer.Deserialize<LoginResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            // // Check the response status and handle accordingly
            // if (response.IsSuccessStatusCode)
            // {
            //     string responseContent = await response.Content.ReadAsStringAsync();
            //     Console.WriteLine("Response content: " + responseContent);
            // }
            // else
            // {
            //     Console.WriteLine("Error: " + response.StatusCode + " - " + response.ReasonPhrase);
            //     return loginResult!;
            // }
            // client.Dispose();
            // return loginResult!;
            #endregion
            #region Code OLD
            var loginAsJson = JsonSerializer.Serialize(loginModel);
            var response = await _httpClient.PostAsync("api/Login", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
            var loginResult = JsonSerializer.Deserialize<LoginResult>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (!response.IsSuccessStatusCode)
            {
                return loginResult!;
            }

            await _localStorage.SetItemAsync("authToken", loginResult!.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email!);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);
            _navigationManager.NavigateTo("account/logout");
            return loginResult;
            #endregion
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
            _navigationManager.NavigateTo("account/login");
        }
    }
}