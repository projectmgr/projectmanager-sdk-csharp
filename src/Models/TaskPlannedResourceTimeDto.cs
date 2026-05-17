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
    /// Planned time for one resource assigned to the task.
    /// </summary>
    public class TaskPlannedResourceTimeDto : ApiModel
    {

        /// <summary>
        /// Resource identifier for this planned row.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Total planned minutes for this resource (sum of allocations when broken down by day).
        /// </summary>
        public int? TotalMinutes { get; set; }

        /// <summary>
        /// Planned minutes grouped by calendar date for this resource.
        /// </summary>
        public TaskPlannedAllocationDto[] Allocations { get; set; }
    }
}
