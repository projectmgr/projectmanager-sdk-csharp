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
    /// API methods related to Me
    /// </summary>
    public class MeClient : IMeClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MeClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve information about the currently logged on user.
        ///
        /// This API call will always succeed with a 200 OK if called with valid authentication information. If the authentication information provided is not valid, calling this API will return a 401 Authentication Failed error message.  If successful, this API returns information about the user including its home URL, email address, user name, and workspace name.
        ///
        /// </summary>
        public async Task<AstroResult<WorkSpaceUserInfoDto>> RetrieveMe()
        {
            var url = $"/api/data/me";
            return await _client.Request<WorkSpaceUserInfoDto>(HttpMethod.Get, url, null, null, null);
        }
    }
}
