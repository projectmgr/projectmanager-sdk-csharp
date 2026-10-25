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
    /// Details about the TaskAssignment a workload allocation belongs to. Only populated when the request
    /// specifies `include=taskAssignment`.
    /// </summary>
    public class ResourceWorkloadTaskAssignmentDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the TaskAssignment.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The total number of minutes assigned to this Resource across all of this TaskAssignment&#39;s allocations.
        /// </summary>
        public int? TotalAssignedMinutes { get; set; }
    }
}
