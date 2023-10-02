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
    /// A Task is an individual element of work that must be performed to complete a Project.  A
    /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
    /// indicate whether they have a dependency or a connection.
    /// </summary>
    public class TimesheetTaskDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Task.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The date when work on this Task is planned to begin.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? PlannedStartDate { get; set; }

        /// <summary>
        /// The date when work on this Task is expected to complete.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? PlannedFinishDate { get; set; }

        /// <summary>
        /// The total span of active working time.
        /// e.g. 3days = 3days x 8hours x 600 (magic number for minutes?) = 14400
        /// </summary>
        public int? PlannedDuration { get; set; }

        /// <summary>
        /// The planned cost for this Task.  Cannot be negative.
        /// </summary>
        public int? PlannedHours { get; set; }

        /// <summary>
        /// The planned cost for this Task.  Cannot be negative.
        /// </summary>
        public decimal? PlannedCost { get; set; }

        /// <summary>
        /// The planned resource cost for this Task.  Cannot be negative.
        /// </summary>
        public decimal? PlannedResourceCost { get; set; }

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
        /// If set, this is the actual date when work began on the Task.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? ActualStartDate { get; set; }

        /// <summary>
        /// If set, this is the actual date when work was completed on this Task.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? ActualFinishDate { get; set; }

        /// <summary>
        /// The total span of active working time.
        /// e.g. 3days = 3days x 8hours x 600 (magic number for minutes?) = 14400
        /// </summary>
        public int? ActualDuration { get; set; }

        /// <summary>
        /// The actual work hrs
        /// </summary>
        public int? ActualWork { get; set; }

        /// <summary>
        /// The actual cost of this Task to date, if known.
        /// </summary>
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// The actual resource cost of this Task to date, if known.
        /// </summary>
        public decimal? ActualResourceCost { get; set; }

        /// <summary>
        /// The date when work on this Task is planned to begin.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? BaselineStartDate { get; set; }

        /// <summary>
        /// The date when work on this Task is expected to complete.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// For example: A Task has a planned completion date of July 5, 2023 in a Workspace
        /// that has a time zone of US Pacific Time (GMT-7 or GMT-8, depending on daylight
        /// savings time).  This project is considered overdue on 12:01 AM July 6th 2023 in
        /// US Pacific time.
        /// </summary>
        public DateTime? BaselineFinishDate { get; set; }

        /// <summary>
        /// The total span of active working time.
        /// e.g. 3days = 3days x 8hours x 600 (magic number for minutes?) = 14400
        /// </summary>
        public int? BaselineDuration { get; set; }

        /// <summary>
        /// The actual work hrs
        /// </summary>
        public int? BaselineHours { get; set; }

        /// <summary>
        /// The actual cost of this Task to date, if known.
        /// </summary>
        public decimal? BaselineCost { get; set; }

        /// <summary>
        /// The TaskStatus assigned to this Task.
        /// </summary>
        public TimesheetTaskStatusDto Status { get; set; }

        /// <summary>
        /// Return the priority of a task
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// A notes of the work to be performed in this Task.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Task Tags
        /// </summary>
        public TimesheetTaskTagDto[] Tag { get; set; }

        /// <summary>
        /// True if this Task is the parent of multiple Tasks underneath it.  A parent Task
        /// is a &quot;rolled-up&quot; view of multiple children that allows you to view a section of
        /// work at a glance.
        ///
        /// You can create a summary Task in the Gantt chart view of the application by
        /// adding child tasks underneath a parent Task.
        /// </summary>
        public bool? IsSummary { get; set; }

        /// <summary>
        /// his means that the dates and assigned resources are locked for this task and it will not be automatically changed by any process.  So, if this field is checked, then this task is always ignored by leveling or any changes to the schedule.
        /// </summary>
        public bool? IsLock { get; set; }

        /// <summary>
        /// milestone
        /// </summary>
        public bool? IsMilestone { get; set; }
    }
}
