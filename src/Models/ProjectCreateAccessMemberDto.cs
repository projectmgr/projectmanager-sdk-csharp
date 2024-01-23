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
    /// Represents project member that have access to new project
    /// </summary>
    public class ProjectCreateAccessMemberDto : ApiModel
    {

        /// <summary>
        /// Member&#39;s id
        /// </summary>
        public Guid? Userid { get; set; }

        /// <summary>
        /// Member&#39;s role in the project
        /// </summary>
        public string Permission { get; set; }
    }
}
