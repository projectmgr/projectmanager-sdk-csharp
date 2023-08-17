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

        /// <summary>
        /// Configure the WorkSpace for integrations
        ///
        /// </summary>
        public async Task<AstroResult<IntegrationSetupResponseDto>> SetupWorkSpaceforIntegrations()
        {
            var url = $"/api/data/integrations/setup";
            return await _client.Request<IntegrationSetupResponseDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Retrieves an Integration specified by a unique identifier.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of this Integration</param>
        public async Task<AstroResult<IntegrationDto>> RetrieveIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Enable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to enable</param>
        public async Task<AstroResult<IntegrationDto>> EnableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<IntegrationDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Disable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to disable</param>
        public async Task<AstroResult<string>> DisableIntegration(Guid integrationId)
        {
            var url = $"/api/data/integrations/{integrationId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Retrieves all Integrations for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        public async Task<AstroResult<IntegrationDto[]>> RetrieveAllIntegrations()
        {
            var url = $"/api/data/integrations";
            return await _client.Request<IntegrationDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// List all available IntegrationProviders that can be activated.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        public async Task<AstroResult<IntegrationProviderDto[]>> ListProviders()
        {
            var url = $"/api/data/integrations/providers";
            return await _client.Request<IntegrationProviderDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves authentication information about a specific IntegrationProvider.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        public async Task<AstroResult<DirectLinkDto>> RetrieveProviderAuthentication(Guid providerId)
        {
            var url = $"/api/data/integrations/{providerId}/auth";
            return await _client.Request<DirectLinkDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Allows you to update the auth status of the main project manager connection.
        ///
        /// </summary>
        /// <param name="providerId">the identifier to the provider</param>
        /// <param name="body">Specify the auth status</param>
        public async Task<AstroResult<string>> UpdateIntegrationProviderauthstatus(Guid providerId, AuthenticationStatusDto body)
        {
            var url = $"/api/data/integrations/{providerId}/auth";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Allows you to update the auth status of the main project manager connection.
        ///
        /// </summary>
        /// <param name="body">Specify the auth status</param>
        public async Task<AstroResult<string>> UpdateAuthStatusforprojectmanagerintegrationtoAPI(AuthenticationStatusDto body)
        {
            var url = $"/api/data/integrations/project-manager/auth";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Retrieves the list of available IntegrationProvider categories.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        public async Task<AstroResult<IntegrationCategoryDto[]>> RetrieveProviderCategories()
        {
            var url = $"/api/data/integrations/categories";
            return await _client.Request<IntegrationCategoryDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Adds a new Integration instance to a Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to add to this Workspace</param>
        /// <param name="body">The information about this Integration to add</param>
        public async Task<AstroResult<NewIntegrationInstanceDto>> AddIntegrationInstance(Guid integrationId, CreateIntegrationInstanceDto body)
        {
            var url = $"/api/data/integrations/{integrationId}/instance";
            return await _client.Request<NewIntegrationInstanceDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Removes an existing Integration instance from a Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationInstanceId">The unique identifier of the IntegrationInstance to remove from this Workspace</param>
        public async Task<AstroResult<string>> RemoveIntegrationInstance(Guid integrationInstanceId)
        {
            var url = $"/api/data/integrations/instances/{integrationInstanceId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
