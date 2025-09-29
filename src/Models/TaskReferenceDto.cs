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
    /// Represents a task that links or depends on another task
    /// </summary>
    public class TaskReferenceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier for the predecessor task.
        /// </summary>
        public Guid? PredecessorId { get; set; }

        /// <summary>
        /// The unique identifier for the successor task.
        /// </summary>
        public Guid? SuccessorId { get; set; }
    }
}
