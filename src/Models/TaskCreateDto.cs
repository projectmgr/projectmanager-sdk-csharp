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
    public class TaskCreateDto : ApiModel
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
        /// The unique identifier of the TaskStatus for this Task
        /// </summary>
        public Guid? StatusId { get; set; }

        /// <summary>
        /// A numerical value representing the Priority of this Task
        /// </summary>
        public int? PriorityId { get; set; }

        /// <summary>
        /// A list of unique identifiers of TaskAssignees to be assigned to this Task
        /// </summary>
        public Guid[] Assignees { get; set; }

        /// <summary>
        /// The date when work on this Task is planned to begin.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedStartDate { get; set; }

        /// <summary>
        /// The date when work on this Task is expected to complete.
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
        /// The date when work on this Task actually started, if known.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualStartDate { get; set; }

        /// <summary>
        /// The actual cost of this Task to date, if known.
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
