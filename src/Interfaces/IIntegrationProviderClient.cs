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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to IntegrationProvider
    /// </summary>
    public interface IIntegrationProviderClient
    {

        /// <summary>
        /// List all available IntegrationProviders that can be activated.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        Task<AstroResult<IntegrationProviderDto[]>> ListProviders(string xintegrationname = null);

        /// <summary>
        /// Activates an Integration Provider and retrieves authentication information about a specific IntegrationProvider.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        Task<AstroResult<ConnectionSchemaDto>> ActivateIntegrationProvider(Guid providerId, string xintegrationname = null);

        /// <summary>
        /// Allows you to update the auth status of the provider specific connection.
        ///
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">Specify the auth status</param>
        Task<AstroResult<string>> UpdateIntegrationProvider(Guid providerId, AuthenticationDto body, string xintegrationname = null);

        /// <summary>
        /// Allows you to deactivate an integration provider
        ///
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        Task<AstroResult<string>> DeactivateIntegrationProvider(Guid providerId, string xintegrationname = null);

        /// <summary>
        /// Retrieves user authentication information about a specific IntegrationProvider.
        ///
        /// This connection can be used for requests to Providers that require specific user data.
        ///
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        Task<AstroResult<DirectLinkDto>> CreateUserIntegrationProviderConnection(Guid providerId, string xintegrationname = null);

        /// <summary>
        /// Allows you to update the auth status of the provider specific user connection.
        ///
        /// </summary>
        /// <param name="providerId">The identifier to the provider</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">Specify the auth status</param>
        Task<AstroResult<string>> UpdateUserIntegrationProviderConnection(Guid providerId, AuthenticationStatusDto body, string xintegrationname = null);
    }
}
