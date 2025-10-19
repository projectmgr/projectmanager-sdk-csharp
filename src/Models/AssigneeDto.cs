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
    /// Task assignee dto
    /// </summary>
    public class AssigneeDto : ApiModel
    {

        /// <summary>
        /// Assignee resource id
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Percent of work assigned to task
        /// </summary>
        public decimal? PercentAssignment { get; set; }

        /// <summary>
        /// Effort assigned to the resource for the task.
        /// </summary>
        public int? AssignedEffort { get; set; }
    }
}
