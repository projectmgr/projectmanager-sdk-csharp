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
    /// A Task is an individual element of work that must be performed to complete a Project.  A
    /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
    /// indicate whether they have a dependency or a connection.
    /// </summary>
    public class TaskDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Task.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The Project to which this Task belongs.
        /// </summary>
        public TaskProjectDto Project { get; set; }

        /// <summary>
        /// The TaskTags that apply to this Task.
        /// </summary>
        public TaskTagDto[] Tags { get; set; }

        /// <summary>
        /// The unique identifier of the Project to which this Task belongs.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The list of assignees who are to work on this Task, if any.
        /// </summary>
        public TaskAssigneeDto[] Assignees { get; set; }

        /// <summary>
        /// A list of TaskTodo items, which are sub-tasks within this Task.
        /// </summary>
        public TaskTodoDto[] Todos { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this Task.  This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the work to be performed in this Task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The TaskStatus assigned to this Task.
        /// </summary>
        public TaskStatusDto Status { get; set; }

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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedStartDate { get; set; }

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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedFinishDate { get; set; }

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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualStartDate { get; set; }

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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualFinishDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when this Task was most recently modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when this Task was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

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
        /// True if this Task is the parent of multiple Tasks underneath it.  A parent Task
        /// is a &quot;rolled-up&quot; view of multiple children that allows you to view a section of
        /// work at a glance.
        ///
        /// You can create a summary Task in the Gantt chart view of the application by
        /// adding child tasks underneath a parent Task.
        /// </summary>
        public bool? IsSummary { get; set; }

        /// <summary>
        /// Return the priority of a task
        /// </summary>
        public int? PriorityId { get; set; }

        /// <summary>
        /// The WBS (Work Breakdown Structure) number for this task within the Gantt chart hierarchy.  See [What
        /// Is a Work Breakdown Structure (WBS)?](https://www.projectmanager.com/guides/work-breakdown-structure)
        /// on Project Manager for more information. The WBS number is an outline number in the form `#.#.#.#`
        /// which indicates how tasks are organized and sorted.
        ///
        /// The WBS value is only available to users at certain edition levels.  This value can only be changed
        /// if you are a Project Editor.
        /// </summary>
        public string Wbs { get; set; }

        /// <summary>
        /// Task Color as set in the Gantt
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The actual cost of this Task to date, if known.
        /// </summary>
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// The planned cost for this Task.  Cannot be negative.
        /// </summary>
        public decimal? PlannedCost { get; set; }

        /// <summary>
        /// The planned duration (in minutes) for this Task.
        /// </summary>
        public int? PlannedDuration { get; set; }

        /// <summary>
        /// The planned effort (in minutes) for this Task.
        /// </summary>
        public int? PlannedEffort { get; set; }

        /// <summary>
        /// Task fields array with values
        /// </summary>
        public TaskFieldValueDto[] FieldValues { get; set; }
    }
}
