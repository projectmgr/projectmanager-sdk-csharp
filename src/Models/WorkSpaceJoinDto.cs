/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A Workspace represents a single business subscription to the ProjectManager.com service.  You
    /// can be a member of multiple Workspaces.  Each Workspace is completely separate from all other
    /// Workspaces and a user cannot log in to multiple Workspaces at the same time.
    /// </summary>
    public class WorkSpaceJoinDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the BusinessUser to invite to this Workspace.
        /// </summary>
        public Guid? BusinessUserId { get; set; }
    }
}
