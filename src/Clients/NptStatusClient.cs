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
    /// API methods related to NptStatus
    /// </summary>
    public class NptStatusClient : INptStatusClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NptStatusClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get a list of task statuses that can be used by npt tasks.
        /// </summary>
        public async Task<AstroResult<NptStatusDto[]>> GetNptTaskStatuses()
        {
            var url = $"/api/data/non-project-tasks/statuses";
            return await _client.Request<NptStatusDto[]>(HttpMethod.Get, url, null);
        }
    }
}
