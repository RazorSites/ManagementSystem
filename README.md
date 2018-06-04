# ManagementSystem

## Getting Started

Requirements:
- MS SQL Server 2014+
- A Web Server (IIS, Apache, etc.) - For deployment and production
- Visual Studio 2017+ - For development

Steps for local build and development:
1. Nagivate to `ManagementSystem/ManagementSystem/ManagementSystem.Web/`, open appsettings.json and edit Connection to match your local SQL server.
2. Navigate to `ManagementSystem/ManagementSystem/`, where you can locate `ManagementSystem.sln`
3. Run database migration script as following:
```
dotnet ef migrations update
```
4. Open the project in Visual Studio 2017+, you're good to go!


