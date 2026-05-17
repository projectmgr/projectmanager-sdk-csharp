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
    /// Task-level planned work (Astro.Api.Dto.Tasks.TaskTimeSummaryDto.TotalPlannedMinutes from task Work), per-resource assigned
    /// breakdown (Astro.Api.Dto.Tasks.TaskTimeSummaryDto.Assigned / Astro.Api.Dto.Tasks.TaskTimeSummaryDto.TotalAssignedMinutes), and reported timesheet time (Astro.Api.Dto.Tasks.TaskTimeSummaryDto.Actual).
    /// </summary>
    public class TaskTimeSummaryDto : ApiModel
    {

        /// <summary>
        /// The task&#39;s planned work (Work), in minutes — same as the Gantt &quot;Work&quot; / planned effort on the task.
        /// </summary>
        public int? TotalPlannedMinutes { get; set; }

        /// <summary>
        /// Sum of minutes assigned (per-resource assigned/planned effort from allocations or assignment split).
        /// </summary>
        public int? TotalAssignedMinutes { get; set; }

        /// <summary>
        /// Sum of reported minutes across all resources in actual.
        /// </summary>
        public int? TotalActualMinutes { get; set; }

        /// <summary>
        /// Planned effort by resource, including per-day allocation breakdown where available.
        /// </summary>
        public TaskPlannedResourceTimeDto[] Assigned { get; set; }

        /// <summary>
        /// Reported timesheet time by resource, including individual timesheet rows.
        /// </summary>
        public TaskActualResourceTimeDto[] Actual { get; set; }
    }
}
