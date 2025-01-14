/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to TaskTag
    /// </summary>
    public interface ITaskTagClient
    {

        /// <summary>
        /// Replaces the existing TaskTags on a Task with a newly provided list of TaskTags.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many
        /// TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you
        /// classify your Tasks and prioritize work.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will replace TaskTags</param>
        /// <param name="body">The replacement list of TaskTags for this Task</param>
        Task<AstroResult<ChangeSetStatusDto>> ReplaceTaskTags(Guid taskId, NameDto[] body);

        /// <summary>
        /// Add one or more new TaskTags to a Task.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many
        /// TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you
        /// classify your Tasks and prioritize work.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will add TaskTags</param>
        /// <param name="body">The new TaskTags to add to this Task</param>
        Task<AstroResult<ChangeSetStatusDto>> AddTaskTagToTask(Guid taskId, NameDto[] body);

        /// <summary>
        /// Removes one or more existing TaskTags from a Task.
        ///
        /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many
        /// TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you
        /// classify your Tasks and prioritize work.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we will remove existing TaskTags</param>
        /// <param name="body">The TaskTags to remove from this Task</param>
        Task<AstroResult<ChangeSetStatusDto>> RemoveTaskTagFromTask(Guid taskId, NameDto[] body);
    }
}
