using System.Text.Json;
using ProjectManager.SDK;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var client = ProjectManagerClient
            .WithCustomEnvironment("https://testapi.pmcom.io")
            //.WithBearerToken(
                "");
        var projects = await client.Project.QueryProjects();
        foreach (var project in projects.Data)
        {
            Console.WriteLine(JsonSerializer.Serialize(project));
        }
    }
}