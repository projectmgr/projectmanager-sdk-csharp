/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
    /// API methods related to License
    /// </summary>
    public class LicenseClient : ILicenseClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public LicenseClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve information about the current licenses possessed by this Workspace.
        ///
        /// Licenses contain information about your current subscription level and features that have
        /// been enabled on your Workspace.  To modify the License information, please log on to the
        /// ProjectManager.com application and use the Account | Editions screen to review or update
        /// your Licenses.
        /// </summary>
        public async Task<AstroResult<LicenseDto[]>> RetrieveLicenses()
        {
            var url = $"/api/data/license";
            return await _client.Request<LicenseDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Adds a new License to the current Workspace.
        ///
        /// Licenses contain information about your current subscription level and features that have
        /// been enabled on your Workspace.  To modify the License information, please log on to the
        /// ProjectManager.com application and use the Account | Editions screen to review or update
        /// your Licenses.
        /// </summary>
        /// <param name="bundleSku">Information about the SKU you wish to add to your Workspace</param>
        public async Task<AstroResult<LicenseDto[]>> AddLicense(string bundleSku)
        {
            var url = $"/api/data/license/{bundleSku}/try";
            return await _client.Request<LicenseDto[]>(HttpMethod.Post, url, null);
        }
    }
}
