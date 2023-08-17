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
    /// API methods related to Integration
    /// </summary>
    public interface IIntegrationClient
    {

        /// <summary>
        /// Configure the WorkSpace for integrations
        ///
        /// </summary>
        Task<AstroResult<IntegrationSetupResponseDto>> SetupWorkSpaceforIntegrations();

        /// <summary>
        /// Retrieves an Integration specified by a unique identifier.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of this Integration</param>
        Task<AstroResult<IntegrationDto>> RetrieveIntegration(Guid integrationId);

        /// <summary>
        /// Enable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to enable</param>
        Task<AstroResult<IntegrationDto>> EnableIntegration(Guid integrationId);

        /// <summary>
        /// Disable a specific Integration for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to disable</param>
        Task<AstroResult<string>> DisableIntegration(Guid integrationId);

        /// <summary>
        /// Retrieves all Integrations for the current Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        Task<AstroResult<IntegrationDto[]>> RetrieveAllIntegrations();

        /// <summary>
        /// List all available IntegrationProviders that can be activated.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        Task<AstroResult<IntegrationProviderDto[]>> ListProviders();

        /// <summary>
        /// Retrieves authentication information about a specific IntegrationProvider.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="providerId">The unique identifier of the IntegrationProvider for which you are requesting authentication information</param>
        Task<AstroResult<DirectLinkDto>> RetrieveProviderAuthentication(Guid providerId);

        /// <summary>
        /// Allows you to update the auth status of the main project manager connection.
        ///
        /// </summary>
        /// <param name="providerId">the identifier to the provider</param>
        /// <param name="body">Specify the auth status</param>
        Task<AstroResult<string>> UpdateIntegrationProviderauthstatus(Guid providerId, AuthenticationStatusDto body);

        /// <summary>
        /// Allows you to update the auth status of the main project manager connection.
        ///
        /// </summary>
        /// <param name="body">Specify the auth status</param>
        Task<AstroResult<string>> UpdateAuthStatusforprojectmanagerintegrationtoAPI(AuthenticationStatusDto body);

        /// <summary>
        /// Retrieves the list of available IntegrationProvider categories.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        Task<AstroResult<IntegrationCategoryDto[]>> RetrieveProviderCategories();

        /// <summary>
        /// Adds a new Integration instance to a Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationId">The unique identifier of the Integration to add to this Workspace</param>
        /// <param name="body">The information about this Integration to add</param>
        Task<AstroResult<NewIntegrationInstanceDto>> AddIntegrationInstance(Guid integrationId, CreateIntegrationInstanceDto body);

        /// <summary>
        /// Removes an existing Integration instance from a Workspace.
        ///
        /// The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="integrationInstanceId">The unique identifier of the IntegrationInstance to remove from this Workspace</param>
        Task<AstroResult<string>> RemoveIntegrationInstance(Guid integrationInstanceId);
    }
}
