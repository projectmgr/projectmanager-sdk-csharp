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
    /// Task-level planned work (TotalPlannedMinutes from task Work), per-resource assigned
    /// breakdown (Assigned / TotalAssignedMinutes), workspace-wide reported actual total
    /// (TotalActualMinutes), per-resource reported timesheet rows (Actual), scoped by permission,
    /// and HasTimeEntries (whether any logged minutes exist for the task in the workspace, regardless of Actual visibility).
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
        /// Sum of reported minutes on this task from all resources in the workspace (same merge as internal totals:
        /// direct task id, original task id, and weekly timesheet-task links). This is not limited to the caller&#39;s own entries.
        /// </summary>
        public int? TotalActualMinutes { get; set; }

        /// <summary>
        /// True when at least one timesheet row for this task has non-zero reported minutes in the workspace
        /// (same merge as Astro.Api.Dto.Tasks.TaskTimeSummaryDto.TotalActualMinutes). False when there are none. Unlike Astro.Api.Dto.Tasks.TaskTimeSummaryDto.Actual,
        /// this does not depend on whether the caller can see other resources&#39; entries.
        /// </summary>
        public bool? HasTimeEntries { get; set; }

        /// <summary>
        /// Planned effort by resource, including per-day allocation breakdown where available.
        /// </summary>
        public TaskPlannedResourceTimeDto[] Assigned { get; set; }

        /// <summary>
        /// Reported timesheet time by resource, including individual timesheet rows. Callers with edit-all-projects or
        /// edit-team-timesheets workspace permission see every resource returned by secured timesheet queries; otherwise
        /// only the caller&#39;s own timesheet rows (same idea as the Edit all timesheets / team timesheet capability in roles).
        /// </summary>
        public TaskActualResourceTimeDto[] Actual { get; set; }
    }
}
