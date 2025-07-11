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
    /// Time entry representation
    /// </summary>
    public class TimesheetResponseDto : ApiModel
    {

        /// <summary>
        /// TimesheetId
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// associated task id
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// associated project id
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// resource id time entry entered
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// admin task id
        /// </summary>
        public Guid? TimesheetAdminTypeId { get; set; }

        /// <summary>
        /// Date of time entry
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Shows if timesheet approved
        /// </summary>
        public bool? Approved { get; set; }

        /// <summary>
        /// Total Hours
        /// </summary>
        public decimal? Hours { get; set; }

        /// <summary>
        /// Total Minutes
        /// </summary>
        public int? Minutes { get; set; }

        /// <summary>
        /// Is the timesheet entry copied from another week?
        /// </summary>
        public bool? IsCopied { get; set; }

        /// <summary>
        /// Is the last timesheet modified by the user
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Document Details
        /// </summary>
        public TimesheetFileResponseDto[] Documents { get; set; }
    }
}
