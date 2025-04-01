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
    /// A NptAssignee is a Resource to whom a Npt is assigned. A single Npt
    /// can be assigned to multiple NptAssignee.
    /// </summary>
    public class NptAssigneeDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Resource
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A shortened set of initials to use when representing this NptAssignee visually
        /// in small areas.  The initials may be used in small icons or other overlays.
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The name of this NptAssignee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A more complete description of the NptAssignee.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// True if this NptAssignee is currently active with the Project.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Collaboration Color for this resource.
        ///
        /// eg. teal, cyan, lightblue, blurple, purple, pink, orange, gray
        /// </summary>
        public string ColorName { get; set; }

        /// <summary>
        /// The first or given name of this NptAssignee.
        ///
        /// For personnel NptAssignees only.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last or family name of this NptAssignee.
        ///
        /// For personnel NptAssignees only.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// A shortened version of the name of this NptAssignee.  This is used in areas
        /// where the Initials are too short but the full name is too long.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// A link to an Avatar for this NptAssignee.  Avatars are small images or representations
        /// that can be used to visually identify this NptAssignee at a glance.
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// The email address for the resource. It can be empty if the resource does not have a login.
        /// </summary>
        public string Email { get; set; }
    }
}
