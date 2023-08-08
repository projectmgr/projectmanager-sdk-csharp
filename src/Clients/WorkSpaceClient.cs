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
    /// API methods related to WorkSpace
    /// </summary>
    public class WorkSpaceClient : IWorkSpaceClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public WorkSpaceClient(ProjectManagerClient client)
        {
            _client = client;
        }

        public async Task<AstroResult<WorkSpaceDto[]>> UnknownName()
        {
            var url = $"/api/data/workspaces";
            return await _client.Request<WorkSpaceDto[]>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<string>> UnknownName(string organizationId, WorkSpaceJoinDto body)
        {
            var url = $"/api/data/workspaces/{organizationId}/join";
            return await _client.Request<string>(HttpMethod.Post, url, null, body, null);
        }
    }
}
