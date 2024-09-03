/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ApiKey
    /// </summary>
    public class ApiKeyClient : IApiKeyClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiKeyClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates a new API key for the current user with the specified options.
        ///
        /// An API key is a credential that you can use to make REST v4 API calls for ProjectManager.com.  When you create
        /// a new API key, that API key is only visible in the response JSON for the `CreateApiKey` method.  If you do not
        /// preserve this information, it cannot be recreated.
        ///
        /// Some best practices for working with API keys:
        /// * An API key is valid for a two year period after it is created.  We encourage you to rotate your API keys
        /// regularly according to your company&#39;s security policies.
        /// * You should create separate API keys for each system that works with your API.  If that API key is exposed
        /// or if that program needs to be shut down, you can revoke that one key and reissue it.
        /// * An API key is tied to the workspace that created it. A single API key can only interact with one workspace.
        /// </summary>
        /// <param name="body">Options for the API key to create</param>
        public async Task<AstroResult<ApiKeyDto>> CreateApiKey(ApiKeyCreateDto body)
        {
            var url = $"/api/data/api-keys";
            return await _client.RequestWithBody<ApiKeyDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Returns a list of all API keys within the current workspace.
        ///
        /// An API key is a credential that you can use to make REST v4 API calls for ProjectManager.com.  When you create
        /// a new API key, that API key is only visible in the response JSON for the `CreateApiKey` method.  If you do not
        /// preserve this information, it cannot be recreated.
        ///
        /// Some best practices for working with API keys:
        /// * An API key is valid for a two year period after it is created.  We encourage you to rotate your API keys
        /// regularly according to your company&#39;s security policies.
        /// * You should create separate API keys for each system that works with your API.  If that API key is exposed
        /// or if that program needs to be shut down, you can revoke that one key and reissue it.
        /// * An API key is tied to the workspace that created it. A single API key can only interact with one workspace.
        /// </summary>
        public async Task<AstroResult<ApiKeyDto[]>> ListApiKeys()
        {
            var url = $"/api/data/api-keys";
            return await _client.Request<ApiKeyDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// This API call revokes all existing API keys in given workspace.  No existing keys will continue to work
        /// after this call completes.  We strongly encourage you to revoke a single API key at a time; this method
        /// should only be used if you need to rapidly halt access to your product for automated systems.
        ///
        /// An API key is a credential that you can use to make REST v4 API calls for ProjectManager.com.  When you create
        /// a new API key, that API key is only visible in the response JSON for the `CreateApiKey` method.  If you do not
        /// preserve this information, it cannot be recreated.
        ///
        /// Some best practices for working with API keys:
        /// * An API key is valid for a two year period after it is created.  We encourage you to rotate your API keys
        /// regularly according to your company&#39;s security policies.
        /// * You should create separate API keys for each system that works with your API.  If that API key is exposed
        /// or if that program needs to be shut down, you can revoke that one key and reissue it.
        /// * An API key is tied to the workspace that created it. A single API key can only interact with one workspace.
        /// </summary>
        public async Task<AstroResult<string>> RevokeAllApiKeys()
        {
            var url = $"/api/data/api-keys/revoke-all";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Revokes a single API key in the current workspace.
        ///
        /// An API key is a credential that you can use to make REST v4 API calls for ProjectManager.com.  When you create
        /// a new API key, that API key is only visible in the response JSON for the `CreateApiKey` method.  If you do not
        /// preserve this information, it cannot be recreated.
        ///
        /// Some best practices for working with API keys:
        /// * An API key is valid for a two year period after it is created.  We encourage you to rotate your API keys
        /// regularly according to your company&#39;s security policies.
        /// * You should create separate API keys for each system that works with your API.  If that API key is exposed
        /// or if that program needs to be shut down, you can revoke that one key and reissue it.
        /// * An API key is tied to the workspace that created it. A single API key can only interact with one workspace.
        /// </summary>
        /// <param name="id">The unique identifier of the API key to revoke</param>
        public async Task<AstroResult<string>> RevokeAPIKey(Guid id)
        {
            var url = $"/api/data/api-keys/{id}/revoke";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
