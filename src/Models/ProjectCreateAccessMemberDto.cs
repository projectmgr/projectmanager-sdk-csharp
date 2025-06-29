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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Represents project member that have access to new project
    /// </summary>
    public class ProjectCreateAccessMemberDto : ApiModel
    {

        /// <summary>
        /// Member&#39;s id
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// Member&#39;s role in the project, if left empty the default role will be used
        ///
        /// For users with Access All Data permission, this will be set to `Manager`.
        /// For guests, this will be set to `Guest`.
        /// For all other users, this will be set to `Editor`.
        ///
        /// Valid values are: `Manager`, `Editor`, `Collaborate`, `Guest`.
        /// </summary>
        public string Permission { get; set; }
    }
}
