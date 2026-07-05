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
        /// Returns the workspace the user is currently logged on to as a single-item list.
        ///
        /// This endpoint does not return every workspace the user can access. To switch workspaces
        /// or list all accessible workspaces, use workspace selection flows (for example `/api/data/me`
        /// and the workspace selector).
        /// </summary>
        Task<AstroResult<WorkSpaceDto[]>> RetrieveCurrentWorkspace();

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
        Task<AstroResult<WorkSpaceDto>> UpdateCurrentWorkspaceSettings(WorkspaceSettingsUpdateDto body);
    }
}
