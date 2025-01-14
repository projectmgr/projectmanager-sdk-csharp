/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to IntegrationCategory
    /// </summary>
    public interface IIntegrationCategoryClient
    {

        /// <summary>
        /// Retrieves the list of available IntegrationProvider categories.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to
        /// ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business
        /// development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        Task<AstroResult<IntegrationCategoryDto[]>> RetrieveProviderCategories();
    }
}
