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
    /// A ProjectVersion is a snapshot of a Project at a specific moment in time.  Information on
    /// the ProjectVersion record keeps track of the unique identity of this version, plus the name
    /// and details of the user who created this version, and the changes that were made.
    /// </summary>
    public class ProjectVersionDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the project version.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Version of the Project
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// the initials of the user
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The display name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The color for their avatar
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Version datetime
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The unique identifier of user who created backup
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// The group version belongs to
        /// </summary>
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Subset of the changes related to this ProjectVersion
        /// </summary>
        public ProjectVersionChangeDataDto ChangeData { get; set; }
    }
}
