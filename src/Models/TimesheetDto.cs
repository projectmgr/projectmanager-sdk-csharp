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
    /// A Timesheet entry is a single record that contains information about time spent by a person on a task.  Each
    /// Timesheet entry object contains information about one task/day/person combination.  A fully completed Timesheet
    /// will often contain multiple records for the same date range which must be combined to produce a finished
    /// Timesheet.
    /// </summary>
    public class TimesheetDto : ApiModel
    {

        /// <summary>
        /// A unique identifier of a timesheet data entry
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique identifier of the resource who is preparing this Timesheet.  You can filter on this value to measure
        /// the total work performed by this specific Resource.
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// The unique identifier of the task worked on for this Timesheet.  You can filter on this value to measure the
        /// total work performed against a specific Task.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The unique identifier of the project worked on for this Timesheet.  You can filter on this value to measure the
        /// total work performed against a specific Project.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The date of this time entry record.  You can filter on this value to obtain Timesheet data for a specific date
        /// range.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Notes associated with this Timesheet, if any
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// True if this Timesheet was approved by a person with the role of a Timesheet approver
        /// </summary>
        public bool? Approved { get; set; }

        /// <summary>
        /// Total Hours spent on this Task by this Resource on this specific Date
        /// </summary>
        public decimal? Hours { get; set; }

        /// <summary>
        /// Total minutes spent on this Task by this Resource on this specific Date
        /// </summary>
        public int? Minutes { get; set; }

        /// <summary>
        /// Date and time (in UTC) that this timesheet entry was last modified.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The task associated with this timesheet entry
        /// </summary>
        public TimesheetTaskDto Task { get; set; }

        /// <summary>
        /// The project associated with this timesheet entry
        /// </summary>
        public TimeSheetProjectDto Project { get; set; }

        /// <summary>
        /// The resource associated with this timesheet entry
        /// </summary>
        public TimesheetResourceDto Resource { get; set; }

        /// <summary>
        /// The administration type associated with this timesheet entry
        /// </summary>
        public TimesheetAdminTypeDto AdminType { get; set; }

        /// <summary>
        /// The list of files associated with this Timesheet, if any.
        ///
        /// This field will be present when you fetch a single object.
        /// When you query for multiple objects, this field is not included in results by default.
        /// To expand this field, specify the name of this field in the `$expand` parameter.
        /// </summary>
        public TimesheetFileDto[] Files { get; set; }
    }
}
