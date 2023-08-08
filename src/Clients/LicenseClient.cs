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

        public async Task<AstroResult<LicenseDto[]>> UnknownName()
        {
            var url = $"/api/data/license";
            return await _client.Request<LicenseDto[]>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<LicenseDto[]>> UnknownName(string bundleSku)
        {
            var url = $"/api/data/license/{bundleSku}/try";
            return await _client.Request<LicenseDto[]>(HttpMethod.Post, url, null, null, null);
        }
    }
}
