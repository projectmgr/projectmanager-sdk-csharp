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
    /// A Npt is a task that does not belong to the project. It is only visible to the person who created it, and the users assigned to it.
    ///
    /// NPT&#39;s are a lightweight version of a project task.
    /// </summary>
    public class NptDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the NPT
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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedStartDate { get; set; }

        /// <summary>
        /// The date when work on this Task is expected to complete.
        ///
        /// This value contains only the date in year-month-day format. For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedFinishDate { get; set; }

        /// <summary>
        /// The actual effort (in minutes) for this Task.
        /// </summary>
        public int? ActualEffort { get; set; }

        /// <summary>
        /// Return the priority of a task
        /// </summary>
        public int? PriorityId { get; set; }

        /// <summary>
        /// The numerical percentage, from 0-100, representing the percentage completion
        /// for this Task.  Any numbers below zero or above 100 will be clamped to the
        /// minimum or maximum value.
        ///
        /// This value can be edited manually in the Gantt chart view of the application,
        /// or can be selected on the Task Detail page within the Kanban board.
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// The status assigned to this Npt
        /// </summary>
        public NptStatusDto Status { get; set; }

        /// <summary>
        /// The list of resources assigned to this Npt
        /// </summary>
        public NptAssigneeDto[] Assignees { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this Task.  This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }
    }
}
