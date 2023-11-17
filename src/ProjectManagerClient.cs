/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 *             
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @version    98.0.2363
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using ProjectManager.SDK.Clients;
using ProjectManager.SDK.Interfaces;


namespace ProjectManager.SDK 
{
    /// <summary>
    /// A client object that connects to the ProjectManager API
    /// </summary>
    public class ProjectManagerClient : IProjectManagerClient
    {
        /// <summary>
        /// The version of the SDK
        /// </summary>
        public const string SdkVersion = "98.0.2363";
        
        private readonly string _apiUrl;
        private readonly HttpClient _client;
        internal readonly JsonSerializerOptions _options;
        
        private string _appName;
        private string _bearerToken;
        private string _apiKey;
    
        /// <summary>
        /// API methods related to ApiKey
        /// </summary>
        public IApiKeyClient ApiKey { get; }

        /// <summary>
        /// API methods related to Changeset
        /// </summary>
        public IChangesetClient Changeset { get; }

        /// <summary>
        /// API methods related to Dashboard
        /// </summary>
        public IDashboardClient Dashboard { get; }

        /// <summary>
        /// API methods related to Discussion
        /// </summary>
        public IDiscussionClient Discussion { get; }

        /// <summary>
        /// API methods related to File
        /// </summary>
        public IFileClient File { get; }

        /// <summary>
        /// API methods related to HomeFile
        /// </summary>
        public IHomeFileClient HomeFile { get; }

        /// <summary>
        /// API methods related to Integration
        /// </summary>
        public IIntegrationClient Integration { get; }

        /// <summary>
        /// API methods related to IntegrationCategory
        /// </summary>
        public IIntegrationCategoryClient IntegrationCategory { get; }

        /// <summary>
        /// API methods related to IntegrationProvider
        /// </summary>
        public IIntegrationProviderClient IntegrationProvider { get; }

        /// <summary>
        /// API methods related to License
        /// </summary>
        public ILicenseClient License { get; }

        /// <summary>
        /// API methods related to Me
        /// </summary>
        public IMeClient Me { get; }

        /// <summary>
        /// API methods related to Project
        /// </summary>
        public IProjectClient Project { get; }

        /// <summary>
        /// API methods related to ProjectChargeCode
        /// </summary>
        public IProjectChargeCodeClient ProjectChargeCode { get; }

        /// <summary>
        /// API methods related to ProjectCustomer
        /// </summary>
        public IProjectCustomerClient ProjectCustomer { get; }

        /// <summary>
        /// API methods related to ProjectField
        /// </summary>
        public IProjectFieldClient ProjectField { get; }

        /// <summary>
        /// API methods related to ProjectFile
        /// </summary>
        public IProjectFileClient ProjectFile { get; }

        /// <summary>
        /// API methods related to ProjectFolder
        /// </summary>
        public IProjectFolderClient ProjectFolder { get; }

        /// <summary>
        /// API methods related to ProjectMembers
        /// </summary>
        public IProjectMembersClient ProjectMembers { get; }

        /// <summary>
        /// API methods related to ProjectPriority
        /// </summary>
        public IProjectPriorityClient ProjectPriority { get; }

        /// <summary>
        /// API methods related to ProjectStatus
        /// </summary>
        public IProjectStatusClient ProjectStatus { get; }

        /// <summary>
        /// API methods related to ProjectTemplate
        /// </summary>
        public IProjectTemplateClient ProjectTemplate { get; }

        /// <summary>
        /// API methods related to Resource
        /// </summary>
        public IResourceClient Resource { get; }

        /// <summary>
        /// API methods related to ResourceSkill
        /// </summary>
        public IResourceSkillClient ResourceSkill { get; }

        /// <summary>
        /// API methods related to ResourceTeam
        /// </summary>
        public IResourceTeamClient ResourceTeam { get; }

        /// <summary>
        /// API methods related to Tag
        /// </summary>
        public ITagClient Tag { get; }

        /// <summary>
        /// API methods related to Task
        /// </summary>
        public ITaskClient Task { get; }

        /// <summary>
        /// API methods related to TaskAssignee
        /// </summary>
        public ITaskAssigneeClient TaskAssignee { get; }

