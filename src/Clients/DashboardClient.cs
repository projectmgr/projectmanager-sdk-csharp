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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Dashboard
    /// </summary>
    public class DashboardClient : IDashboardClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public DashboardClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns user dashboard settings
        /// </summary>
        /// <param name="type">The dashboard type that is not custom. For a list of values, see `DashboardTypeValues`.</param>
        public async Task<AstroResult<DashboardSettingDto>> RetrieveDashboardUserSettings(string type)
        {
            var url = $"/api/data/dashboards/settings/{type}";
            return await _client.Request<DashboardSettingDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Create or Update User Dashboard Settings
        /// </summary>
        /// <param name="body">User dashboard settings object</param>
        public async Task<AstroResult<DashboardSettingDto>> CreateOrUpdateUserDashboardSettings(DashboardSettingCreateDto body)
        {
            var url = $"/api/data/dashboards/settings";
            return await _client.RequestWithBody<DashboardSettingDto>(HttpMethod.Post, url, null, body);
        }
    }
}
