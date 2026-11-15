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
    /// Basic details of the Task a workload entry belongs to. Only populated when the request specifies
    /// `include=task`.
    /// </summary>
    public class ResourceWorkloadTaskDetailsDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Task.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique identifier of the Project this Task belongs to.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The name of the Task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Task&#39;s description, in markdown format.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The percentage of the task duration completed.
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// The planned start date of the Task.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedStartDate { get; set; }

        /// <summary>
        /// The planned finish date of the Task.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PlannedFinishDate { get; set; }

        /// <summary>
        /// The actual start date of the Task.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualStartDate { get; set; }

        /// <summary>
        /// The actual finish date of the Task.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ActualFinishDate { get; set; }

        /// <summary>
        /// The Task&#39;s current status (board column).
        /// </summary>
        public TaskStatusDto Status { get; set; }

        /// <summary>
        /// The TaskTags that apply to this Task.
        /// </summary>
        public TaskTagDto[] Tags { get; set; }
    }
}
