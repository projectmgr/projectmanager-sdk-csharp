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
    /// A TaskAssignee is the person to whom a Task is assigned.  A single Task
    /// can be assigned to multiple TaskAssignees.
    /// </summary>
    public class TaskAssigneeDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskAssignee
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A shortened set of initials to use when representing this TaskAssignee visually
        /// in small areas.  The initials may be used in small icons or other overlays.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The name of this TaskAssignee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A more complete description of the TaskAssignee.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if this TaskAssignee is currently active with the Project.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The color that will be used to represent this TaskAssignee visually.
        ///
        /// You can choose specify any color that can be represented using HTML RGB
        /// syntax such as `#0088FF`, in the format `RRGGBB`.  You may not use names
        /// for colors.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The first or given name of this TaskAssignee.
        ///
        /// For personnel TaskAssignees only.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last or family name of this TaskAssignee.
        ///
        /// For personnel TaskAssignees only.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// A shortened version of the name of this TaskAssignee.  This is used in areas
        /// where the Initials are too short but the full name is too long.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// A link to an Avatar for this TaskAssignee.  Avatars are small images or representations
        /// that can be used to visually identify this TaskAssignee at a glance.
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The email address for the resource. It can be empty if the resource does not have a login.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The allocated effort (in minutes) for this Task and Assignee.
        /// </summary>
        public int? AllocatedEffort { get; set; }
    }
}
