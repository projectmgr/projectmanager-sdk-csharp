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

        public async Task<AstroResult<IntegrationDto>> UnknownName(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Enable an integration and provision the provider to the workspace
        ///
        /// </summary>
        /// <param name="integrationId">A reference to the integration to be enabled</param>
        public async Task<AstroResult<IntegrationDto>> EnableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Enable an integration and provision the provider to the workspace
        ///
        /// </summary>
        /// <param name="integrationId">A reference to the integration to be enabled</param>
        public async Task<AstroResult<string>> EnableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        public async Task<AstroResult<IntegrationDto[]>> UnknownName()
        {
            var url = $"/api/data/integrations";
            return await _client.Request<IntegrationDto[]>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<IntegrationProviderDto[]>> UnknownName()
        {
            var url = $"/api/data/integrations/providers";
            return await _client.Request<IntegrationProviderDto[]>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<DirectLinkDto>> UnknownName(Guid providerId)
        {
            var url = $"/api/data/integrations/{providerId}/auth";
            return await _client.Request<DirectLinkDto>(HttpMethod.Post, url, null, null, null);
        }

        public async Task<AstroResult<IntegrationCategoryDto[]>> UnknownName()
        {
            var url = $"/api/data/integrations/categories";
            return await _client.Request<IntegrationCategoryDto[]>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<NewIntegrationInstanceDto>> Addsinstancetoworkspaceintegration(Guid integrationId, CreateIntegrationInstanceDto body)
        {
            var url = $"/api/data/integrations/{integrationId}/instance";
            return await _client.Request<NewIntegrationInstanceDto>(HttpMethod.Post, url, null, body, null);
        }

        public async Task<AstroResult<string>> Removesinstancefromworkspaceintegration(Guid integrationInstanceId)
        {
            var url = $"/api/data/integrations/instances/{integrationInstanceId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
