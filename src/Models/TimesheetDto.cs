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
    /// Created Time entry response data
    /// </summary>
    public class TimesheetDto : ApiModel
    {

        /// <summary>
        /// TimesheetId
        /// </summary>
        public Guid? Id { get; set; }

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
        /// Date and time (in UTC) that this timesheet entry was last modified.
        /// </summary>
        public DateTime? Modifieddate { get; set; }

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
        public TimesheetAdminTypeDto Admintype { get; set; }

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
