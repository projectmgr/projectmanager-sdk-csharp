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
    /// A Meeting is a lightweight calendar event that may or may not belong to a project.
    /// It is only visible to the person who created it and the users assigned to it.
    /// </summary>
    public class MeetingCreateDto : ApiModel
    {

        /// <summary>
        /// The common name of this Meeting.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This field contains the Meeting&#39;s description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The planned start date/time for this Meeting, in UTC.
        /// Time must be on a 15-minute boundary (0, 15, 30, or 45 minutes).
        /// Clients should convert to local time only when displaying to the user.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The duration (in 15-minute increments) for this Meeting.
        /// </summary>
        public int? DurationMinutes { get; set; }

        /// <summary>
        /// Specify a list of resources to assign to this Meeting
        /// </summary>
        public Guid[] Assignees { get; set; }

        /// <summary>
        /// The numeric of the Priority for this Meeting
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// The unique identifier of the Project for this Meeting
        /// </summary>
        public Guid? ProjectId { get; set; }
    }
}