        /// <summary>
        /// API methods related to TaskField
        /// </summary>
        public ITaskFieldClient TaskField { get; }

        /// <summary>
        /// API methods related to TaskFile
        /// </summary>
        public ITaskFileClient TaskFile { get; }

        /// <summary>
        /// API methods related to TaskStatus
        /// </summary>
        public ITaskStatusClient TaskStatus { get; }

        /// <summary>
        /// API methods related to TaskTag
        /// </summary>
        public ITaskTagClient TaskTag { get; }

        /// <summary>
        /// API methods related to Timesheet
        /// </summary>
        public ITimesheetClient Timesheet { get; }

        /// <summary>
        /// API methods related to UserRole
        /// </summary>
        public IUserRoleClient UserRole { get; }

        /// <summary>
        /// API methods related to WorkSpace
        /// </summary>
        public IWorkSpaceClient WorkSpace { get; }


        /// <summary>
        /// Internal constructor for the client. You should always begin with `WithEnvironment()` or `WithCustomEnvironment`.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="clientHandler">Handler for the HTTP client, when null the default handler will be used</param>
        private ProjectManagerClient(string url, HttpClientHandler clientHandler)
        {
            // Add support for HTTP compression
            var handler = clientHandler ?? new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip;
            
            // We intentionally use a single HttpClient object for the lifetime of this API connection.
            // Best practices: https://bytedev.medium.com/net-core-httpclient-best-practices-4c1b20e32c6
            _client = new HttpClient(handler);
            
            _apiUrl = url;
            ApiKey = new ApiKeyClient(this);
            Changeset = new ChangesetClient(this);
            Dashboard = new DashboardClient(this);
            Discussion = new DiscussionClient(this);
            File = new FileClient(this);
            HomeFile = new HomeFileClient(this);
            Integration = new IntegrationClient(this);
            IntegrationCategory = new IntegrationCategoryClient(this);
            IntegrationProvider = new IntegrationProviderClient(this);
            License = new LicenseClient(this);
            Me = new MeClient(this);
            Project = new ProjectClient(this);
            ProjectChargeCode = new ProjectChargeCodeClient(this);
            ProjectCustomer = new ProjectCustomerClient(this);
            ProjectField = new ProjectFieldClient(this);
            ProjectFile = new ProjectFileClient(this);
            ProjectFolder = new ProjectFolderClient(this);
            ProjectMembers = new ProjectMembersClient(this);
            ProjectPriority = new ProjectPriorityClient(this);
            ProjectStatus = new ProjectStatusClient(this);
            ProjectTemplate = new ProjectTemplateClient(this);
            Resource = new ResourceClient(this);
            ResourceSkill = new ResourceSkillClient(this);
            ResourceTeam = new ResourceTeamClient(this);
            Tag = new TagClient(this);
            Task = new TaskClient(this);
            TaskAssignee = new TaskAssigneeClient(this);
            TaskField = new TaskFieldClient(this);
            TaskFile = new TaskFileClient(this);
            TaskStatus = new TaskStatusClient(this);
            TaskTag = new TaskTagClient(this);
            Timesheet = new TimesheetClient(this);
            UserRole = new UserRoleClient(this);
            WorkSpace = new WorkSpaceClient(this);
                
            // Configure JSON serializer options
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, 
            };
        }
    
        /// <summary>
        /// Construct a new API client to target the specific environment.
        /// </summary>
        /// <param name="env">The environment to use, either "prd" for production or "sbx" for sandbox.</param>
        /// <param name="clientHandler">Optional handler for the HTTP client</param>
        /// <returns>The API client to use</returns>
        public static ProjectManagerClient WithEnvironment(string env, HttpClientHandler clientHandler = null)
        {
            switch (env)
            {
                case "production":
                    return new ProjectManagerClient("https://api.projectmanager.com", clientHandler);
            }
    
            throw new InvalidOperationException($"Unknown environment: {env}");
        }
    
        /// <summary>
        /// Construct a client that uses a non-standard environment; this can be necessary when using proxy servers or
        /// an API gateway.  Please be careful when using this mode.
        /// You should prefer to use `WithEnvironment()` instead wherever possible.
        /// </summary>
        /// <param name="url">The custom URL to use for this client</param>
        /// <param name="clientHandler">Optional handler to set specific settings for the HTTP client</param>
        /// <returns>The API client to use</returns>
        public static ProjectManagerClient WithCustomEnvironment(string url, HttpClientHandler clientHandler = null)
        {
            return new ProjectManagerClient(url, clientHandler);
        }
        
