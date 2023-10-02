/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
        /// Returns new api key
        ///
        /// </summary>
        /// <param name="body">api key details</param>
        public async Task<AstroResult<ApiKeyDto>> Createsanapikeyforthecurrentuser(ApiKeyCreateDto body)
        {
            var url = $"/api/data/api-keys";
            return await _client.Request<ApiKeyDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Returns list of workspace&#39;s api keys
        ///
        /// </summary>
        public async Task<AstroResult<ApiKeyDto[]>> Returnslistofcreatedapikeysforcurrentworkspace()
        {
            var url = $"/api/data/api-keys";
            return await _client.Request<ApiKeyDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Revokes all api keys in given workspace
        ///
        /// </summary>
        public async Task<AstroResult<string>> Revokesallapikeys()
        {
            var url = $"/api/data/api-keys/revoke-all";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Revoke single api key in given workspace
        ///
        /// </summary>
        /// <param name="id">Internal key id</param>
        public async Task<AstroResult<string>> Revokesingleapikey(Guid id)
        {
            var url = $"/api/data/api-keys/{id}/revoke";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
