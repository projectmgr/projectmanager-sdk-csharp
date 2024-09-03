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
    /// API methods related to Integration
    /// </summary>
    public class IntegrationClient : IIntegrationClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public IntegrationClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves an Integration specified by a unique identifier.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please
        /// contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="integrationId">The unique identifier of this Integration</param>
        public async Task<AstroResult<IntegrationDto>> RetrieveIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Enable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please
        /// contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to enable</param>
        public async Task<AstroResult<IntegrationDto>> EnableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Post, url, null);
        }

        /// <summary>
        /// Disable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please
        /// contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to disable</param>
        public async Task<AstroResult<string>> DisableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Retrieves all Integrations for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please
        /// contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        public async Task<AstroResult<IntegrationDto[]>> RetrieveAllIntegrations()
        {
            var url = $"/api/data/integrations";
            return await _client.Request<IntegrationDto[]>(HttpMethod.Get, url, null);
        }
    }
}
