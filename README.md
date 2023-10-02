[![NuGet](https://img.shields.io/nuget/v/ProjectManager.Sdk.svg?style=plastic)](https://www.nuget.org/packages/ProjectManager.Sdk/)

# ProjectManager.com SDK for API v4

This software development kit contains all API definitions for the [ProjectManager.com](https://www.projectmanager.com) REST API v4.  

# Why use the SDK?

The ProjectManager API v4 is available as a REST definition in OpenAPI format.  You can read the documentation online at [softwaredeveloper.projectmanager.com](https://softwaredeveloper.projectmanager.com/v4/reference/api-reference).

This SDK provides a few capabilities that developers may find more useful than hand-writing REST API code:
* Documentation is available in your editor via autocomplete and hover docblocks
* Patch notes are available detailing changes
* Implements GZip encoding and HTTPS connection pooling
* Automated updates whenever new API endpoints are added

# Using this SDK

Here's how to add this SDK to create a project.

```powershell
dotnet add package ProjectManager.Sdk
```

To create an API client for ProjectManager, you must specify:
* Your API key, and
* Your environment URL.

For the ProjectManager production environment, the environment URL is `https://api.projectmanager.com`.

To [obtain a ProjectManager.com API key](https://softwaredeveloper.projectmanager.com/v4/reference/api-keys):
* Log on to ProjectManager.com
* Click your name in the bottom left hand corner
* Select Account, then API
* Follow the instructions on the page to create a new API key

```csharp
using System;
using ProjectManager.Sdk;

public class CSharpExample
{
    public static async ProjectManagerClient GetProjectManagerClient(string? apiKey, string? env)
    {
        return ProjectManagerClient
            .WithCustomEnvironment(env ?? Environment.GetEnvironmentVariable("PM_ENV"))
            .WithBearerToken(apiKey ?? Environment.GetEnvironmentVariable("PM_API_KEY"))
            .WithAppName("MyApplicationName");
    }
}
```

        
        
        
