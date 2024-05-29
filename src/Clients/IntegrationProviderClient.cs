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
    /// API methods related to IntegrationProvider
    /// </summary>
    public class IntegrationProviderClient : IIntegrationProviderClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public IntegrationProviderClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// List all available IntegrationProviders that can be activated.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        public async Task<AstroResult<IntegrationProviderDto[]>> ListProviders()
        {
            var url = $"/api/data/integrations/providers";
            return await _client.Request<IntegrationProviderDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Activates an Integration Provider and retrieves authentication information about a specific IntegrationProvider.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        public async Task<AstroResult<ConnectionSchemaDto>> ActivateIntegrationProvider(Guid providerId)
        {
            var url = $"/api/data/integrations/providers/{providerId}";
            return await _client.Request<ConnectionSchemaDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Allows you to update the auth status of the provider specific connection.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        /// <param name="body">Specify the auth status</param>
        public async Task<AstroResult<string>> UpdateIntegrationProvider(Guid providerId, AuthenticationDto body)
        {
            var url = $"/api/data/integrations/providers/{providerId}";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Allows you to deactivate an integration provider.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        public async Task<AstroResult<string>> DeactivateIntegrationProvider(Guid providerId)
        {
            var url = $"/api/data/integrations/providers/{providerId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Retrieves user authentication information about a specific IntegrationProvider.
        ///
        /// This connection can be used for requests to Providers that require specific user data.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        public async Task<AstroResult<DirectLinkDto>> CreateUserIntegrationProviderConnection(Guid providerId)
        {
            var url = $"/api/data/integrations/providers/{providerId}/user-connection";
            return await _client.Request<DirectLinkDto>(HttpMethod.Post, url, null, null, null);
        }

        /// <summary>
        /// Allows you to update the auth status of the provider specific user connection.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        /// <param name="body">Specify the auth status</param>
        public async Task<AstroResult<string>> UpdateUserIntegrationProviderConnection(Guid providerId, AuthenticationStatusDto body)
        {
            var url = $"/api/data/integrations/providers/{providerId}/user-connection";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Allows you to disconnect the provider specific user connection.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        public async Task<AstroResult<string>> DisconnectUserIntegrationProviderConnection(Guid providerId)
        {
            var url = $"/api/data/integrations/providers/{providerId}/user-connection";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
