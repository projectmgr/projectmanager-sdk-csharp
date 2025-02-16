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

        /// <summary>
        /// Retrieve the list of Workspaces to which the currently logged on user has access.
        ///
        /// A single User may have access to multiple Workspaces, although they can only be logged on
        /// to one Workspace at a time.  This API lists all Workspaces to which the currently logged on
        /// user is entitled to access.  To determine which Workspace a user is currently logged on
        /// use the `/api/data/me` endpoint.
        /// </summary>
        public async Task<AstroResult<WorkSpaceDto[]>> RetrieveWorkspaces()
        {
            var url = $"/api/data/workspaces";
            return await _client.Request<WorkSpaceDto[]>(HttpMethod.Get, url, null);
        }
    }
}
