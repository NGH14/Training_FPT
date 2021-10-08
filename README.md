# FPT INTERAL TRAINING SYSTEM

ASP.NET Core 3.1 project from FPT TRAINING SYSTEM PROJECT
Technologies

    ASP.NET Core 3.1
    Entity Framework Core 3.1

Install Tools

    .NET Core SDK 3.1
    Git client
    Visual Studio 2019
    SQL Server 2019

How to configure and run

    Clone code from Github: git clone 
    Open solution FPT_Training.sln in Visual Studio 2019
    Set startup project is FPT_Training.Data
    Change connection string in Appsetting.json in FPT_Training.Data project
    Open Tools --> 
          Nuget Package Manager --> 
                      Package Manager Console in Visual Studio
    Run Update-database and Enter.
    After migrate database successful, set Startup Project is FPT_Training.WebApp
    Change database connection in appsettings.Development.json in FPT_Training.WebApp project.
    You need to change 3 projects to self-host profile.
    Set multiple run project: Right click to Solution and choose Properties and set Multiple Project, choose Start for 3 Projects: BackendApi, WebApp and AdminApp.
    Choose profile to run or press F5
