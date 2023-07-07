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
 * @version    11.1.1371
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
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK 
{
    /// <summary>
    /// A client object that connects to the ProjectManager API
    /// </summary>
    public class ProjectManagerClient
    {
        /// <summary>
        /// The version of the SDK
        /// </summary>
        public const string SdkVersion = "11.1.1371";
        
        private readonly string _apiUrl;
        private readonly HttpClient _client;
        internal readonly JsonSerializerOptions _options;
        
        private string _appName;
        private string _bearerToken;
        private string _apiKey;
    
        /// <summary>
        /// API methods related to Changeset
        /// </summary>
        public ChangesetClient Changeset { get; }

        /// <summary>
        /// API methods related to Discussion
        /// </summary>
        public DiscussionClient Discussion { get; }

        /// <summary>
        /// API methods related to Project
        /// </summary>
        public ProjectClient Project { get; }

        /// <summary>
        /// API methods related to ProjectChargeCode
        /// </summary>
        public ProjectChargeCodeClient ProjectChargeCode { get; }

        /// <summary>
        /// API methods related to ProjectCustomer
        /// </summary>
        public ProjectCustomerClient ProjectCustomer { get; }

        /// <summary>
        /// API methods related to ProjectField
        /// </summary>
        public ProjectFieldClient ProjectField { get; }

        /// <summary>
        /// API methods related to ProjectFolder
        /// </summary>
        public ProjectFolderClient ProjectFolder { get; }

        /// <summary>
        /// API methods related to ProjectPriority
        /// </summary>
        public ProjectPriorityClient ProjectPriority { get; }

        /// <summary>
        /// API methods related to ProjectStatus
        /// </summary>
        public ProjectStatusClient ProjectStatus { get; }

        /// <summary>
        /// API methods related to ProjectTemplate
        /// </summary>
        public ProjectTemplateClient ProjectTemplate { get; }

        /// <summary>
        /// API methods related to Resource
        /// </summary>
        public ResourceClient Resource { get; }

        /// <summary>
        /// API methods related to ResourceSkill
        /// </summary>
        public ResourceSkillClient ResourceSkill { get; }

        /// <summary>
        /// API methods related to ResourceTeam
        /// </summary>
        public ResourceTeamClient ResourceTeam { get; }

        /// <summary>
        /// API methods related to Tag
        /// </summary>
        public TagClient Tag { get; }

        /// <summary>
        /// API methods related to Task
        /// </summary>
        public TaskClient Task { get; }

        /// <summary>
        /// API methods related to TaskAssignee
        /// </summary>
        public TaskAssigneeClient TaskAssignee { get; }

        /// <summary>
        /// API methods related to TaskField
        /// </summary>
        public TaskFieldClient TaskField { get; }

        /// <summary>
        /// API methods related to TaskStatus
        /// </summary>
        public TaskStatusClient TaskStatus { get; }

        /// <summary>
        /// API methods related to TaskTag
        /// </summary>
        public TaskTagClient TaskTag { get; }


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
            Changeset = new ChangesetClient(this);
            Discussion = new DiscussionClient(this);
            Project = new ProjectClient(this);
            ProjectChargeCode = new ProjectChargeCodeClient(this);
            ProjectCustomer = new ProjectCustomerClient(this);
            ProjectField = new ProjectFieldClient(this);
            ProjectFolder = new ProjectFolderClient(this);
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
            TaskStatus = new TaskStatusClient(this);
            TaskTag = new TaskTagClient(this);
                
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
                    return new ProjectManagerClient("api.projectmanager.com", clientHandler);
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
                var bytesFile = File.ReadAllBytes(filename);
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
                    // Handle file downloads
                    if (typeof(T) == typeof(byte[]))
                    {
                        result.FileData = await response.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        // Successful API responses can be very large, so let's stream them
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            var newResult = await JsonSerializer.DeserializeAsync<AstroResult<T>>(stream, _options);
                            result.Data = newResult.Data;
                        }
                    }
                }
                else
                {
                    // Error responses tend to be very short, and issues such as proxy errors
                    // or "server down" can fail to provide valid JSON in the response.  If
                    // we fail to parse the response as JSON, just create a simulated error
                    // object with as much information as is available.
                    result.ParseError(this, response.StatusCode, await response.Content.ReadAsStringAsync());
                }

                // Calculate length of time it took including JSON processing
                sw.Stop();
                result.TotalRoundtrip = sw.ElapsedMilliseconds;
                return result;
            }
        }
    }
}