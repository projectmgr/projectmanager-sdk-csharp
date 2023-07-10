/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A ResourceTeam is a grouping of Resources that allows you to keep track of assignments
    /// in a manner consistent with your business needs.  You can assign Resources to be members
    /// of zero, one, or many ResourceTeams.
    /// </summary>
    public class BusinessTeamDto
    {

        /// <summary>
        /// The unique identifier of this ResourceTeam
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The friendly name of this ResourceTeam
        /// </summary>
        public string Name { get; set; }
    }
}
