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
    /// Created Time entry response data
    /// </summary>
    public class TimesheetGetResponseDto : ApiModel
    {

        /// <summary>
        /// Unique identfier of Time entry
        /// </summary>
        public Guid? TimesheetId { get; set; }

        /// <summary>
        /// Unique identfier of project entry
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Shows if timesheet approved
        /// </summary>
        public bool? Approved { get; set; }

        /// <summary>
        /// The default hourly rate for work on this timesheet.
        /// </summary>
        public decimal? HourlyRate { get; set; }

        /// <summary>
        /// Shows when timesheet approved
        /// </summary>
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Shows who approved timesheet
        /// </summary>
        public Guid? ApprovedBy { get; set; }

        /// <summary>
        /// The ChargeCode of this timesheet, if defined.
        /// </summary>
        public Guid? ChargeCode { get; set; }

        /// <summary>
        /// Information about the customer of this timeshee, if one has been specified.
        /// </summary>
        public Guid? Customer { get; set; }

        /// <summary>
        /// timesheet tasks details
        /// </summary>
        public TimesheetTaskDto TimesheetTask { get; set; }
    }
}
