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

        /// <summary>
        /// Retrieve the list of Workspaces to which the currently logged on user has access.
        ///
        /// A single User may have access to multiple Workspaces, although they can only be logged on to one Workspace at a time.  This API lists all Workspaces to which the currently logged on user is entitled to access.  To determine which Workspace a user is currently logged on use the `/api/data/me` endpoint.
        ///
        /// </summary>
        public async Task<AstroResult<WorkSpaceDto[]>> RetrieveWorkspaces()
        {
            var url = $"/api/data/workspaces";
            return await _client.Request<WorkSpaceDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Invite a specific user to join a Workspace to which the current user has administrator rights.
        ///
        /// A single User may have access to multiple Workspaces, although they can only be logged on to one Workspace at a time.  This API lists all Workspaces to which the currently logged on user is entitled to access.  To determine which Workspace a user is currently logged on use the `/api/data/me` endpoint.
        ///
        /// This API allows you to invite a specific  an invitation to join a specific Workspace.
        ///
        /// </summary>
        /// <param name="organizationId">The unique identifier of the Organization that you are inviting a User to joi</param>
        /// <param name="body">Information about the user which will receive the invitation</param>
        public async Task<AstroResult<string>> InvitetoWorkspace(string organizationId, WorkSpaceJoinDto body)
        {
            var url = $"/api/data/workspaces/{organizationId}/join";
            return await _client.Request<string>(HttpMethod.Post, url, null, body, null);
        }
    }
}
