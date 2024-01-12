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
    /// Information about a currently logged in user.
    ///
    /// You can call the RetrieveMe API to gather information about the current user.
    /// </summary>
    public class WorkSpaceUserInfoDto : ApiModel
    {

        /// <summary>
        /// A collection of shortcut links for the currently logged in Workspace.
        /// </summary>
        public WorkSpaceLinksDto Links { get; set; }

        /// <summary>
        /// The email address of the currently logged in user.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The unique identity of the currently logged in user.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The full name of the currently logged in user.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The name of the Workspace that the current user has logged onto.  For most companies, the workspace
        /// name will be the name of the business.
        /// </summary>
        public string WorkSpaceName { get; set; }

        /// <summary>
        /// The user&#39;s role within the current Workspace.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// True if this user is considered a global administrator of the current Workspace.
        /// </summary>
        public bool? IsGlobalAdmin { get; set; }

        /// <summary>
        /// True if this user is considered an account administrator of the current Workspace.
        /// </summary>
        public bool? IsAccountAdministrator { get; set; }
    }
}
