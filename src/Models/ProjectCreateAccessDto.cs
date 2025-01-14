/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Specify who has access to a newly created project
    /// </summary>
    public class ProjectCreateAccessDto : ApiModel
    {

        /// <summary>
        /// If set to true every user will get access to this project
        /// </summary>
        public bool? Everyone { get; set; }

        /// <summary>
        /// If everyone is set to false the list of members will be used to give people access
        /// </summary>
        public ProjectCreateAccessMemberDto[] Members { get; set; }
    }
}
