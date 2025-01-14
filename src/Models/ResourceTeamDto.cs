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
    /// A ResourceTeam is a group of Resources that can be referred to as a group.  You can use a
    /// ResourceTeam as a shortcut to quickly assign or allocate multiple Resources quickly.
    /// </summary>
    public class ResourceTeamDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ResourceTeam
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ResourceTeam
        /// </summary>
        public string Name { get; set; }
    }
}
