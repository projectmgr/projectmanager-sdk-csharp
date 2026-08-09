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
    public class MeetingDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Meeting
        /// </summary>
        public Guid? Id { get; set; }

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
        /// Clients should convert to local time only when displaying to the user.
        /// </summary>
        public DateTime? PlannedStartDate { get; set; }

        /// <summary>
        /// The planned finish date/time for this Meeting, in UTC.
        /// Clients should convert to local time only when displaying to the user.
        /// </summary>
        public DateTime? PlannedFinishDate { get; set; }

        /// <summary>
        /// The planned duration (in minutes) for this Meeting.
        /// </summary>
        public int? PlannedDuration { get; set; }

        /// <summary>
        /// The planned effort (in minutes) for this Meeting.
        /// </summary>
        public int? PlannedEffort { get; set; }

        /// <summary>
        /// Return the priority of a Meeting
        /// </summary>
        public int? PriorityId { get; set; }

        /// <summary>
        /// The list of resources assigned to this Meeting
        /// </summary>
        public MeetingAssigneeDto[] Assignees { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this Meeting. This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The tags that apply to this Meeting.
        /// </summary>
        public TaskTagDto[] Tags { get; set; }

        /// <summary>
        /// A list of todo items for this Meeting.
        /// </summary>
        public TaskTodoDto[] Todos { get; set; }

        /// <summary>
        /// Timestamp when the Meeting was created
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The owner of this Meeting.
        /// </summary>
        public TaskOwnerDto Owner { get; set; }

        /// <summary>
        /// The ownerId of this Meeting.
        /// </summary>
        public Guid? OwnerId { get; set; }

        /// <summary>
        /// The project this meeting belongs to
        /// </summary>
        public MeetingProjectDto Project { get; set; }
    }
}
