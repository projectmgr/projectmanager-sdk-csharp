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
    /// You can create a large number of Tasks rapidly using the BulkTaskCreate API.  With
    /// this API you can submit multiple Tasks for creation at the same time.  This API
    /// provides access to a subset of Task information; for full control over Task creation
    /// please use the normal Create Task API.
    /// </summary>
    public class BulkTaskCreateDto : ApiModel
    {

        /// <summary>
        /// The name of the Task being created.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the work involved in this Task.
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
        /// The unique identifier of the TaskStatus that reflects the current status of
        /// this Task, if known.
        /// </summary>
        public Guid? StatusId { get; set; }

        /// <summary>
        /// The unique identifier of the TaskPriority that reflects the current status of
        /// this Task, if that has been selected.
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
    }
}