        /// <summary>
        /// Set the application name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ProjectManagerClient WithAppName(string name)
        {
            _appName = name;
            return this;
        }
    
        /// <summary>
        /// Configure this API client to use a JWT bearer token.
        ///
        /// 
        /// </summary>
        /// <param name="token">The JWT bearer token to use for this API session</param>
        /// <returns></returns>
        public ProjectManagerClient WithBearerToken(string token)
        {
            _bearerToken = token;
            _apiKey = null;
            return this;
        }
    
        /// <summary>
        /// Configures this API client to use an API Key.
        ///
        /// 
        /// </summary>
        /// <param name="apiKey">The API key to use for this API session</param>
        /// <returns></returns>
        public ProjectManagerClient WithApiKey(string apiKey)
        {
            _apiKey = apiKey;
            _bearerToken = null;
            return this;
        }
    
        /// <summary>
        /// Make a request using this API client
        /// </summary>
        /// <param name="method">The HTTP method to send</param>
        /// <param name="path">The URL path fragment relative to this environment</param>
        /// <param name="query">The list of parameters and options to send</param>
        /// <param name="body">The request body to send</param>
        /// <param name="filename">The filename of a file attachment to upload</param>
        /// <typeparam name="T">The type of the expected response</typeparam>
        /// <returns>The response object including success/failure codes and error messages as appropriate</returns>
        public async Task<AstroResult<T>> Request<T>(HttpMethod method, string path,
            Dictionary<string, object> query, object body, string filename) where T: class
        {
            var sw = new Stopwatch();
            sw.Start();
            var request = new HttpRequestMessage();
            request.Method = method;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("SdkName", "DotNet");
            request.Headers.Add("SdkVersion", SdkVersion);
            request.Headers.Add("MachineName", Environment.MachineName);
            if (_appName != null)
            {
                request.Headers.Add("ApplicationName", _appName);
            }
    
            // Add authentication headers, if any
            if (!string.IsNullOrWhiteSpace(_bearerToken))
            {
                request.Headers.Add("Authorization", "Bearer " + _bearerToken);
            }
            else if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                request.Headers.Add("Api-Key", _apiKey);
            }
    
            // Construct the request URI and query string
            var uriBuilder = new UriBuilder(_apiUrl)
            {
                Path = path
            };
            var sb = new StringBuilder();
            if (query != null)
            {
                foreach (var kvp in query)
                {
                    if (kvp.Value != null)
                    {
                        sb.Append($"{kvp.Key}={HttpUtility.UrlEncode(kvp.Value.ToString())}&");
                    }
                }
            }
            uriBuilder.Query = sb.ToString();
            request.RequestUri = uriBuilder.Uri;
    
            // Add request body content, if any
            if (body != null)
            {
                var content = JsonSerializer.Serialize(body, _options);
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");
            }
            else if (filename != null)
            {
                var bytesFile = System.IO.File.ReadAllBytes(filename);
                var fileContent = new ByteArrayContent(bytesFile);
                var form = new MultipartFormDataContent(Guid.NewGuid().ToString());
                form.Add(fileContent, "file", Path.GetFileName(filename));
                request.Content = form;
            }
            
            // Send the request and convert the response into a success or failure
            using (var response = await _client.SendAsync(request))
            {
                var result = new AstroResult<T>
                {
                    Success = response.IsSuccessStatusCode,
                    Status = response.StatusCode,
                };
                if (response.Headers.TryGetValues("Server-Duration", out var durations))
                {
                    var durationStr = durations.FirstOrDefault();
                    if (int.TryParse(durationStr, out var duration))
                    {
                        result.ServerDuration = duration;
                    }
                }
                if (result.Success)
                {
                    await result.ParseSuccess(this, response);
                }
                else
                {
                    await result.ParseError(this, response);
                }

                // Calculate length of time it took including JSON processing
                sw.Stop();
                result.TotalRoundtrip = sw.ElapsedMilliseconds;
                return result;
            }
        }
    }
}