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
        /// Returns the workspace the user is currently logged on to as a single-item list.
        ///
        /// This endpoint does not return every workspace the user can access. To switch workspaces
        /// or list all accessible workspaces, use workspace selection flows (for example `/api/data/me`
        /// and the workspace selector).
        /// </summary>
        public async Task<AstroResult<WorkSpaceDto[]>> RetrieveTheCurrentWorkspace()
        {
            var url = $"/api/data/workspaces";
            return await _client.Request<WorkSpaceDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Updates workspace-level scheduling defaults for the workspace the user is currently logged on to,
        /// including default planned hours and working-day hours (Monday through Sunday).
        ///
        /// Only properties included in the request body are updated; omitted properties are left unchanged.
        /// When workingDays is provided, only the weekdays included in that object are updated.
        ///
        /// Values must be between 0 and 24.
        /// </summary>
        /// <param name="body">Workspace settings to update</param>
        public async Task<AstroResult<WorkSpaceDto>> UpdateSettingsForTheCurrentWorkspace(WorkspaceSettingsUpdateDto body)
        {
            var url = $"/api/data/workspaces/settings";
            return await _client.RequestWithBody<WorkSpaceDto>(HttpMethod.Put, url, null, body);
        }
    }
}
