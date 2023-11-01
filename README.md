# |||||||||||||||||||||||||||||||||||||  JWTDemo
#                                        JWTDemo ===> blazorwasm.Login
* blazorwasm.Login
# **************************************_Backend_****************************
- ===
    - Helpers
        - AppRouteView.cs
        - ExtensionMethods.cs
        - FakeBackendHandler.cs
            - Reference links: https://bizflycloud.vn/tin-tuc/local-storage-la-gi-20210812234140935.htm
        - StringConverter.cs
    - Services
        - AccountService.cs
        - AlertService.cs
        - HttpService.cs
        - LocalStorageService.cs
# **************************************_Frontend_***************************
- Home Page:
    - Share
        - Alert.razor
        - MainLayout.razor
        - MainLayout.razor.css
        - NavMenu.razor
        - NavMenu.razor.css
        - SurveyPrompt.razor
- Page Details:
    - Pages
        - Account
            - _Imports.razor
            - Layout.razor
            - Login.razor
            - Logout.razor
            - Register.razor
        - Users
            - _Imports.razor
            - Add.razor
            - Edit.razor
            - Index.razor
            - Layout.razor
        - Counter.razor
        - FetchData.razor
        - Index.razor
# **************************************_Model_Local Storage_******************************
- ======
    - Models
        - Account
            - AddUser.cs
            - EditUser.cs
            - Login.cs
        - Alert.cs
        - User.cs
# **************************************_Config_*****************************
- =========
    - Properties
        - launchSettings.json
    - wwwroot
        - appsettings.json
    - App.razor
    - Program.cs
- +++ Package Install+++
    - example: dotnet add package Microsoft.AspNetCore.Authorization(PowerShell run cmd)
    - blazorwasm.Login.csproj
# End blazorwasm.Login
```
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
```

#                                        JWTDemo ===> JWTDemo.Client
* JWTDemo.Client
# **************************************_Backend_****************************
- ===
    - Helpers
        - ApiAuthenticationStateProvider.cs(Authentication : Login, Logout)
    - Service
        - AuthService.cs
        - IAuthService.cs
# **************************************_Frontend_***************************
- Home Page:
    - Share
        - MainLayout.razor
        - MainLayout.razor.css
        - NavMenu.razor
        - NavMenu.razor.css
        - SurveyPrompt.razor
- Page Details:
    - Pages
        - Counter.razor
        - FetchData.razor
        - Index.razor
        - Login.razor
        - LoginDisplay.razor
        - Logout.razor
        - Register.razor
# **************************************_Model_Local_*************************************
- ======
    - Call From JWTDemo.Server(API)
# **************************************_Config_*****************************
- =========
    - Handlers
        - CustomHttpHandler.cs
    - Properties
        - launchSettings.json
    - wwwroot
        - appsettings.Development.json
    - App.razor
    - Program.cs
    - +++ Package Install+++
    - example: dotnet add package Blazored.LocalStorage(PowerShell run cmd)
    - JWTDemo.Client.csproj
# Create Project JWTDemo.Client
```
    cmd: dotnet new blazorwasm -n JWTDemo.Client
```
#                                        JWTDemo ===> JWTDemo.Server
* JWTDemo.Server
# **************************************_Backend_****************************
- ===
    - Controllers
        - AccountsController.cs
        - LoginController.cs
        - WeatherForecastController.cs
# **************************************_Model_Local_*************************************
- ======
    - Data
        - Migrations : cmd(dotnet ef migrations add Initials -o Data/Migrations)
        - ApplicationDbContext.cs
# **************************************_Config_*****************************
- =========
    - Properties
        - launchSettings.json
    - appsettings.json
    - Program.cs
- +++ Package Install+++
    - example: dotnet add package Microsoft.AspNetCore.Authentication.jwtBearer(PowerShell run cmd)
    - JWTDemo.Server.csproj
# Create Project JWTDemo.Client
```
    cmd: dotnet new webapi -n JWTDemo.Server
```
#                                        JWTDemo ===> JWTDemo.Share
* JWTDemo.Share
# Create Project JWTDemo.Share
```
    cmd: dotnet new classlib -n JWTDemo.Share
```
# End JWTDemo
```
Note: Client And Server Call Class Model From Share
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
```

# |||||||||||||||||||||||||||||||||||||  BlazorAPIClient
# **************************************_Backend_****************************
- ===
    - DataServices
        - GraphQLSpaceXDataService.cs
        - ISpaceXDataService.cs
        - ITypicodeDataService.cs
        - RESTTypicodeDataService.cs
# **************************************_Model_Local_*************************************
- ======
    - Dtos
        - GqlData.cs
        - LaunchDto.cs
        - LaunchX.cs
# **************************************_Frontend_***************************
- Home Page:
    - Share
        - MainLayout.razor
        - MainLayout.razor.css
        - NavMenu.razor
        - NavMenu.razor.css
        - SurveyPrompt.razor
- Page Details:
    - Pages
        - Base64Converter.razor
        - Counter.razor
        - FetchData.razor
        - FetchDataAPI.cs
        - FetchDataAPI.razor
        - Index.razor
        - Launch.cs
        - Launch.razor
        - Launches.cs
        - Launches.razor
# **************************************_Config_*****************************
- =========
    - Properties
        - launchSettings.json
    - wwwroot
        - appsettings.Development.json
    - App.razor
    - Program.cs
- +++ Package Install+++
    - example: dotnet add package Microsoft.AspNetCore.Components.WebAssembly(PowerShell run cmd)
    - BlazorAPIClient.csproj
# End BlazorAPIClient
```
Note: Call API Test From :
- https://jsonplaceholder.typicode.com/todos (note: REST)
- https://spacex-production.up.railway.app/ (GraphQL API)
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
```