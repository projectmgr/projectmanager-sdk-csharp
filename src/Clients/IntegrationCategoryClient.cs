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
    /// API methods related to IntegrationCategory
    /// </summary>
    public class IntegrationCategoryClient : IIntegrationCategoryClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public IntegrationCategoryClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the list of available IntegrationProvider categories.
        ///
        /// An IntegrationProvider is the name of an external application or service that can be connected to ProjectManager.com.  The Integrations API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        public async Task<AstroResult<IntegrationCategoryDto[]>> RetrieveProviderCategories(string xintegrationname = null)
        {
            var url = $"/api/data/integrations/categories";
            return await _client.Request<IntegrationCategoryDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
