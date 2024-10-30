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
    public class TaskUpdateDto : ApiModel
    {

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the work to be performed in this Task.
        /// </summary>
        public string Description { get; set; }

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
        /// The TaskStatus assigned to this Task.
        /// </summary>
        public Guid? StatusId { get; set; }

        /// <summary>
        /// The unique identifier of the TaskPriority
        /// </summary>
        public int? PriorityId { get; set; }

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
        /// The planned duration (in minutes) for this Task.  Cannot be negative.
        /// </summary>
        public int? PlannedDuration { get; set; }

        /// <summary>
        /// The planned effort (in minutes) for this Task.  Cannot be negative.
        /// </summary>
        public int? PlannedEffort { get; set; }

        /// <summary>
        /// The planned cost for this Task.  Cannot be negative.
        /// </summary>
        public decimal? PlannedCost { get; set; }

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
        /// If set, this is the actual date when work was completed on the Task.
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
        /// If set, this represents the actual tracked cost for this Task.
        /// </summary>
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// Color theme definition for this task.
        ///
        /// eg. Blue, Brown, DarkBlue, DarkGrey, Gold, Green, Grey, LightBrown, LightGreen,
        /// LightGrey, LightPurple, LightYellow, Magenta, Mauve, Navy, Orange, Purple, Red.
        /// </summary>
        public string Theme { get; set; }

        /// <summary>
        /// Unlocked tasks can be adjusted by changes to their dependencies, resource leveling, or other factors.
        ///
        /// All tasks are unlocked by default.
        ///
        /// If a task is set to `IsLocked` = `true`, the dates and assigned resources are locked for this task and will not
        /// be automatically changed by any process.
        /// </summary>
        public bool? IsLocked { get; set; }

        /// <summary>
        /// True if this task is a milestone.  Milestones represent a specific point in time for the project.  When a
        /// milestone is locked, it represents a fixed time within the project that can be used to relate to other tasks.
        /// </summary>
        public bool? IsMilestone { get; set; }
    }
}
