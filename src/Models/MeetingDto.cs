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
    /// A Meeting is a task that does not belong to the project. It is only visible to the person who created it, and the users assigned to it.
    ///
    /// Meeting&#39;s are a lightweight version of a project task.
    /// </summary>
    public class MeetingDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Meeting
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This field contains the task&#39;s &quot;Note&quot; or &quot;Description&quot;, which is a description of the work to be done to complete the task.
        ///
        /// Within the ProjectManager application, you can use this field as follows:
        /// * When in the Board or List view, click on a task to open the task panel, then edit the &quot;Description&quot; field.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date when work on this Task is planned to begin.
        ///
        /// This value contains only the date in year-month-day format. For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// </summary>
        public DateTime? PlannedStartDate { get; set; }

        /// <summary>
        /// The date when work on this Task is expected to complete.
        ///
        /// This value contains only the date in year-month-day format. For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// </summary>
        public DateTime? PlannedFinishDate { get; set; }

        /// <summary>
        /// The planned duration (in minutes) for this Task.
        /// </summary>
        public int? PlannedDuration { get; set; }

        /// <summary>
        /// The planned effort (in minutes) for this Task.
        /// </summary>
        public int? PlannedEffort { get; set; }

        /// <summary>
        /// Return the priority of a task
        /// </summary>
        public int? PriorityId { get; set; }

        /// <summary>
        /// The list of resources assigned to this Meeting
        /// </summary>
        public MeetingAssigneeDto[] Assignees { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this Task.  This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The TaskTags that apply to this Task.
        /// </summary>
        public TaskTagDto[] Tags { get; set; }

        /// <summary>
        /// A list of TaskTodo items, which are sub-tasks within this Task.
        /// </summary>
        public TaskTodoDto[] Todos { get; set; }

        /// <summary>
        /// Timestamp when the Meeting was created
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The owner of this Task.
        /// </summary>
        public TaskOwnerDto Owner { get; set; }

        /// <summary>
        /// The ownerId of this Task.
        /// </summary>
        public Guid? OwnerId { get; set; }
    }
}
