* CMD Create New WebAPI project :
    - dotnet new webapi -n JWTDemo.Server
* Config ConnectionString SQLServer:
    - JWTDemo.Server
        - appsettings.json
            - Code OLD:
            ```
                -   {
                        "Logging": {
                        "LogLevel": {
                            "Default": "Information",
                            "Microsoft.AspNetCore": "Warning"
                            }
                        },
                        "AllowedHosts": "*"
                    }
            ```
            - Code New:
            ```
                - {
                    "ConnectionStrings": {
                        "DefaultConnection": "Server=LAPTOP-H3UVPUPJ\\SQLEXPRESS;Database=JWTDemo; Trusted_Connection=True; TrustServerCertificate=true;"
                    },
                    "JwtSecurityKey": "RANDOM_KEY_MUST_NOT_BE_SHARED",
                    "JwtIssuer": "https://localhost",
                    "JwtAudience": "https://localhost",
                    "JwtExpiryInDays": 1,
                    "Logging": {
                        "LogLevel": {
                        "Default": "Information",
                        "Microsoft.AspNetCore": "Warning"
                        }
                    },
                    "AllowedHosts": "*"
                }
            ```
* CMD Migration DB from source to DB SQlServer:
    - Note(you execute : "dotnet tool update --global dotnet-ef" or "dotnet restore" ==> if you not migrations)
    - dotnet ef migrations add Initials -o Data/Migrations
    - dotnet ef database update
* Find Port Running And Kill it:
    - netstat -ano | findstr :5140 -->Find port
    - taskkill /F /PID 17844 --Kill Port
* Swagger API link (http://localhost:5140/Swagger/index.html)