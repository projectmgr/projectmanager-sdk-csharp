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

        Task<AstroResult<IntegrationDto>> UnknownName(Guid integrationId);

        /// <summary>
        /// Enable an integration and provision the provider to the workspace
        ///
        /// </summary>
        /// <param name="integrationId">A reference to the integration to be enabled</param>
        Task<AstroResult<IntegrationDto>> EnableIntegration(Guid integrationId);

        /// <summary>
        /// Enable an integration and provision the provider to the workspace
        ///
        /// </summary>
        /// <param name="integrationId">A reference to the integration to be enabled</param>
        Task<AstroResult<string>> EnableIntegration(Guid integrationId);

        Task<AstroResult<IntegrationDto[]>> UnknownName();

        Task<AstroResult<IntegrationProviderDto[]>> UnknownName();

        Task<AstroResult<DirectLinkDto>> UnknownName(Guid providerId);

        Task<AstroResult<IntegrationCategoryDto[]>> UnknownName();

        Task<AstroResult<NewIntegrationInstanceDto>> Addsinstancetoworkspaceintegration(Guid integrationId, CreateIntegrationInstanceDto body);

        Task<AstroResult<string>> Removesinstancefromworkspaceintegration(Guid integrationInstanceId);
    }
}
