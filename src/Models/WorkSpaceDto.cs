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
    public class WorkSpaceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Workspace.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this Workspace.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// The unique DNS domain of this Workspace.
        /// </summary>
        public string CustomProductDomain { get; set; }

        /// <summary>
        /// This value is set to true if the user who retrieves this Workspace object via an API call is
        /// the owner of this Workspace.
        /// </summary>
        public bool? IsOwner { get; set; }

        /// <summary>
        /// The organization code used for authentication systems for this Workspace.
        /// </summary>
        public string OrganizationId { get; set; }

        /// <summary>
        /// The RGB color in the format `#RRGGBB` for this Workspace.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The role of the current user within this Workspace.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// The timestamp when the Workspace was created.
        /// </summary>
        public DateTime? RegisterDate { get; set; }

        /// <summary>
        /// The unique identifier of the BusinessUser that is the owner of this Workspace.
        /// </summary>
        public Guid? BusinessUserId { get; set; }

        /// <summary>
        /// True if this Workspace has an active subscription; false if this is a free trial.
        /// </summary>
        public bool? IsPaid { get; set; }
    }
}
