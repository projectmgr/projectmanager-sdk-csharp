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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to WorkSpace
    /// </summary>
    public interface IWorkSpaceClient
    {

        /// <summary>
        /// Retrieve the list of Workspaces to which the currently logged on user has access.
        ///
        /// A single User may have access to multiple Workspaces, although they can only be logged on
        /// to one Workspace at a time.  This API lists all Workspaces to which the currently logged on
        /// user is entitled to access.  To determine which Workspace a user is currently logged on
        /// use the `/api/data/me` endpoint.
        /// </summary>
        Task<AstroResult<WorkSpaceDto[]>> RetrieveWorkspaces();

        /// <summary>
        /// Invite a specific user to join a Workspace to which the current user has administrator rights.
        ///
        /// A single User may have access to multiple Workspaces, although they can only be logged on
        /// to one Workspace at a time.  This API lists all Workspaces to which the currently logged on
        /// user is entitled to access.  To determine which Workspace a user is currently logged on
        /// use the `/api/data/me` endpoint.
        ///
        /// This API allows you to invite a specific  an invitation to join a specific Workspace.
        /// </summary>
        /// <param name="organizationId">The unique identifier of the Organization that you are inviting a User to joi</param>
        /// <param name="body">Information about the user which will receive the invitation</param>
        Task<AstroResult<string>> InviteToWorkspace(string organizationId, WorkSpaceJoinDto body);
    }
}
