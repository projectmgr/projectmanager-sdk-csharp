using System.Text.Json;
using ProjectManager.SDK;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var client = ProjectManagerClient
            .WithCustomEnvironment("https://testapi.pmcom.io")
            .WithBearerToken(
                "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Ik5PZmlUbUNhREVSZXRsWkUyVkc5SiJ9.eyJidXNpbmVzc0lkIjoiZmE1MDJjYzItZjdjOS00NmNlLTg1ZWMtMmY4MDViOGE3ZGVkIiwiYnVzaW5lc3NVc2VySWQiOiI4OGZiZWI2MS1jNzI1LTRiNWYtOGYyMi01NDUxMjU0ZTZiMWUiLCJvcmdhbml6YXRpb25JZCI6Im9yZ19WZnhJTzFEaVBPaVQ2NThCIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoidHNwZW5jZUBwcm9qZWN0bWFuYWdlci5jb20iLCJpc3MiOiJodHRwczovL3Rlc3RpZGVudGl0eS5wbWNvbS5pby8iLCJzdWIiOiJnb29nbGUtb2F1dGgyfDExNjQyMTgzOTc3MDA1OTUxMzY3MiIsImF1ZCI6Imh0dHBzOi8vYXBpLnByb2plY3RtYW5hZ2VyLmNvbS9hcGkvcHVibGljIiwiaWF0IjoxNjg4NzcxNjM3LCJleHAiOjE2ODg3Nzg4MzcsImF6cCI6IjZxbU00WjZjUDFWTmEzUGEySHJhWkdGRzIyUnAzaEttIn0.SikkvthiN23SoFFONlxm5GSvtt7csuogTBM-SJDmwYSJXhLfHb07oUp9U9HPnO3xkHdUZPpLDMuKx8OZTy0Tao3hEMONjv0pfTcxv_qIzX6oTQhCMwAPrQjKgsc3WK63FbidsF10kvc7G7_mJj_YVeT5vZU454hgXS-BBWLVtfSCC8iwqyrJUgAFnKhx0L3JLUV5tYa3qzDfqXLN8REU23BPF6UU7LsOcRXqB95yK3LuGowCzTXVXjIHPpj8_KHcMGcD-K0_gcyE33EuqKlFc5frLaEdUTn2HaN1BVNHzDxGP2IpA13ki9ivu-9bqY2w6bjTypkgLHUrFwp2qzuNyA");
        var projects = await client.Project.QueryProjects();
        foreach (var project in projects.Data)
        {
            Console.WriteLine(JsonSerializer.Serialize(project));
        }
    }
}