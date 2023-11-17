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
    }
}
