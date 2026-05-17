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
    /// A single timesheet line for the task and resource.
    /// </summary>
    public class TaskActualTimeEntryDto : ApiModel
    {

        /// <summary>
        /// Timesheet row identifier.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Calendar date of the time entry (date-only).
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Minutes reported on this timesheet row for the task.
        /// </summary>
        public int? Minutes { get; set; }
    }
}
