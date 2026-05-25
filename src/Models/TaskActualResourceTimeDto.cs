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
    /// Reported (timesheet) time for one resource on the task.
    /// </summary>
    public class TaskActualResourceTimeDto : ApiModel
    {

        /// <summary>
        /// Resource identifier for this actual row.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Total reported minutes for this resource (sum of TimeEntries).
        /// </summary>
        public int? TotalMinutes { get; set; }

        /// <summary>
        /// Individual timesheet entries contributing to totalMinutes.
        /// </summary>
        public TaskActualTimeEntryDto[] TimeEntries { get; set; }
    }
}
